using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CsvToSqlImporter.Models;
using System.Globalization;

namespace CsvToSqlImporter.Services
{
    public class CsvReaderService
    {
        public IEnumerable<SensorRecord> ReadCsv(string filePath)
        {
            using var reader = new StreamReader(filePath);

            // Skip header
            reader.ReadLine();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(',');

                yield return new SensorRecord
                {
                    Timestamp = DateTime.Parse(parts[0], CultureInfo.InvariantCulture),
                    Temp = double.Parse(parts[1], CultureInfo.InvariantCulture),
                    //Temperature = double.Parse(parts[1], CultureInfo.InvariantCulture),
                    Humidity = double.Parse(parts[2], CultureInfo.InvariantCulture),
                    DeviceId = parts[3]
                };
            }
        }
    }
}
