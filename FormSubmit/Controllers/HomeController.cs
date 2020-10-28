using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FormSubmit.Models;
using FormSubmit.Persistence;

namespace FormSubmit.Controllers
{
    public class HomeController : Controller
    {
        private readonly DB _db;

        public HomeController(DB _db)
        {
            this._db = _db;
        }

        public IActionResult Index()
        {
            var data = _db.FormDetail.ToList();

            return View(data);
        }

        public IActionResult CreateHome()
        {
            return View();
        }

        [HttpPost]
        public HttpStatusCode SaveFormData([FromBody] FormDetail data)
        {
            try
            {
                _db.FormDetail.Add(data);
                _db.SaveChanges();

                for(var i= 0;i< data.FormData.Count;i++)
                {
                    data.FormData[i].FormId = data.id;
                    data.FormData[i].Id = long.Parse("0");

                    _db.Add(data.FormData[i]);
                    _db.SaveChanges();


                }
                
                return HttpStatusCode.OK;
            }
            catch (Exception EX)
            {
                return HttpStatusCode.InternalServerError;
            }

        }

        public IActionResult UseForm(long id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }

            var data = _db.FormDetail.FirstOrDefault(x => x.id == id);

            if (data == null) return RedirectToAction("Index");

            var formData = _db.FormData.Where(x => x.FormId == data.id).ToList();

            data.FormData = formData.OrderBy(x => x.DisplayOrder).ToList();

            return View(data);
        }

        [HttpPost]
        public HttpStatusCode UseForm([FromBody] List<vwSubmitData> data)
        {
            var vwSubmitData = data.FirstOrDefault(x => x.ElmId == "id");

            var FormId = long.Parse(vwSubmitData.value);
            var DetailGroup = long.Parse((new Random()).Next(10000, 999999999).ToString());

            var submitData = new List<SubmitData>();

            foreach (var elm in data)
            {
                if (elm.ElmId != "id" && !string.IsNullOrEmpty(elm.ElmId))
                {
                    submitData.Add(new SubmitData()
                    {
                        ElmId = long.Parse(elm.ElmId),
                        value = elm.value,
                        FormId = FormId,
                        id = 0,
                        DetailGroup = DetailGroup
                    });
                }
            }

            _db.SubmitData.AddRange(submitData);
            _db.SaveChanges();

            return HttpStatusCode.OK;
        }

        public IActionResult SubmitFormDetail(long id)
        {

            if (id == 0) return RedirectToAction("Index");

            var SubmitData = (from sd in _db.SubmitData
                              join fd in _db.FormData on sd.ElmId equals fd.Id
                              where sd.FormId == id
                              select new vwSubmitFormDetail
                              {
                                  Label = fd.InputLabel,
                                  Value = sd.value,
                                  DetailGroup = sd.DetailGroup
                              }).ToList();

            var SubmitDataGroup = SubmitData.GroupBy(x => x.DetailGroup).ToList()
                .Select(y => y.ToList()).ToList();

            return View(SubmitDataGroup);
        }


    }
}
