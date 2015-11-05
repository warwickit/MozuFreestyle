using System;
using System.Collections.Generic;
using System.ComponentModel;
using MZ = Mozu.Mozu;
using FS = FreeStyle.FreeStyle;
namespace MozuFreeStyleInterface
{
    public class MozuFreeStyleInterface
    {
        private string _log = "";
        public string Log { get { return _log; } }
        public BackgroundWorker BackgroundWorker;


        public MozuFreeStyleInterface()
        {

        }

        public MozuFreeStyleInterface(string mozuUser, string mozuPassword, string freestyleUser, string freestylePassword)
        {
            MZ.Username = mozuUser;
            MZ.Password = mozuPassword;
            FS.Username  = freestyleUser;
            FS.Password = freestylePassword;
        }


        /** transfer products from mozu to freestyle */
        public void TransferProductsToFreeStyle()
        {
            if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Calling Mozu Product Api");
            int count = 1;
            Mozu mozu = new Mozu();
            FreeStyleInterface freestyle = new FreeStyleInterface();
            Warehouse.Inventory[] products = mozu.getProducts();
            foreach (Warehouse.Inventory product in products) {
                //try {
                    freestyle.saveProduct(product);
                    if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, count++ + ". Saved Freestyle Product " + product.SKU);
                //} catch { }
            }
            if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Finished Transferring Mozu Products to Freestyle");
        }

        /** transfer products from freestyle to mozu */
        public void TransferProductsToMozu(int page=0, string sku=null)
        {
            if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Calling Freestyle Product Api");
            Mozu mozu = new Mozu();
            FreeStyleInterface freestyle = new FreeStyleInterface();
            Warehouse.Inventory[] products = freestyle.getProducts(page, sku);
            if (products == null || products.Length == 0) return;
            int count = 1;
            foreach (Warehouse.Inventory product in products) {
                mozu.saveProduct(product);
                if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, count++ + ". Saved Mozu Product " + product.SKU);
            }
            if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Finished Transferring Freestyle Products to Mozu");
        }


        /** transfer customers from mozu to freestyle */
        public void TransferCustomers()
        {
            Mozu mozu = new Mozu();
            FreeStyleInterface freestyle = new FreeStyleInterface();
            Warehouse.Customer[] customers = mozu.getCustomers();
            foreach (Warehouse.Customer customer in customers) {
                try {
                freestyle.saveCustomer(customer);
                } catch { }
            }
        }

        public void TransferCustomersToFreeStyle(int page=0)
        {
            if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Calling Mozu Customer Api");
            Mozu mozu = new Mozu();
            FreeStyleInterface freestyle = new FreeStyleInterface();
            Warehouse.Customer[] customers = mozu.getCustomers(page);
            foreach (Warehouse.Customer customer in customers) {
                if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Saving Freestyle Customer " + customer.Name);
                freestyle.saveCustomer(customer);
            }
        }

        public void TransferCustomersToMozu(int page=0)
        {
            if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Calling Freestyle Customer Api");
            Mozu mozu = new Mozu();
            FreeStyleInterface freestyle = new FreeStyleInterface();
            Warehouse.Customer[] customers = mozu.getCustomers(page);
            foreach (Warehouse.Customer customer in customers) {
                if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Saving Mozu Customer " + customer.Name);
                freestyle.saveCustomer(customer);
            }
        }


        /** transfer orders from mozu to freestyle */
        public void TransferOrders()
        {
            Mozu mozu = new Mozu();
            FreeStyleInterface freestyle = new FreeStyleInterface();
            Warehouse.Order[] orders = mozu.getOrders();
            foreach (Warehouse.Order order in orders) {
                try { freestyle.saveOrder(order); }
                catch { }
            }
        }

        /** transfer orders from mozu to freestyle */
        public void TransferOrdersToFreestyle(int page=1, string orderNumber=null)
        {
            if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Calling Mozu Order Api");
            Mozu mozu = new Mozu();
            FreeStyleInterface freestyle = new FreeStyleInterface();
            Warehouse.Order[] orders = mozu.getOrders(page, orderNumber);
            foreach (Warehouse.Order order in orders) {
                if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Saving Freestyle Order " + order.OrderNumber);
                freestyle.saveOrder(order);
            }
        }

        /** transfer orders from freestyle to mozu*/
        public void TransferOrdersToMozu(int page=1, string orderNumber=null)
        {
            if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Calling Freestyle Order Api");
            Mozu mozu = new Mozu();
            FreeStyleInterface freestyle = new FreeStyleInterface();
            Warehouse.Order[] orders = mozu.getOrders(page, orderNumber);
            foreach (Warehouse.Order order in orders) {
                if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Saving Mozu Order " + order.OrderNumber);
                freestyle.saveOrder(order);
            }
        }


        /** transfer shipping information from freestyle to mozu */
        public void TransferShipmentConfirmations()
        {
            if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Calling Mozu Order Api");
            Mozu mozu = new Mozu();
            FreeStyleInterface freestyle = new FreeStyleInterface();
            Warehouse.Order[] orders = freestyle.getOrders();
            foreach (Warehouse.Order order in orders) {
                if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Ship Confirm Freestyle Order: " + order.OrderNumber);
                mozu.saveOrder(order);
            }
        }


        /** transfer shipping information from freestyle to mozu */
        public void TransferShipmentConfirmationsToFreestyle()
        {
            if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Calling Mozu Order Api");
            Mozu mozu = new Mozu();
            FreeStyleInterface freestyle = new FreeStyleInterface();
            Warehouse.Order[] orders = mozu.getOrders();
            foreach (Warehouse.Order order in orders) {
                if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Ship Confirm Freestyle Order: " + order.OrderNumber);
                freestyle.saveOrder(order);
            }
        }
        public void TransferShipmentConfirmationsToMozu()
        {
            if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Calling Freestyle Order Api");
            Mozu mozu = new Mozu();
            FreeStyleInterface freestyle = new FreeStyleInterface();
            Warehouse.Order[] orders = mozu.getOrders();
            foreach (Warehouse.Order order in orders) {
                if (this.BackgroundWorker != null) this.BackgroundWorker.ReportProgress(0, "Ship Confirm Mozu Order: " + order.OrderNumber);
                freestyle.saveOrder(order);
            }
        }


    }
}
