using Microsoft.Azure.Devices;
using System;
using System.Threading.Tasks;

namespace ServiceApp
{
    public class Program
    {

        private static ServiceClient serviceClient = ServiceClient.CreateFromConnectionString("HostName=ec-win20-iothubida.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=Mjbk8lweeBRM2LZf0msaFS5E+Dn/dXiQipoEfn5hZP0=");

        static void Main(string[] args)
        {
            Task.Delay(5000).Wait();

            InvokeMethod("DeviceApp", "SetTelemetryInterval", "10").GetAwaiter();
            Console.ReadKey();
        }

        public static async Task InvokeMethod(string deviceId, string methodName, string payload)
        {
            var methodInvocation = new CloudToDeviceMethod(methodName) { ResponseTimeout = TimeSpan.FromSeconds(30) };
            methodInvocation.SetPayloadJson(payload);


            var response = await serviceClient.InvokeDeviceMethodAsync(deviceId, methodInvocation);
            Console.WriteLine($"Response Status: {response.Status}");
            Console.WriteLine(response.GetPayloadAsJson());

        }
    }
}
