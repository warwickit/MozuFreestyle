using System;
using System.Collections.Generic;

namespace MozuFreeStyleInterface
{
    public class MozuFreeStyleInterface
    {
        /** transfer products from mozu to freestyle */
        public void TransferProductsToFreeStyle()
        {
            Mozu mozu = new Mozu();
            FreeStyleInterface freestyle = new FreeStyleInterface();
            Warehouse.Inventory[] products = mozu.getProducts();
            foreach (Warehouse.Inventory product in products) {
                try {
                    freestyle.saveProduct(product);
                } catch { }
            }
        }

        /** transfer products from freestyle to mozu */
        public void TransferProductsToMozu()
        {
            Mozu mozu = new Mozu();
            FreeStyleInterface freestyle = new FreeStyleInterface();
            while (true) {
                Warehouse.Inventory[] products = freestyle.getProducts(1);
                if (products == null || products.Length == 0) break;
                foreach (Warehouse.Inventory product in products) {
                    mozu.saveProduct(product);
                }
            }
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


        /** transfer shipping information from freestyle to mozu */
        public void TransferShipmentConfirmations()
        {
            Mozu mozu = new Mozu();
            FreeStyleInterface freestyle = new FreeStyleInterface();
            Warehouse.Order[] orders = freestyle.getOrders();
            foreach (Warehouse.Order order in orders) {
                mozu.saveOrder(order);
            }
        }

    }
}
