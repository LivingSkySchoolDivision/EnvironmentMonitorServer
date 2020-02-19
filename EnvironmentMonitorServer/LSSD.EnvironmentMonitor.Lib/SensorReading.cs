using System;
using System.Collections.Generic;
using System.Text;

namespace LSSD.EnvironmentMonitor.Lib
{
    public class SensorReading
    {
        public string Name { get; set; }
        public decimal TemperatureCelsius { get; set; }
        public decimal Humidity { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsError { get; set; }
    }
}
