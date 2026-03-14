using CsvToSqlImporter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CsvToSqlImporter.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<SensorRecord> SensorRecords { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }

    }
}
