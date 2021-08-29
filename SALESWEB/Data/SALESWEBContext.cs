using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SALESWEB.Models;

namespace SALESWEB.Data
{
    public class SALESWEBContext : DbContext
    {
        public SALESWEBContext (DbContextOptions<SALESWEBContext> options)
            : base(options)
        {
        }

        public DbSet<SALESWEB.Models.Department> Department { get; set; }
    }
}
