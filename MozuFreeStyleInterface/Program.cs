using System;
using System.ComponentModel;
using System.Threading;
using System.Net;
using System.Text;
using System.IO;
using FreeStyle;
using MZ = Mozu;

namespace MozuFreeStyleInterface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Mozu mozu = new Mozu();
            Warehouse.Inventory product = new Warehouse.Inventory {
                SKU = "test123",
                UPC = "1234567890",
                Price = 12.99
            };
            mozu.saveProduct(product);*/

            /*Warehouse.Inventory product = new Warehouse.Inventory {
                SKU = "test123",
                ID = "The name",
                UPC = "1234567890",
                Price = 12.99,
                Description = "TEST DESCRIPTION",
                Description2 = "TEST DESCRIPTION2",
            };
            Warehouse.Item item = new Warehouse.Item {
                SKU = "test",
                Quantity = 1,
                Price = new Warehouse.Price { Total = 19.99 }
            };
            Warehouse.Customer customer = new Warehouse.Customer {
                FirstName = "Bob",
                LastName = "Hope",
                Address1 = "4400 ENM-Hurlock Rd.",
                City = "Hurlock",
                State = "MD",
                ZipCode = "21643",
                Country = "US",
                Email = "wbkirbs@hotmail.com",//email must be unique
                Phone = "410-943-0696"
            };
            Warehouse.Order order = new Warehouse.Order {
                OrderNumber = "123",
                OrderDate = DateTime.Now,
                BillTo = customer,
                ShipTo = customer,
                Items = new Warehouse.Item[] { item }
            };
            FreeStyleInterface freestyle = new FreeStyleInterface();
            //freestyle.getProducts(1);
            //freestyle.saveProduct(product);
            //freestyle.saveCustomer(customer);
            freestyle.saveOrder(order);
            return;*/

            /** download Mozu data */
            //MozuFreeStyleInterface mf = new MozuFreeStyleInterface();
            //mf.TransferProductsToFreeStyle();
            //mf.TransferProductsToMozu();
            //mf.TransferCustomers();
            //mf.TransferOrders();
            //mf.TransferShipmentConfirmations();

            /** dynamically set user and password from command line - added by wayne bryan on 7/13/2015 */
            MZ.TenantContract.EmailAddress = args[1];
            MZ.TenantContract.Password = args[2];

            /** continually transfer products */
            BackgroundWorker productWorker = new BackgroundWorker();
            productWorker.DoWork += productWorker_DoWork;
            productWorker.RunWorkerAsync();

            /** continually transfer customers */
            BackgroundWorker customerWorker = new BackgroundWorker();
            customerWorker.DoWork += customerWorker_DoWork;
            customerWorker.RunWorkerAsync();

            /** continually transfer orders */
            BackgroundWorker orderWorker = new BackgroundWorker();
            orderWorker.DoWork += orderWorker_DoWork;
            orderWorker.RunWorkerAsync();

            while (true) {
                Thread.Sleep(60 * 60 * 60 * 1000);
            }
        }


        private static int _sleep = 5 * 1000;
        
        
        private static void productWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true) {
                MozuFreeStyleInterface mf = new MozuFreeStyleInterface();
                mf.TransferProductsToFreeStyle();
                Thread.Sleep(_sleep);
            }
        }
 

        private static void customerWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true) {
                MozuFreeStyleInterface mf = new MozuFreeStyleInterface();
                mf.TransferCustomers();
                Thread.Sleep(_sleep);
            }
        }


        private static void orderWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true) {
                MozuFreeStyleInterface mf = new MozuFreeStyleInterface();
                mf.TransferOrders();
                Thread.Sleep(_sleep);
            }
        }


    }
}
