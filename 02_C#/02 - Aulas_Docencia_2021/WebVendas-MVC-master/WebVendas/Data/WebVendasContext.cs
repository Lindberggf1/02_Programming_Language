using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebVendas.Models;

namespace WebVendas.Data
{
    public class WebVendasContext : DbContext
    {
        public WebVendasContext(DbContextOptions<WebVendasContext> options)
            : base(options)
        {
        }

        public DbSet<WebVendas.Models.Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
