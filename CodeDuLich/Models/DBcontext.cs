using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CodeDuLich.Models
{
    public class DBcontext :DbContext
    {
        public DBcontext() : base("MCS") { }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}