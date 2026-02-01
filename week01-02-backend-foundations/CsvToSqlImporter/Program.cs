using CsvToSqlImporter.Data;
using CsvToSqlImporter.Services;

namespace CsvToSqlImporter
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var context = new AppDbContext();
            var csvReader = new CsvReaderService();
            var importService = new ImportService(context);

            var records = csvReader.ReadCsv("sensor_data_temp_humidity.csv");
            await importService.ImportRecordsAsync(records);

            Console.WriteLine("Import completed successfully!");
        }
    }
}
