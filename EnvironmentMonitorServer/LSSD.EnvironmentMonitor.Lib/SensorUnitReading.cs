using System;
using System.Collections.Generic;
using System.Text;

namespace LSSD.EnvironmentMonitor.Lib
{
    public class SensorUnitReading
    {
        public SensorSystem System { get; set; }
        public List<SensorReading> Sensors { get; set; }
        public SensorTroubleshooting Troubleshooting { get; set; }
    }
}
