using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormSubmit.Models
{
    [Table("FormData")]
    public class FormData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        public string guid {get;set;}

        public string InputId { get; set; }

        public string value { get; set; }

        public string Type { get; set; }

        public string InputLabel { get; set; }

        public string InputName { get; set; }

        [Required]
        public long FormId { get; set; }

        [Required]
        public int DisplayOrder { get; set; }

        public string Height { get; set; }

        public string Width { get; set; }

        public string PositionX { get; set; }

        public string PositionY { get; set; }
        public string LayoutId { get; set; }
        public string LayoutType { get; set; }
        public string LayoutColumn { get; set; }


    }

    public class FormDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [NotMapped]
        public List<FormData> FormData { get; set; }
    }


    public class SubmitData
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Required]
        public long ElmId { get; set; }

        [Required]
        public string value { get; set; }

        [Required]
        public long FormId { get; set; }

        [Required]
        public long DetailGroup { get; set; }

    }


    public class vwSubmitData
    {
        public string ElmId { get; set; }

        public string value { get; set; }
    }

    public class vwSubmitFormDetail
    {
        public string Value { get; set; }

        public string Label { get; set; }

        public long DetailGroup { get; set; }
    }


}
