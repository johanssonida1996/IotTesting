using DeviceApp.Service;
using Microsoft.Azure.Devices.Client;
using System;
using System.Text;
using Xunit;

namespace DeviceAppTest
{
    public class SetTelemetryIntervalTest
    {
        
        
            [Fact]
            public void Task_SetTelemetryInterval_SouldReturnOKStatusCode()
            {
                var array = Encoding.UTF8.GetBytes("10");
                var response = DeviceService.SetTelemetryInterval(new MethodRequest("SetTelementryInterval", array), null).GetAwaiter().GetResult();
                

                Assert.Equal(200, response.Status);
            }
        }

    }
    



        


