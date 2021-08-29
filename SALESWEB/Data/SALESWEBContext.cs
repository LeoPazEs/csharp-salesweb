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

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; } 
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
