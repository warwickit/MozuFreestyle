using System;
using System.Collections.Generic;
using Mozu.Api.Contracts.Customer;
using Mozu.Api.Contracts.ProductAdmin;
using Mozu.Api.Contracts.CommerceRuntime.Orders;
using MZ = Mozu.Mozu;
using Utilities;
using Utilities.Network;

using System.Net;
using System.Text;
using System.IO;

namespace MozuFreeStyleInterface
{
    public class Mozu
    {
        private int _system = 19;
        private HTTP _http = new HTTP();
        private HttpWebRequest _httpRequest;
        private string _accessToken;


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


        private static List<string> itemsAdded = new List<string>();//temp
        private static List<string> customersAdded = new List<string>();//temp
        private static List<string> ordersAdded = new List<string>();//temp
        public Warehouse.Inventory[] getProducts()
        {
            List<Warehouse.Inventory> items = new List<Warehouse.Inventory>();
            Product products = new Product();
            ProductCollection results = (ProductCollection) MZ.Request(products, typeof(ProductCollection));
            if (results.Items != null) {
                foreach (Product product in results.Items) {
                    if (product.AuditInfo == null) continue;
                    if (Utility.getDateTime(product.AuditInfo.CreateDate) < new DateTime(2015, 5, 28)) continue;

                    Warehouse.Inventory item = new Warehouse.Inventory();
                    item.SKU = product.ProductCode;
                    item.UPC = product.Upc;
                    item.Price = (double) product.Price.Price;
                    if (product.ProductInCatalogs != null && product.ProductInCatalogs.Count > 0) {
                        item.Description = product.ProductInCatalogs[0].Content.ProductFullDescription;
                        item.Description2 = product.ProductInCatalogs[0].Content.ProductShortDescription;
                        if (item.Description != null) item.Description = item.Description.Replace("?", "");
                        if (item.Description2 != null) item.Description2 = item.Description2.Replace("?", "");
                    }
                    
                    if (itemsAdded.Contains(item.SKU)) continue;
                    itemsAdded.Add(item.SKU);
                    items.Add(item);
                }
            }

            return items.ToArray();
        }


        public Warehouse.Customer[] getCustomers()
        {
            List<Warehouse.Customer> customerList = new List<Warehouse.Customer>();
            CustomerAccount customers = new CustomerAccount();
            CustomerAccountCollection results = (CustomerAccountCollection) MZ.Request(customers, typeof(CustomerAccountCollection));
            if (results.Items != null) {
                foreach (CustomerAccount customer in results.Items) {
                    if (customer.AuditInfo == null) continue;
                    if (Utility.getDateTime(customer.AuditInfo.CreateDate) < new DateTime(2015, 5, 28)) continue;

                    Warehouse.Customer c = new Warehouse.Customer();
                    c.FirstName = customer.FirstName;
                    c.LastName = customer.LastName;
                    if (customer.Contacts != null && customer.Contacts.Count > 0) {
                        CustomerContact contact = customer.Contacts[0];
                        c.Address1 = contact.Address.Address1;
                        c.Address2 = contact.Address.Address2;
                        c.City = contact.Address.CityOrTown;
                        c.State = contact.Address.StateOrProvince;
                        c.ZipCode = contact.Address.PostalOrZipCode;
                        c.Country = contact.Address.CountryCode;
                        c.Phone = contact.PhoneNumbers.Home;
                    }
                    c.Email = customer.EmailAddress;
                    if (string.IsNullOrWhiteSpace(c.Email)) continue;
                    
                    if (! string.IsNullOrWhiteSpace(c.Email)) {
                        if (customersAdded.Contains(c.Email)) continue;
                        customersAdded.Add(c.Email);
                    }

                    customerList.Add(c);
                }
            }

            return customerList.ToArray();
        }


        public Warehouse.Order[] getOrders()
        {
            List<Warehouse.Order> orderList = new List<Warehouse.Order>();
            Order orders = new Order();
            OrderCollection results = (OrderCollection) MZ.Request(orders, typeof(OrderCollection));
            if (results.Items != null) {
                foreach (Order o in results.Items) {
                    if (o.AuditInfo == null) continue;
                    if (Utility.getDateTime(o.AuditInfo.CreateDate) < new DateTime(2015, 5, 28)) continue;

                    Warehouse.Order order = new Warehouse.Order();
                    order.OrderNumber = o.OrderNumber.ToString();
                    order.OrderDate = Utility.getDateTime(o.SubmittedDate);
                    
                    if (o.BillingInfo == null) continue;
                    order.BillTo = new Warehouse.Customer {
                        FirstName = o.BillingInfo.BillingContact.FirstName,
                        LastName = o.BillingInfo.BillingContact.LastNameOrSurname,
                        Address1 = o.BillingInfo.BillingContact.Address.Address1,
                        Address2 = o.BillingInfo.BillingContact.Address.Address2,
                        City = o.BillingInfo.BillingContact.Address.CityOrTown,
                        State = o.BillingInfo.BillingContact.Address.StateOrProvince,
                        ZipCode = o.BillingInfo.BillingContact.Address.PostalOrZipCode,
                        Country = o.BillingInfo.BillingContact.Address.CountryCode,
                        Phone = o.BillingInfo.BillingContact.PhoneNumbers.Home,
                        Email = o.BillingInfo.BillingContact.Email,
                    };
                    if (o.Shipments != null && o.Shipments.Count > 0) {
                        order.ShipTo = new Warehouse.Customer {
                            FirstName = o.Shipments[0].DestinationAddress.FirstName,
                            LastName = o.Shipments[0].DestinationAddress.LastNameOrSurname,
                            Address1 = o.Shipments[0].DestinationAddress.Address.Address1,
                            Address2 = o.Shipments[0].DestinationAddress.Address.Address2,
                            City = o.Shipments[0].DestinationAddress.Address.CityOrTown,
                            State = o.Shipments[0].DestinationAddress.Address.StateOrProvince,
                            ZipCode = o.Shipments[0].DestinationAddress.Address.PostalOrZipCode,
                            Country = o.Shipments[0].DestinationAddress.Address.CountryCode,
                            Phone = o.Shipments[0].DestinationAddress.PhoneNumbers.Home,
                            Email = o.Shipments[0].DestinationAddress.Email,
                        };
                    } else {
                        order.ShipTo = new Warehouse.Customer {
                            FirstName = o.FulfillmentInfo.FulfillmentContact.FirstName,
                            LastName = o.FulfillmentInfo.FulfillmentContact.LastNameOrSurname,
                            Address1 = o.FulfillmentInfo.FulfillmentContact.Address.Address1,
                            Address2 = o.FulfillmentInfo.FulfillmentContact.Address.Address2,
                            City = o.FulfillmentInfo.FulfillmentContact.Address.CityOrTown,
                            State = o.FulfillmentInfo.FulfillmentContact.Address.StateOrProvince,
                            ZipCode = o.FulfillmentInfo.FulfillmentContact.Address.PostalOrZipCode,
                            Country = o.FulfillmentInfo.FulfillmentContact.Address.CountryCode,
                            Phone = o.FulfillmentInfo.FulfillmentContact.PhoneNumbers.Home,
                            Email = o.FulfillmentInfo.FulfillmentContact.Email,
                        };
                    }

                    /** add the items */
                    List<Warehouse.Item> items = new List<Warehouse.Item>();
                    foreach (OrderItem item in o.Items) {
                        Warehouse.Item i = new Warehouse.Item();
                        i.SKU = item.Product.ProductCode;
                        i.Quantity = item.Quantity;
                        i.Price.Total = (double) item.Product.Price.Price;
                        if (i.Price.Total == 0) continue;
                        items.Add(i);
                    }
                    order.Items = items.ToArray();
                    if (order.Items.Length == 0) continue;

                    if (ordersAdded.Contains(order.OrderNumber)) continue;
                    ordersAdded.Add(order.OrderNumber);

                    orderList.Add(order);
                }
            }

            return orderList.ToArray();
        }


        public void saveOrder(Warehouse.Order o)
        {
            Order order = new Order();
            order.OrderNumber = Utility.getInt(o.OrderNumber);
            order.SubmittedDate = o.OrderDate;
            order.Subtotal = (decimal) o.Price.SubTotal;
            order.TaxTotal = (decimal) o.Price.Tax;
            order.DiscountedTotal = (decimal) o.Price.Discount;
            order.ShippingTotal = (decimal) o.Price.ShippingCost;
            order.Total = (decimal) o.Price.Total;
            global::Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment shipment = new global::Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment();
            global::Mozu.Api.Contracts.Core.Contact contact = new global::Mozu.Api.Contracts.Core.Contact();
            global::Mozu.Api.Contracts.Core.Address address = new global::Mozu.Api.Contracts.Core.Address();
            address.Address1 = o.ShipTo.Address1;
            address.Address2 = o.ShipTo.Address2;
            address.Address3 = o.ShipTo.Address3;
            address.CityOrTown = o.ShipTo.City;
            address.StateOrProvince = o.ShipTo.State;
            address.PostalOrZipCode = o.ShipTo.ZipCode;
            address.CountryCode = o.ShipTo.Country;
            contact.PhoneNumbers = new global::Mozu.Api.Contracts.Core.Phone();
            contact.PhoneNumbers.Home = o.ShipTo.Phone;
            contact.PhoneNumbers.Mobile = o.ShipTo.Phone2;
            contact.Address = address;
            shipment.DestinationAddress = contact;
            order.Shipments.Add(shipment);
            MZ.Request(order, null, true);
        }


        public void saveProduct(Warehouse.Inventory item)
        {
            /*Product product = new Product();
            product.ProductCode = item.SKU;
            product.Upc = item.UPC;
            product.Price = new ProductPrice();
            product.Price.Price = (decimal) item.Price;

            product.MasterCatalogId = 1;

            Console.WriteLine("Saving Mozu Product: {0}", product.ProductCode);
            MZ.Request(product, null, true);*/

            this.login();
            this.getAccessToken();
            this.loginConsole();
            this.loginSandbox();
            //return;

            HttpWebRequest request = WebRequest.Create("https://developer.mozu.com/console") as HttpWebRequest;
            request.CookieContainer = _httpRequest.CookieContainer;
            using (HttpWebResponse httpResponse = request.GetResponse() as HttpWebResponse) {
                using (Stream stream = httpResponse.GetResponseStream()) {
                    StreamReader reader = new StreamReader(stream);
                    string html = reader.ReadToEnd();
                }
            }


            request = WebRequest.Create("https://t7949.sandbox.mozu.com/Admin/t-7949/") as HttpWebRequest;
            request.CookieContainer = _httpRequest.CookieContainer;
            using (HttpWebResponse httpResponse = request.GetResponse() as HttpWebResponse) {
                using (Stream stream = httpResponse.GetResponseStream()) {
                    StreamReader reader = new StreamReader(stream);
                    string html = reader.ReadToEnd();
                }
            }
            
            //string html = _http.GET("https://developer.mozu.com/console");
            //System.IO.File.WriteAllText(@"..\output.html", html);
        }


        private void login()
        {
            //_http.AddHeader("Cookie", "optimizelySegments=%7B%22400030121%22%3A%22gc%22%2C%22401210090%22%3A%22direct%22%2C%22401990081%22%3A%22false%22%7D; optimizelyEndUserId=oeu1432731701161r0.2258823139127344; optimizelyBuckets=%7B%7D; _ga=GA1.2.1790374536.1432731701; _gat=1; optimizelyPendingLogEvents=%5B%5D; _mkto_trk=id:702-MYH-396&token:_mch-mozu.com-1432731702168-33647");
            //_http.POST("https://www.mozu.com/login/home/login", "ReturnUrl=%2Flogin%2Fto%3FscopeType%3DTenant%26redirectUrl%3D%252fAdmin%252f&Email=wayne.bryan%40warwickfulfillment.com&Password=buBBa202");


            string url = "https://www.mozu.com/login/home/login";
            string requestParams = "ReturnUrl=%2Flogin%2Fto%3Fscopetype%3Ddeveloper%26%2F%3Fredirecturl%3D%2Fhome&Email=wayne.bryan%40warwickfulfillment.com&Password=buBBa202";
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] data = encoding.GetBytes(requestParams);

            //setup the request
            _httpRequest = (HttpWebRequest) WebRequest.Create(url);
            _httpRequest.Host = "www.mozu.com";
            _httpRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            _httpRequest.Headers.Add("Origin", "https://www.mozu.com");
            _httpRequest.Headers.Add("Cache-Control", "max-age=0");
            _httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.65 Safari/537.36";
            _httpRequest.Referer = "https://www.mozu.com/login/?ReturnUrl=%2flogin%2fto%3fscopetype%3ddeveloper%26%2f%3fredirecturl%3d%2fhome&scopetype=developer&/?redirecturl=/home";
            //_httpRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
            _httpRequest.Headers.Add("Accept-Language", "en-US,en;q=0.8");
            Uri target = new Uri("http://www.mozu.com/");
            CookieContainer cookies = new CookieContainer();
            Cookie cookie1 = new Cookie("optimizelySegments", "%7B%22400030121%22%3A%22gc%22%2C%22401210090%22%3A%22direct%22%2C%22401990081%22%3A%22false%22%7D") { Domain = target.Host };
            Cookie cookie2 = new Cookie("optimizelyBuckets", "%7B%7D") { Domain = target.Host };
            Cookie cookie3 = new Cookie("_ga", "GA1.2.1790374536.1432731701") { Domain = target.Host };
            Cookie cookie4 = new Cookie("_gat", "1") { Domain = target.Host };
            Cookie cookie5 = new Cookie("optimizelyPendingLogEvents", "%5B%5D") { Domain = target.Host };
            Cookie cookie6 = new Cookie("_mkto_trk", "id:702-MYH-396&token:_mch-mozu.com-1432731702168-33647") { Domain = target.Host };
            cookies.Add(cookie1);
            cookies.Add(cookie2);
            cookies.Add(cookie3);
            cookies.Add(cookie4);
            cookies.Add(cookie5);
            cookies.Add(cookie6);
            _httpRequest.CookieContainer = cookies;
            _httpRequest.Method        = "POST";
            _httpRequest.ContentType   = "application/x-www-form-urlencoded";
            _httpRequest.ContentLength = data.Length;
            //_httpRequest.Credentials = CredentialCache.DefaultNetworkCredentials;

            //custom headers...
            _httpRequest.KeepAlive = true;
            _httpRequest.Date = DateTime.Now;
            //_httpRequest.Headers.Add("Cache-Control", "no-cache");
            //_httpRequest.Headers.Add("Connection", "Keep-Alive");

            _httpRequest.AllowAutoRedirect = false;//don't follow 302 response

            //write the post data
            using (Stream stream = _httpRequest.GetRequestStream()) {
               stream.Write(data,0,data.Length);
            }

            //process the response
            using (HttpWebResponse httpResponse = _httpRequest.GetResponse() as HttpWebResponse) {
                using (Stream stream = httpResponse.GetResponseStream()) {
                    StreamReader reader = new StreamReader(stream);
                    string response = reader.ReadToEnd();
                }

                /** save cookies */
                foreach (Cookie cookie in httpResponse.Cookies) {
                    _httpRequest.CookieContainer.Add(cookie);
                }
            }//using HttpWebResponse
        }


        
        private void loginSandbox()
        {
            string url = "https://www.mozu.com/login/home/login";
            string requestParams = "ReturnUrl=%2Flogin%2Fto%3Fscopetype%3Dtenant%26scopeid%3D7949&Email=wayne.bryan%40warwickfulfillment.com&Password=buBBa202";
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] data = encoding.GetBytes(requestParams);

            //setup the request
            _httpRequest = (HttpWebRequest) WebRequest.Create(url);
            _httpRequest.Host = "www.mozu.com";
            _httpRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            _httpRequest.Headers.Add("Origin", "https://www.mozu.com");
            _httpRequest.Headers.Add("Cache-Control", "max-age=0");
            _httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.65 Safari/537.36";
            _httpRequest.Referer = "https://www.mozu.com/login/?ReturnUrl=%2flogin%2fto%3fscopetype%3ddeveloper%26%2f%3fredirecturl%3d%2fhome&scopetype=developer&/?redirecturl=/home";
            //_httpRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
            _httpRequest.Headers.Add("Accept-Language", "en-US,en;q=0.8");
            Uri target = new Uri("http://www.mozu.com/");
            CookieContainer cookies = new CookieContainer();
            Cookie cookie1 = new Cookie("optimizelySegments", "%7B%22400030121%22%3A%22gc%22%2C%22401210090%22%3A%22direct%22%2C%22401990081%22%3A%22false%22%7D") { Domain = target.Host };
            Cookie cookie2 = new Cookie("optimizelyBuckets", "%7B%7D") { Domain = target.Host };
            Cookie cookie3 = new Cookie("_ga", "GA1.2.1790374536.1432731701") { Domain = target.Host };
            Cookie cookie4 = new Cookie("_gat", "1") { Domain = target.Host };
            Cookie cookie5 = new Cookie("optimizelyPendingLogEvents", "%5B%5D") { Domain = target.Host };
            Cookie cookie6 = new Cookie("_mkto_trk", "id:702-MYH-396&token:_mch-mozu.com-1432731702168-33647") { Domain = target.Host };
            cookies.Add(cookie1);
            cookies.Add(cookie2);
            cookies.Add(cookie3);
            cookies.Add(cookie4);
            cookies.Add(cookie5);
            cookies.Add(cookie6);
            _httpRequest.CookieContainer = cookies;
            _httpRequest.Method        = "POST";
            _httpRequest.ContentType   = "application/x-www-form-urlencoded";
            _httpRequest.ContentLength = data.Length;
            //_httpRequest.Credentials = CredentialCache.DefaultNetworkCredentials;

            //custom headers...
            _httpRequest.KeepAlive = true;
            _httpRequest.Date = DateTime.Now;
            //_httpRequest.Headers.Add("Cache-Control", "no-cache");
            //_httpRequest.Headers.Add("Connection", "Keep-Alive");

            _httpRequest.AllowAutoRedirect = false;//don't follow 302 response

            //write the post data
            using (Stream stream = _httpRequest.GetRequestStream()) {
               stream.Write(data,0,data.Length);
            }

            //process the response
            using (HttpWebResponse httpResponse = _httpRequest.GetResponse() as HttpWebResponse) {
                using (Stream stream = httpResponse.GetResponseStream()) {
                    StreamReader reader = new StreamReader(stream);
                    string response = reader.ReadToEnd();
                }

                /** save cookies */
                foreach (Cookie cookie in httpResponse.Cookies) {
                    _httpRequest.CookieContainer.Add(cookie);
                }
            }//using HttpWebResponse
        }


        private void getAccessToken()
        {
            HttpWebRequest request = WebRequest.Create("https://www.mozu.com/login/to?scopetype=developer&/?redirecturl=/home") as HttpWebRequest;
            request.AllowAutoRedirect = false;
            request.CookieContainer = _httpRequest.CookieContainer;
            using (HttpWebResponse httpResponse = request.GetResponse() as HttpWebResponse) {
                using (Stream stream = httpResponse.GetResponseStream()) {
                    StreamReader reader = new StreamReader(stream);
                    string html = reader.ReadToEnd();
                    foreach (string line in html.Split('\n')) {
                        if (line.Contains(@"name=""accessToken""")) {
                            int index = line.IndexOf("value=\"") + 7;
                            _accessToken = line.Substring(index, line.IndexOf("\"", index) - index);
                        }
                    }
                }
            }
        }


        private void loginConsole()
        {
            string url = "https://developer.mozu.com/console/auth/posthandler ";
            string requestParams = "redirectUrl=&accessToken=" + _accessToken;
        requestParams = "redirectUrl=&accessToken=wwdtkaa0zC3ENzufDYrK4MweQ2UvtW%2FpSuNVgXQUg9Ca3G11yDFkYw748AWVsgOFDBxQ%2BxZC4DGYaGkha%2BClyBEvyN4T78n9B5vpbJI1GP6AoQlnd0Anx87XQisyoMLNYadyOqTWmNA9xOPCdUF0IgL1uixnqQG1%2BfhP13421TxyDKrtcpKj0UQ%2B9RYkdBtiddppCw513kLMdXbswLGZGxslxlCXTis%2B20VNstlJcNhcAukbEFYzK4GrDSnE5z9qDnJ6%2BI8ynJQ5E5fgi%2FVQvDQKODQg8DNQEL4c0G6f8HfwVdo3rJCRFEIvawVKqeOF";
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] data = encoding.GetBytes(requestParams);

            //setup the request
            HttpWebRequest httpRequest = (HttpWebRequest) WebRequest.Create(url);
            httpRequest.Host = "developer.mozu.com";
            httpRequest.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            httpRequest.Headers.Add("Origin", "https://www.mozu.com");
            httpRequest.Headers.Add("Cache-Control", "max-age=0");
            httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.65 Safari/537.36";
            httpRequest.Referer = "https://www.mozu.com/login/to?scopetype=developer&/?redirecturl=/home";
            //_httpRequest.Headers.Add("Accept-Encoding", "gzip, deflate");
            httpRequest.Headers.Add("Accept-Language", "en-US,en;q=0.8");
            Uri target = new Uri("http://developer.mozu.com/");
            CookieContainer cookies = new CookieContainer();
            Cookie cookie1 = new Cookie("has_js", "1") { Domain = target.Host };
            Cookie cookie2 = new Cookie("optimizelySegments", "%7B%22400030121%22%3A%22gc%22%2C%22401210090%22%3A%22direct%22%2C%22401990081%22%3A%22false%22%7D") { Domain = target.Host };
            Cookie cookie3 = new Cookie("optimizelyEndUserId", "oeu1432731701161r0.2258823139127344") { Domain = target.Host };
            Cookie cookie4 = new Cookie("optimizelyBuckets", "%7B%7D") { Domain = target.Host };
            Cookie cookie5 = new Cookie("_ga", "GA1.2.1790374536.1432731701") { Domain = target.Host };
            Cookie cookie6 = new Cookie("_gat", "1") { Domain = target.Host };
            Cookie cookie7 = new Cookie("_mkto_trk", "id:702-MYH-396&token:_mch-mozu.com-1432731702168-33647") { Domain = target.Host };
            Cookie cookie8 = new Cookie("mzrt-prod", "Token=788e1617a70e48dfb1a5dab41217c8ad&Expiration=635684149161640000&User=JZPwlFO2EMplF5BG0RYpQtv4GJwYyYZnvDc1GfBOLHwcquLmFC4/PORHrI3CevccxRNLJdEDdrhtSXIY0BDnOPxsWGzj2DavuG0T1yKZlWnjXwKoaliYHg598TVbDn2SjYHz7fAjsIXMQI6JhlP4ojL5QU3Eft385KlHuZ7FdjQ=") { Domain = target.Host };
            cookies.Add(cookie1);
            cookies.Add(cookie2);
            cookies.Add(cookie3);
            cookies.Add(cookie4);
            cookies.Add(cookie5);
            cookies.Add(cookie6);
            cookies.Add(cookie7);
            cookies.Add(cookie8);
            httpRequest.CookieContainer = cookies;
            httpRequest.Method        = "POST";
            httpRequest.ContentType   = "application/x-www-form-urlencoded";
            httpRequest.ContentLength = data.Length;
            //_httpRequest.Credentials = CredentialCache.DefaultNetworkCredentials;

            //custom headers...
            httpRequest.KeepAlive = true;
            httpRequest.Date = DateTime.Now;
            //_httpRequest.Headers.Add("Cache-Control", "no-cache");
            //_httpRequest.Headers.Add("Connection", "Keep-Alive");

            httpRequest.AllowAutoRedirect = false;//don't follow 302 response

            //write the post data
            using (Stream stream = httpRequest.GetRequestStream()) {
               stream.Write(data,0,data.Length);
            }

            //process the response
            using (HttpWebResponse httpResponse = httpRequest.GetResponse() as HttpWebResponse) {
                using (Stream stream = httpResponse.GetResponseStream()) {
                    StreamReader reader = new StreamReader(stream);
                    string response = reader.ReadToEnd();
                }

                /** save cookies */
                foreach (Cookie cookie in httpResponse.Cookies) {
                    _httpRequest.CookieContainer.Add(cookie);
                }
            }//using HttpWebResponse
        }


        private void downloadProducts()
        {
            Product products = new Product();
            ProductCollection results = (ProductCollection) MZ.Request(products, typeof(ProductCollection));
            if (results.Items != null) {
                foreach (Product product in results.Items) {
                    //Warehouse.Warwick.Inventory item = new Warehouse.Warwick.Inventory();
                    //item.inventory.system = _system;
                    Warehouse.Inventory item = new Warehouse.Inventory();
                    item.SKU = product.ProductCode;
                    item.UPC = product.Upc;
                    item.Price = (double) product.Price.Price;
                    item.Save();
                }
            }
        }


        private void downloadCustomers()
        {
            CustomerAccount customers = new CustomerAccount();
            CustomerAccountCollection results = (CustomerAccountCollection) MZ.Request(customers, typeof(CustomerAccountCollection));
            if (results.Items != null) {
                foreach (CustomerAccount customer in results.Items) {
                    //Warehouse.Warwick.Customer c = new Warehouse.Warwick.Customer();
                    Warehouse.Customer c = new Warehouse.Customer();
                    //c.customer.system = _system;
                    c.FirstName = c.FirstName;
                    c.MiddleName = c.MiddleName;
                    c.LastName = c.LastName;
                    c.Address1 = c.Address1;
                    c.Address2 = c.Address2;
                    c.City = c.City;
                    c.State = c.State;
                    c.ZipCode = c.ZipCode;
                    c.Country = c.Country;
                    c.Phone = c.Phone;
                    c.PhoneExtension = c.PhoneExtension;
                    c.Email = c.Email;
                    c.Fax = c.Fax;
                    c.Save();
                }
            }
        }


        private void downloadOrders()
        {
            Order orders = new Order();
            OrderCollection results = (OrderCollection) MZ.Request(orders, typeof(OrderCollection));
            if (results.Items != null) {
                foreach (Order o in results.Items) {
                    //Warehouse.Warwick.Order order = new Warehouse.Warwick.Order();
                    Warehouse.Order order = new Warehouse.Order();
                    //order.order.system = _system;
                    order.OrderNumber = o.OrderNumber.ToString();
                    order.OrderDate = Utility.getDateTime(o.SubmittedDate);
                    //order.BillTo = new Warehouse.Warwick.Customer {
                    order.BillTo = new Warehouse.Customer {
                        FirstName = o.BillingInfo.BillingContact.FirstName,
                        LastName = o.BillingInfo.BillingContact.LastNameOrSurname,
                        Address1 = o.BillingInfo.BillingContact.Address.Address1,
                        Address2 = o.BillingInfo.BillingContact.Address.Address2,
                        City = o.BillingInfo.BillingContact.Address.CityOrTown,
                        State = o.BillingInfo.BillingContact.Address.StateOrProvince,
                        ZipCode = o.BillingInfo.BillingContact.Address.PostalOrZipCode,
                        Country = o.BillingInfo.BillingContact.Address.CountryCode,
                        Phone = o.BillingInfo.BillingContact.PhoneNumbers.Home,
                        Email = o.BillingInfo.BillingContact.Email,
                    };
                    /*order.ShipTo = new Warehouse.Warwick.Customer {
                        FirstName = o.Shipments[0].DestinationAddress.FirstName,
                        LastName = o.Shipments[0].DestinationAddress.LastNameOrSurname,
                        Address1 = o.Shipments[0].DestinationAddress.Address.Address1,
                        Address2 = o.Shipments[0].DestinationAddress.Address.Address2,
                        City = o.Shipments[0].DestinationAddress.Address.CityOrTown,
                        State = o.Shipments[0].DestinationAddress.Address.StateOrProvince,
                        ZipCode = o.Shipments[0].DestinationAddress.Address.PostalOrZipCode,
                        Country = o.Shipments[0].DestinationAddress.Address.CountryCode,
                        Phone = o.Shipments[0].DestinationAddress.PhoneNumbers.Home,
                        Email = o.Shipments[0].DestinationAddress.Email,
                    };*/
                    order.Save();
                }
            }
        }


        private void uploadProducts()
        {
        //    Warehouse.Warwick.Inventory items = new Warehouse.Warwick.Inventory();
        //    items.inventory.system = _system;
        //    string sql = "select * from inventory where system = " + _system;
        //    using (Database.Result result = Database.Warwick.Query(sql)) {
        //        foreach (Database.Row row in result) {
        //            Warehouse.Warwick.Inventory item = new Warehouse.Warwick.Inventory();
        //            item.ID = row["id"].ToString();
        //            item.Read();

        //            Product product = new Product();
        //            product.ProductCode = item.SKU;
        //            product.Upc = item.UPC;
        //            product.Price = new ProductPrice();
        //            product.Price.Price = (decimal) item.Price;
        //            MZ.Request(product, null, true);
        //        }
        //    }
        }


        private void uploadCustomers()
        {
        //    Warehouse.Warwick.Customer customers = new Warehouse.Warwick.Customer();
        //    customers.customer.system = _system;
        //    string sql = "select * from customers where system = " + _system;
        //    using (Database.Result result = Database.Warwick.Query(sql)) {
        //        foreach (Database.Row row in result) {
        //            Warehouse.Warwick.Customer c = new Warehouse.Warwick.Customer();
        //            c.ID = row["id"].ToString();
        //            c.Read();

        //            CustomerAccount customer = new CustomerAccount();
        //            customer.FirstName = c.FirstName;
        //            customer.LastName = c.LastName;
        //            CustomerContact contact = new CustomerContact();
        //            global::Mozu.Api.Contracts.Core.Address address = new global::Mozu.Api.Contracts.Core.Address();
        //            address.Address1 = c.Address1;
        //            address.Address2 = c.Address2;
        //            address.Address3 = c.Address3;
        //            address.CityOrTown = c.City;
        //            address.StateOrProvince = c.State;
        //            address.PostalOrZipCode = c.ZipCode;
        //            address.CountryCode = c.Country;
        //            contact.PhoneNumbers = new global::Mozu.Api.Contracts.Core.Phone();
        //            contact.PhoneNumbers.Home = c.Phone;
        //            contact.PhoneNumbers.Mobile = c.Phone2;

        //            customer.EmailAddress = c.Email;
        //            contact.FaxNumber = c.Fax;
        //            contact.Address = address;
        //            customer.Contacts.Add(contact);
        //            MZ.Request(customer, null, true);
        //        }
        //    }
        }


        private void uploadOrders()
        {
        //    Warehouse.Warwick.Order orders = new Warehouse.Warwick.Order();
        //    orders.order.system = _system;
        //    string sql = "select * from orders where system = " + _system;
        //    using (Database.Result result = Database.Warwick.Query(sql)) {
        //        foreach (Database.Row row in result) {
        //            Warehouse.Warwick.Order o = new Warehouse.Warwick.Order();
        //            o.ID = row["id"].ToString();
        //            o.Read();

        //            Order order = new Order();
        //            order.OrderNumber = Utility.getInt(o.OrderNumber);
        //            order.SubmittedDate = o.OrderDate;
        //            order.Subtotal = (decimal) o.Price.SubTotal;
        //            order.TaxTotal = (decimal) o.Price.Tax;
        //            order.DiscountedTotal = (decimal) o.Price.Discount;
        //            order.ShippingTotal = (decimal) o.Price.ShippingCost;
        //            order.Total = (decimal) o.Price.Total;
        //            global::Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment shipment = new global::Mozu.Api.Contracts.CommerceRuntime.Fulfillment.Shipment();
        //            global::Mozu.Api.Contracts.Core.Contact contact = new global::Mozu.Api.Contracts.Core.Contact();
        //            global::Mozu.Api.Contracts.Core.Address address = new global::Mozu.Api.Contracts.Core.Address();
        //            address.Address1 = o.ShipTo.Address1;
        //            address.Address2 = o.ShipTo.Address2;
        //            address.Address3 = o.ShipTo.Address3;
        //            address.CityOrTown = o.ShipTo.City;
        //            address.StateOrProvince = o.ShipTo.State;
        //            address.PostalOrZipCode = o.ShipTo.ZipCode;
        //            address.CountryCode = o.ShipTo.Country;
        //            contact.PhoneNumbers = new global::Mozu.Api.Contracts.Core.Phone();
        //            contact.PhoneNumbers.Home = o.ShipTo.Phone;
        //            contact.PhoneNumbers.Mobile = o.ShipTo.Phone2;
        //            contact.Address = address;
        //            shipment.DestinationAddress = contact;
        //            order.Shipments.Add(shipment);
        //            MZ.Request(order, null, true);
        //        }
        //    }
        }

    }
}
