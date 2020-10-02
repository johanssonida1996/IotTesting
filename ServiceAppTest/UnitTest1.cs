using System;
using Xunit;

namespace ServiceAppTest
{
    public class UnitTest1
    {
        [Fact]
        public void InvokeMethodTest()
        {
            Task test = ServiceApp.Program.InvokeMethod("test", "test", "test");
        }
    }
}
