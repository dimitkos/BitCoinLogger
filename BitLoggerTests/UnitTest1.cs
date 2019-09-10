using System;
using ExternalApi.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BitLoggerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetDataFromBitstamp()
        {
            var service = new BitstampImplementation();

            var response = service.GetDataFromBitstamp();

            Xunit.Assert.NotNull(response);
        }

        [TestMethod]
        public void GetDataFromGdax()
        {
            var service = new GDAXImplementation();

            var response = service.GetDataFromGdax();

            Xunit.Assert.NotNull(response);
        }
    }
}
