using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormSubmit.Controllers;
using FormSubmit.Models;
using Microsoft.EntityFrameworkCore;

namespace FormSubmit.Persistence
{
    public class DB: DbContext
    {
        public DB(DbContextOptions<DB> options): base(options)  
        { }

        public DbSet<FormDetail> FormDetail { get; set; }
        public DbSet<FormData> FormData { get; set; }
        public DbSet<SubmitData> SubmitData { get; set; }

    }
}
