using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CsvToSqlImporter.Data;
using CsvToSqlImporter.Models;
using Microsoft.EntityFrameworkCore;

namespace CsvToSqlImporter.Services
{
    public class ImportService
    {
        private readonly AppDbContext _context;

        public ImportService(AppDbContext context)
        {
            _context = context;
        }

        public async Task ImportRecordsAsync(IEnumerable<SensorRecord> records)
        {
            // Batch size optimization
            const int batchSize = 1000;
            var batch = new List<SensorRecord>(batchSize);

            foreach (var record in records)
            {
                batch.Add(record);

                if (batch.Count >= batchSize)
                {
                    await SaveBatchAsync(batch);
                    batch.Clear();
                }
            }

            // Save remaining records
            if (batch.Count > 0)
            {
                await SaveBatchAsync(batch);
            }
        }

        private async Task SaveBatchAsync(List<SensorRecord> batch)
        {
            await _context.SensorRecords.AddRangeAsync(batch);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear(); // Clear tracking to prevent memory leak
        }
    }
}
