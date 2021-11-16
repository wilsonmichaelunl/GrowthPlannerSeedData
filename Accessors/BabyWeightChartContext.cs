using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Accessors
{
    public class BabyWeightChartContext : DbContext
    {

        public DbSet<WeightChart> WeightCharts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false);
            var configuration = builder.Build();
            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<WeightChart>(
                e =>
                {
                    e.ToTable("weightchart");
                });
        }
    }
}
