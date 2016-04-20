using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace YOLO.Models
{
    public class YOLODbContext : DbContext
    {
        public virtual DbSet<Location> Locations { get; set; }

        public virtual DbSet<Experience> Experiences { get; set; }

        public virtual DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=YOLO;integrated security = True");
        }
    }
}
