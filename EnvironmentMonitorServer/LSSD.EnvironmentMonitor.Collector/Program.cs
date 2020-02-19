using LSSD.EnvironmentMonitor.Lib;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LSSD.EnvironmentMonitor.Collector
{
    class Program
    {
        static void Main(string[] args)
        {

            HttpClient httpClient = new HttpClient();

            Console.WriteLine("Getting sensor data...");
            Task<string> data = httpClient.GetAsync(@"http://10.177.54.161/").Result.Content.ReadAsStringAsync();

            SensorUnitReading reading = JsonConvert.DeserializeObject<SensorUnitReading>(data.Result.ToString());

            Console.WriteLine("Done!");


            Console.WriteLine(reading.System.Hostname);
            foreach(SensorReading sensor in reading.Sensors)
            {
                Console.WriteLine(sensor.Name + ": " + sensor.TemperatureCelsius);
            }
            
        }
    }
}
