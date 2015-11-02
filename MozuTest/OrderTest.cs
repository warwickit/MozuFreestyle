using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mozu.Api.Contracts.CommerceRuntime.Orders;

namespace MozuTest
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void TestDownload()
        {
            Order order = new Order();
            object results = Mozu.Mozu.Request(order);
            Assert.IsNotNull(results);
        }
    }
}
