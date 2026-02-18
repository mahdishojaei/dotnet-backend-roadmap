using CsvToSqlImporter.Data;
using CsvToSqlImporter.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace CsvToSqlImporter
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var builder = Host.CreateDefaultBuilder(args);
            builder.ConfigureServices(( context, services) =>
            {

                IConfiguration config = context.Configuration;

                string myConnectionString = config.GetConnectionString("DefaultConnection")
                    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found."); 

                services.AddDbContext<AppDbContext>(dbOptions =>
                {
                    dbOptions.UseSqlServer(myConnectionString);
                });

                services.AddTransient<CsvReaderService>();
                services.AddTransient<ImportService>();
            });

            IHost host = builder.Build();

            var csvReader = host.Services.GetRequiredService<CsvReaderService>();
            var importService = host.Services.GetRequiredService<ImportService>();
            var records = csvReader.ReadCsv("sensor_data_temp_humidity.csv");
            await importService.ImportRecordsAsync(records);

            Console.WriteLine("Import completed successfully!");
        }
    }
}
