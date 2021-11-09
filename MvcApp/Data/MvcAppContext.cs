using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcApp.Models;

namespace MvcApp.Data
{
    public class MvcAppContext : DbContext
    {
        public MvcAppContext(DbContextOptions<MvcAppContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("MvcAppContext", builder =>
        //    {
        //        builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
        //    });
        //    base.OnConfiguring(optionsBuilder);
        //}
        public DbSet<Product> Product { get; set; }
    }
}
