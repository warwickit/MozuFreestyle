using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mozu.Api.Contracts.Customer;

namespace MozuTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestDownload()
        {
            CustomerAccount customer = new CustomerAccount();
            object results = Mozu.Mozu.Request(customer);
            Assert.IsNotNull(results);
        }
    }
}
