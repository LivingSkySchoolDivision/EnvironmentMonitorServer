using System;
using System.Collections.Generic;
using System.Text;

namespace LSSD.EnvironmentMonitor.Lib
{
    public class SensorSystem
    {
        public string Hostname { get; set; }
        public decimal CPUTempCelsius { get; set; }
        public decimal UptimeSeconds { get; set; }
    }
}
