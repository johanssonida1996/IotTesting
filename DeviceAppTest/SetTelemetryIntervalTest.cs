using DeviceApp.Service;
using Microsoft.Azure.Devices.Client;
using System;
using Xunit;

namespace DeviceAppTest
{
    public class SetTelemetryIntervalTest
    {
        private DeviceClient deviceClient = DeviceClient.CreateFromConnectionString("", TransportType.Mqtt);

        [Theory]
        [InlineData("SetTelementryInterval","10", 200)]
        [InlineData("SetInterval", "10", 501)]

        public void SetTelementryInterval_ShouldChangeTheInterval(string methodName, string payload, int statusCode)
        {
            deviceClient.SetMethodDefaultHandlerAsync(methodName, DeviceService.SetTelemetryInterval, null).Wait();
            Assert.Equal
        }

    }
}
