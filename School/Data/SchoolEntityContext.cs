using Microsoft.EntityFrameworkCore;
using School.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace School.Data
{
    public class SchoolEntityContext: DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<City> Cities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=ROOT123;Persist Security Info=True;User ID=sa;Initial Catalog=webescola;Data Source=DESKTOP-7AV68TG");
        }
    }
}