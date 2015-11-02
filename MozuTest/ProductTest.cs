using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mozu.Api.Contracts.ProductAdmin;

namespace MozuTest
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void TestDownload()
        {
            Product product = new Product();
            object results = Mozu.Mozu.Request(product);
            Assert.IsNotNull(results);
        }
    }
}
