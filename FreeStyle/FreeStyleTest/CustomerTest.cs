using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FreeStyle;

namespace FreeStyleTest
{
    [TestClass]
    public class CustomerTest : IFreeStyleTestInterface
    {
        [TestMethod]
        public void TestReadById()
        {
            Customer customer = new Customer();
            customer.ID = "1";
            Customer[] results = (Customer[]) customer.Read<Customer>();

            Assert.AreEqual(1, results.Length);
            
            Customer result = results[0];
            Assert.AreEqual(customer.ID, customer.ID);
        }


        [TestMethod]
        public void TestSearch()
        {
            string search = "Smith";
            Customer customer = new Customer();
            customer.LastName = search;

            Customer[] results = (Customer[]) customer.Read<Customer>();
            Assert.IsTrue(results.Length > 1);

            foreach (Customer o in results) {
                Assert.IsTrue(o.LastName.Contains(search));
            }
        }


        [TestMethod]
        public void TestList()
        {
            int limit = 5, page = 1;
            Customer customer = new Customer();
            customer.Page = page++;
            customer.Limit = limit;
            Customer[] results = (Customer[]) customer.Read<Customer[]>();
            Assert.AreEqual(limit, results.Length);
        }


        [TestMethod]
        public object TestCreate()
        {
            Customer customer = new Customer(Warehouse.Random.Customer);
            customer.Create();
            return customer;
        }


        [TestMethod]
        public void TestUpdate()
        {
            Customer customer = new Customer();
            customer.CustomerNumber = "1";
            customer.Update();
        }


        [TestMethod]
        public void TestDelete()
        {
            Customer customer = new Customer();
            customer.CustomerNumber = "1";
            customer.Delete();
        }
    }
}
