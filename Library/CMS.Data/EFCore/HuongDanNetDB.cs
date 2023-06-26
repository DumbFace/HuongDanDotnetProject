using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain.Courses;
using CMS.Core.Domain.Lessons;
using CMS.Core.Domain.Topics;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CMS.Data.EFCore
{


    public class HuongDanNetDB : DbContext
    {
        public HuongDanNetDB(DbContextOptions<HuongDanNetDB> options)
          : base(options)
        {
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESSKHANG;Database=HuongDanNet;Trusted_Connection=True;");
        // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().Navigation(e => e.Courses).AutoInclude();
            modelBuilder.Entity<Course>().Navigation(e => e.Lessons).AutoInclude();
        }

        public DbSet<Topic> Topic { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

    public class DatabaseContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=.\\EXPRESSKHANG;Database=HuongDanNet;Trusted_Connection=True;");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }

    public class DatabaseHuongDanNetDBContextFactory : IDesignTimeDbContextFactory<HuongDanNetDB>
    {
        public HuongDanNetDB CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HuongDanNetDB>();
            optionsBuilder.UseSqlServer("Server=.\\EXPRESSKHANG;Database=HuongDanNet;Trusted_Connection=True;");

            return new HuongDanNetDB(optionsBuilder.Options);
        }
    }
}