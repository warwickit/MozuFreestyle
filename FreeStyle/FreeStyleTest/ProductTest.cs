using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FreeStyle;

namespace FreeStyleTest
{
    [TestClass]
    public class ProductTest : IFreeStyleTestInterface
    {
        [TestMethod]
        public void TestReadById()
        {
            Product product = new Product();
            product.ID = "1";
            Product[] results = (Product[]) product.Read<Product>();

            Assert.AreEqual(1, results.Length);
            
            Product result = results[0];
            Assert.AreEqual(product.ID, product.ID);
        }


        [TestMethod]
        public void TestSearch()
        {
            string search = "e";
            Product product = new Product();
            product.LongDescription = search;

            Product[] results = (Product[]) product.Read<Product>();
            Assert.IsTrue(results.Length > 1);

            foreach (Product p in results) {
                Assert.IsTrue(p.LongDescription.Contains(search));
            }
        }


        [TestMethod]
        public void TestList()
        {
            int limit = 5, page = 1;
            Product product = new Product();
            product.Page = page++;
            product.Limit = limit;
            Product[] results = (Product[]) product.Read<Product[]>();
            Assert.AreEqual(limit, results.Length);
        }


        [TestMethod]
        public object TestCreate()
        {
            Product product = new Product(Warehouse.Random.Inventory);
            product.Create();
            return product;
        }


        [TestMethod]
        public void TestUpdate()
        {
            Product product = new Product();
            product.ProductSku = "test1";
            product.LongDescription = "This description was updated.";
            product.Update();
        }


        [TestMethod]
        public void TestDelete()
        {
            Product product = new Product();
            product.ProductSku = "test1";
            product.Delete();
        }

    }
}
