﻿using EF_Core_Practices.Data.Config;
using Microsoft.EntityFrameworkCore;


namespace EF_Core_Practices
{
    public class AppDBContext : DbContext
    {
        public DbSet<Students> students { get; set; } = null!;

        public AppDBContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // new StudentsConfigurations().Configure(modelBuilder.Entity<Students>());

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentsConfigurations).Assembly);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);


        //    var config = new ConfigurationBuilder()
        //               .AddJsonFile("appSettings.json")
        //               .Build();
        //    var ConnectionString = config.GetSection("ConnectionStrings").Value;

        //    optionsBuilder.UseSqlServer(ConnectionString);
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Students>()
        //        .HasKey(s => s.StudentID);
        //}

    }
}
