using DeviceApp.Service;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;



namespace DeviceApp
{
    class Program
    {       

        static void Main(string[] args)
        {
            DeviceService.deviceClient.SetMethodHandlerAsync("SetTelemetryInterval", DeviceService.SetTelemetryInterval, null).Wait();
            DeviceService.SendMessageAsync().GetAwaiter();

            Console.ReadKey();
        }              
    }
}
