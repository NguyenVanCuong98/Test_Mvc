using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mvc_Demo.Models;

namespace Mvc_Demo.Data
{
    public class Mvc_DemoContext : DbContext
    {
        public Mvc_DemoContext (DbContextOptions<Mvc_DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Mvc_Demo.Models.Movie> Movie { get; set; }

        public DbSet<Mvc_Demo.Models.Category> Category { get; set; }

        public DbSet<Mvc_Demo.Models.Employee> Employee { get; set; }

        public DbSet<Mvc_Demo.Models.People> People { get; set; }

        public DbSet<Mvc_Demo.Models.Person> Person { get; set; }

        public DbSet<Mvc_Demo.Models.Product> Product { get; set; }

        public DbSet<Mvc_Demo.Models.Student> Student { get; set; }
    }
}
