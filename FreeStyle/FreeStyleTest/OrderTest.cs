using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FreeStyle;

namespace FreeStyleTest
{
    public class OrderTest : IFreeStyleTestInterface
    {
        [TestMethod]
        public void TestReadById()
        {
            Order order = new Order();
            order.ID = "1";
            Order[] results = (Order[]) order.Read<Order>();

            Assert.AreEqual(1, results.Length);
            
            Order result = results[0];
            Assert.AreEqual(order.ID, order.ID);
        }


        [TestMethod]
        public void TestSearch()
        {
            string search = "Active";
            Order order = new Order();
            order.OrderStatus = search;

            Order[] results = (Order[]) order.Read<Order>();
            Assert.IsTrue(results.Length > 1);

            foreach (Order o in results) {
                Assert.IsTrue(o.OrderStatus.Contains(search));
            }
        }


        [TestMethod]
        public void TestList()
        {
            int limit = 5, page = 1;
            Order order = new Order();
            order.Page = page++;
            order.Limit = limit;
            Order[] results = (Order[]) order.Read<Order>();
            Assert.AreEqual(limit, results.Length);
        }


        [TestMethod]
        public object TestCreate()
        {
            Order order = new Order();
            order.OrderNumber = "test1";
            order.Create();
            return order;
        }


        [TestMethod]
        public void TestUpdate()
        {
            Order order = new Order();
            order.OrderNumber = "test1";
            order.Update();
        }


        [TestMethod]
        public void TestDelete()
        {
            Order order = new Order();
            order.OrderNumber = "test1";
            order.Delete();
        }
    }
}
