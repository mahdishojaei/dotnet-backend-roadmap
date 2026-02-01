using CsvToSqlImporter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CsvToSqlImporter.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<SensorRecord> SensorRecords { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // خواندن از appsettings.json
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false)
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // تنظیمات اضافی برای مدل‌ها
            modelBuilder.Entity<SensorRecord>()
                .HasKey(s => s.Id);

            modelBuilder.Entity<SensorRecord>()
                .Property(s => s.Timestamp)
                .IsRequired();
        }
    }
}
