using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain.Courses;
using CMS.Core.Domain.Lessons;
using CMS.Core.Domain.Topics;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data.EFCore
{


    public class HuongDanNetDB : DbContext
    {
        public HuongDanNetDB()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS02;Database=HuongDanNet;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().Navigation(e => e.Courses).AutoInclude();
            modelBuilder.Entity<Course>().Navigation(e => e.Lessons).AutoInclude();
        }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

    }
}