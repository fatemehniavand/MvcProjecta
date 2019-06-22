using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NA_MVC.Models;

namespace NA_MVC.DAL
{
    public class MVCDBFinall : DbContext
    {
        public MVCDBFinall(): base("name = MVCDBFinall")
            {

            }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Company> Companies { get; set; }
       

    }
}