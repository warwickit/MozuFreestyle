using System;
using System.Collections.Generic;
using Utilities;
using FreeStyle;

namespace MozuFreeStyleInterface
{
    public class FreeStyleInterface
    {
        private int _system = 18;


        public void Download()
        {
            this.downloadProducts();
            this.downloadCustomers();
            this.downloadOrders();
        }


        public void Upload()
        {
            this.uploadProducts();
            this.uploadCustomers();
            this.uploadOrders();
        }


        public Warehouse.Order[] getOrders()
        {
            List<Warehouse.Order> orders = new List<Warehouse.Order>();
            Order[] results = null;
            Order search = new Order();
            search.Page = 1;

            do {
                results = (Order[]) search.Read<Order>();

                /** save each product in the warwick database */
                foreach (Order o in results) {
                    Warehouse.Order order = new Warehouse.Order();
                    order.OrderNumber = o.OrderNumber;
                    order.OrderDate = Utility.getDateTime(o.OrderDate);
                    order.BillTo = new Warehouse.Customer {
                        FirstName = o.BillingAddress.FirstName,
                        LastName = o.BillingAddress.LastName,
                        Address1 = o.BillingAddress.AddressLine1,
                        Address2 = o.BillingAddress.AddressLine2,
                        City = o.BillingAddress.City,
                        State = o.BillingAddress.State,
                        ZipCode = o.BillingAddress.Postcode,
                        Country = o.BillingAddress.Country,
                        Phone = o.BillingAddress.Phone,
                        Email = o.BillingAddress.Email,
                    };
                    order.Shipments[0].ShipTo = new Warehouse.Customer {
                        FirstName = o.ShippingAddress.FirstName,
                        LastName = o.ShippingAddress.LastName,
                        Address1 = o.ShippingAddress.AddressLine1,
                        Address2 = o.ShippingAddress.AddressLine2,
                        City = o.ShippingAddress.City,
                        State = o.ShippingAddress.State,
                        ZipCode = o.ShippingAddress.Postcode,
                        Country = o.ShippingAddress.Country,
                        Phone = o.ShippingAddress.Phone,
                        Email = o.ShippingAddress.Email,
                    };
                    orders.Add(order);
                }
                search.Page++;//go to the next page
            } while (results != null && results.Length > 0);

            return orders.ToArray();
        }


        public Warehouse.Inventory[] getProducts(int page)
        {
            List<Warehouse.Inventory> products = new List<Warehouse.Inventory>();
            Product[] results = null;
            Product search = new Product();
            search.Page = page;

            //do {
                results = (Product[]) search.Read<Product[]>();

                /** save each product in the warwick database */
                foreach (Product p in results) {
                    Warehouse.Inventory item = new Warehouse.Inventory();
                    item.SKU = p.ProductSku;
                    item.UPC = p.UpcCode;
                    item.Description = p.LongDescription;
                    item.Description2 = p.ShortDescription;
                    item.ISBN = p.Isbn;
                    item.Price = (double) p.RetailPrice;
                    products.Add(item);
                }
                search.Page++;//go to the next page
            //} while (results != null && results.Length > 0);

            return products.ToArray();
        }


        private void downloadProducts()
        {
            //Product[] results = null;
            //Product product = new Product();
            //product.Page = 1;

            //do {
            //    results = (Product[]) product.Read<Product>();

            //    /** save each product in the warwick database */
            //    foreach (Product p in results) {
            //        Warehouse.Warwick.Inventory item = new Warehouse.Warwick.Inventory();
            //        item.inventory.system = _system;
            //        item.SKU = p.ProductSku;
            //        item.UPC = p.UpcCode;
            //        item.Description = p.LongDescription;
            //        item.Description2 = p.ShortDescription;
            //        item.ISBN = p.Isbn;
            //        item.Price = (double) p.RetailPrice;
            //        item.inventory.created = Utility.getDateTime(p.CreateTime);
            //        item.inventory.updated = Utility.getDateTime(p.UpdateTime);
            //        item.Save();
            //    }
            //    product.Page++;//go to the next page
            //} while (results != null && results.Length > 0);
        }


        public void saveProduct(Warehouse.Inventory item)
        {
            if (string.IsNullOrWhiteSpace(item.ID)) item.ID = item.SKU;//required
            if (string.IsNullOrWhiteSpace(item.Description2)) item.Description2 = item.SKU;//required

            Product product = new Product();
            product.AvailableQuantity = 100;
            product.ProductSku = item.SKU;
            product.ProductName = item.ID;
            product.UpcCode = item.UPC;
            product.LongDescription = item.Description;
            product.ShortDescription = item.Description2;
            product.Isbn = item.ISBN;
            product.RetailPrice = (decimal) item.Price;
            Console.WriteLine("Saving Free Style Product: " + product.ProductSku);
            product.Create();
            //product.Update();
        }


        public void saveCustomer(Warehouse.Customer c)
        {
            Customer customer = new Customer();
            customer.FirstName = c.FirstName;
            customer.MiddleName = c.MiddleName;
            customer.LastName = c.LastName;
            customer.AddressLine1 = c.Address1;
            customer.AddressLine2 = c.Address2;
            customer.CityName = c.City;
            customer.RegionName = c.State;
            customer.Postcode = c.ZipCode;
            customer.CountryName = c.Country;
            customer.Phone = c.Phone;
            customer.PhoneExtension = c.PhoneExtension;
            customer.Email = c.Email;
            customer.Fax = c.Fax;
            Console.WriteLine("Saving Free Style Customer: " + customer.FirstName + " " + customer.LastName);
            customer.Create();
            //customer.Update();
        }


        public void saveOrder(Warehouse.Order o)
        {
            Order order = new Order();
            order.SalesChannelId = "fa0970f9-1684-4456-bca1-a45a00d945a0";
            order.OrderNumber = o.OrderNumber;
            order.OrderDate = o.OrderDate.ToString();
            order.ShippingMethod = "UPS Ground";
            order.BillingAddress = new Address {
                FirstName = o.BillTo.FirstName,
                LastName = o.BillTo.LastName,
                AddressLine1 = o.BillTo.Address1,
                AddressLine2 = o.BillTo.Address2,
                City = o.BillTo.City,
                State = o.BillTo.State,
                Postcode = o.BillTo.ZipCode,
                Country = o.BillTo.Country,
                Phone = o.BillTo.Phone,
                Email = o.BillTo.Email
            };
            order.ShippingAddress = new Address {
                FirstName = o.ShipTo.FirstName,
                LastName = o.ShipTo.LastName,
                AddressLine1 = o.ShipTo.Address1,
                AddressLine2 = o.ShipTo.Address2,
                City = o.ShipTo.City,
                State = o.ShipTo.State,
                Postcode = o.ShipTo.ZipCode,
                Country = o.ShipTo.Country,
                Phone = o.ShipTo.Phone,
                Email = o.ShipTo.Email
            };
            List<Item> items = new List<Item>();
            foreach (Warehouse.Item item in o.Items) {
            //item.SKU = "test";//temp
                Item product = new Item();
                product.ProductSKU = item.SKU;
                product.Quantity = item.Quantity;
                product.Price = (decimal) item.Price.Total;
                product.Discount = (decimal) item.Price.Discount;
                items.Add(product);
            }
            order.OrderItems = items.ToArray();
            //order.Update();
            Console.WriteLine("Saving Free Style Order: " + order.OrderNumber);
            order.Create();
        }



        private void uploadCustomers(Warehouse.Customer c)
        {
            Customer customer = new Customer();
            customer.FirstName = c.FirstName;
            customer.MiddleName = c.MiddleName;
            customer.LastName = c.LastName;
            customer.AddressLine1 = c.Address1;
            customer.AddressLine2 = c.Address2;
            customer.CityName = c.City;
            customer.RegionName = c.State;
            customer.Postcode = c.ZipCode;
            customer.CountryName = c.Country;
            customer.Phone = c.Phone;
            customer.PhoneExtension = c.PhoneExtension;
            customer.Email = c.Email;
            customer.Fax = c.Fax;
            customer.Update();
        }


        private void uploadOrders(Warehouse.Order o)
        {
            Order order = new Order();
            order.OrderNumber = o.OrderNumber;
            order.OrderDate = o.OrderDate.ToString();
            order.BillingAddress = new Address {
                FirstName = o.BillTo.FirstName,
                LastName = o.BillTo.LastName,
                AddressLine1 = o.BillTo.Address1,
                AddressLine2 = o.BillTo.Address2,
                City = o.BillTo.City,
                State = o.BillTo.State,
                Postcode = o.BillTo.ZipCode,
                Country = o.BillTo.Country,
                Phone = o.BillTo.Phone,
                Email = o.BillTo.Email
            };
            order.ShippingAddress = new Address {
                FirstName = o.ShipTo.FirstName,
                LastName = o.ShipTo.LastName,
                AddressLine1 = o.ShipTo.Address1,
                AddressLine2 = o.ShipTo.Address2,
                City = o.ShipTo.City,
                State = o.ShipTo.State,
                Postcode = o.ShipTo.ZipCode,
                Country = o.ShipTo.Country,
                Phone = o.ShipTo.Phone,
                Email = o.ShipTo.Email
            };
            order.Update();
        }


        private void downloadCustomers()
        {
            //Customer[] results = null;
            //Customer search = new Customer();
            //search.Page = 1;

            //do {
            //    results = (Customer[]) search.Read<Customer>();

            //    /** save each customer in the warwick database */
            //    foreach (Customer c in results) {
            //        Warehouse.Warwick.Customer customer = new Warehouse.Warwick.Customer();
            //        customer.customer.system = _system;
            //        customer.FirstName = c.FirstName;
            //        customer.MiddleName = c.MiddleName;
            //        customer.LastName = c.LastName;
            //        customer.Address1 = c.AddressLine1;
            //        customer.Address2 = c.AddressLine2;
            //        customer.City = c.CityName;
            //        customer.State = c.RegionName;
            //        customer.ZipCode = c.Postcode;
            //        customer.Country = c.CountryName;
            //        customer.Phone = c.Phone;
            //        customer.PhoneExtension = c.PhoneExtension;
            //        customer.Email = c.Email;
            //        customer.Fax = c.Fax;
            //        customer.Save();
            //    }
            //    search.Page++;//go to the next page
            //} while (results != null && results.Length > 0);
        }


        private void downloadOrders()
        {
            //Order[] results = null;
            //Order search = new Order();
            //search.Page = 1;

            //do {
            //    results = (Order[]) search.Read<Order>();

            //    /** save each product in the warwick database */
            //    foreach (Order o in results) {
            //        Warehouse.Warwick.Order order = new Warehouse.Warwick.Order();
            //        order.order.system = _system;
            //        order.OrderNumber = o.OrderNumber;
            //        order.OrderDate = Utility.getDateTime(o.OrderDate);
            //        order.BillTo = new Warehouse.Warwick.Customer {
            //            FirstName = o.BillingAddress.FirstName,
            //            LastName = o.BillingAddress.LastName,
            //            Address1 = o.BillingAddress.AddressLine1,
            //            Address2 = o.BillingAddress.AddressLine2,
            //            City = o.BillingAddress.City,
            //            State = o.BillingAddress.State,
            //            ZipCode = o.BillingAddress.Postcode,
            //            Country = o.BillingAddress.Country,
            //            Phone = o.BillingAddress.Phone,
            //            Email = o.BillingAddress.Email,
            //        };
            //        order.Shipment.ShipTo = new Warehouse.Warwick.Customer {
            //            FirstName = o.ShippingAddress.FirstName,
            //            LastName = o.ShippingAddress.LastName,
            //            Address1 = o.ShippingAddress.AddressLine1,
            //            Address2 = o.ShippingAddress.AddressLine2,
            //            City = o.ShippingAddress.City,
            //            State = o.ShippingAddress.State,
            //            ZipCode = o.ShippingAddress.Postcode,
            //            Country = o.ShippingAddress.Country,
            //            Phone = o.ShippingAddress.Phone,
            //            Email = o.ShippingAddress.Email,
            //        };
            //        order.Save();
            //    }
            //    search.Page++;//go to the next page
            //} while (results != null && results.Length > 0);
        }


        private void uploadProducts()
        {
            //Warehouse.Warwick.Inventory items = new Warehouse.Warwick.Inventory();
            //items.inventory.system = _system;
            //string sql = "select * from inventory where system = " + _system;
            //using (Database.Result result = Database.Warwick.Query(sql)) {
            //    foreach (Database.Row row in result) {
            //        Warehouse.Warwick.Inventory item = new Warehouse.Warwick.Inventory();
            //        item.ID = row["id"].ToString();
            //        item.Read();

            //        Product product = new Product();
            //        product.ProductSku = item.SKU;
            //        product.UpcCode = item.UPC;
            //        product.LongDescription = item.Description;
            //        product.ShortDescription = item.Description2;
            //        product.Isbn = item.ISBN;
            //        product.RetailPrice = (decimal) item.Price;
            //        product.Update();
            //    }
            //}
        }


        private void uploadCustomers()
        {
            //Warehouse.Warwick.Customer customers = new Warehouse.Warwick.Customer();
            //customers.customer.system = _system;
            //string sql = "select * from customers where system = " + _system;
            //using (Database.Result result = Database.Warwick.Query(sql)) {
            //    foreach (Database.Row row in result) {
            //        Warehouse.Warwick.Customer c = new Warehouse.Warwick.Customer();
            //        c.ID = row["id"].ToString();
            //        c.Read();

            //        Customer customer = new Customer();
            //        customer.FirstName = c.FirstName;
            //        customer.MiddleName = c.MiddleName;
            //        customer.LastName = c.LastName;
            //        customer.AddressLine1 = c.Address1;
            //        customer.AddressLine2 = c.Address2;
            //        customer.CityName = c.City;
            //        customer.RegionName = c.State;
            //        customer.Postcode = c.ZipCode;
            //        customer.CountryName = c.Country;
            //        customer.Phone = c.Phone;
            //        customer.PhoneExtension = c.PhoneExtension;
            //        customer.Email = c.Email;
            //        customer.Fax = c.Fax;
            //        customer.Update();
            //    }
            //}
        }


        private void uploadOrders()
        {
            //Warehouse.Warwick.Order orders = new Warehouse.Warwick.Order();
            //orders.order.system = _system;
            //string sql = "select * from orders where system = " + _system;
            //using (Database.Result result = Database.Warwick.Query(sql)) {
            //    foreach (Database.Row row in result) {
            //        Warehouse.Warwick.Order o = new Warehouse.Warwick.Order();
            //        o.ID = row["id"].ToString();
            //        o.Read();

            //        Order order = new Order();
            //        order.OrderNumber = o.OrderNumber;
            //        order.OrderDate = o.OrderDate.ToString();
            //        order.BillingAddress = new Address {
            //            FirstName = o.BillTo.FirstName,
            //            LastName = o.BillTo.LastName,
            //            AddressLine1 = o.BillTo.Address1,
            //            AddressLine2 = o.BillTo.Address2,
            //            City = o.BillTo.City,
            //            State = o.BillTo.State,
            //            Postcode = o.BillTo.ZipCode,
            //            Country = o.BillTo.Country,
            //            Phone = o.BillTo.Phone,
            //            Email = o.BillTo.Email
            //        };
            //        order.ShippingAddress = new Address {
            //            FirstName = o.ShipTo.FirstName,
            //            LastName = o.ShipTo.LastName,
            //            AddressLine1 = o.ShipTo.Address1,
            //            AddressLine2 = o.ShipTo.Address2,
            //            City = o.ShipTo.City,
            //            State = o.ShipTo.State,
            //            Postcode = o.ShipTo.ZipCode,
            //            Country = o.ShipTo.Country,
            //            Phone = o.ShipTo.Phone,
            //            Email = o.ShipTo.Email
            //        };
            //        order.Update();
            //    }
            //}
        }

    }
}
