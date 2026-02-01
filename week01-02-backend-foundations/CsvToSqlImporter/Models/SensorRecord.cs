using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvToSqlImporter.Models
{
    public class SensorRecord
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }

        //public double Temperature { get; set; }
        public double Temp { get; set; }
        public double Humidity { get; set; }
        public double Gas { get; set; }
        public string DeviceId { get; set; }
    }
}
