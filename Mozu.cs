using System;
using Mozu.Api.Contracts.Customer;
using Mozu.Api.Contracts.ProductAdmin;
using Mozu.Api.Contracts.CommerceRuntime.Orders;
using Utilities.Network;
using Utilities.Contract;

namespace Mozu
{
    public static class Mozu
    {
        private static Authentication _auth;
        private static Utilities.Settings _settings = new Utilities.Settings();
        private  static string _apiUrl  { get { return Mozu.Settings["apiurl"]; } }
        //protected object _response;
        public static string Username;
        public static string Password;


        public static Utilities.Settings Settings { get { return _settings; } }


        public static object Request(object request, Type responseType=null, bool post=false)
        {
            /** determine the api method to call */
            string method = Mozu.getMethod(request);
            if (responseType == null) responseType = request.GetType();

            /** make sure we have a valid authentication ticket */
            if (_auth == null && request.GetType() != typeof(AuthenticationContract)) Mozu.authenticate();
        
            string url = string.Format("{0}{1}", _apiUrl, method);
            Type t = request.GetType();
            bool get = false;
            if (! post && (t == typeof(CustomerAccount) || t == typeof(Product) || t == typeof(Order))) {
                url = "https://t7949.sandbox.mozu.com";
                get = true;
            }
            else if (post && (t == typeof(CustomerAccount) || t == typeof(Product) || t == typeof(Order))) {
                url = "https://t7949.sandbox.mozu.com/api/platform";
            }
            //HTTP http = new HTTP();
            Console.WriteLine("Calling Mozu API: " + url);
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient { BaseAddress = new Uri(url) };
            //if (request.GetType() != typeof(AuthenticationContract)) http.AddHeader("x-vol-app-claims", _auth.Ticket.AccessToken);
            if (t != typeof(AuthenticationContract)) {
                client.DefaultRequestHeaders.Add("x-vol-app-claims", _auth.Ticket.AccessToken);
                client.DefaultRequestHeaders.Add("x-vol-tenant", "7949");//the sandbox number
                if (t == typeof(Product)) {
                    client.DefaultRequestHeaders.Add("x-vol-master-catalog", "2");
                }
                //client.DefaultRequestHeaders.Add("x-vol-catalog", "1");
                //client.DefaultRequestHeaders.Add("x-vol-version", "1.9.14232.3");
            }
        
            string json = JSON.Serialize(request);
            
            //string response = http.POSTRaw(url, json, "application/json");
        
            string response = null;
            if (get) {
                method = "/api" + method;
                if (t == typeof(Product)) method += "?startindex=0&pagesize=200";
                var r = client.GetAsync(method).Result;
                response = r.Content.ReadAsStringAsync().Result;
            }
            else {
                var r = client.PostAsync("/api" + method, new System.Net.Http.StringContent(json, System.Text.Encoding.UTF8, "application/json")).Result;
                response = r.Content.ReadAsStringAsync().Result;
            }
        
            object o = JSON.Deserialize(response, responseType);
            return o;
        }


        private static void authenticate()
        {
            _auth = new Authentication();
            _auth.Authenticate();
        }


        private static string getMethod(object data)
        {
            if (data == null) throw new InvalidOperationException("Null data parameter in getMethod()");
            Type type = data.GetType();
            if (type == typeof(AuthenticationContract)) return "/platform/applications/authtickets/";
            else if (type == typeof(TenantContract)) {
            //var client = new System.Net.Http.HttpClient { BaseAddress = new Uri("https://home.mozu.com") };
            //client.DefaultRequestHeaders.Add("x-vol-app-claims", _auth.Ticket.AccessToken);
            //var stringContent = "{\"EmailAddress\":\"wayne.bryan@warwickfulfillment.com\",\"Password\":\"blehblehbleh\"}";
            //var response = client.PostAsync("/api/platform/adminuser/authtickets/tenants", new System.Net.Http.StringContent(stringContent, System.Text.Encoding.UTF8, "application/json")).Result;
                return "/platform/adminuser/authtickets/tenants";
            }
            else if (type == typeof(Product)) {
                return "/commerce/catalog/admin/products/";
            }
            else if (type == typeof(CustomerAccount)) {
                return "/commerce/customer/accounts/";
            }
            else if (type == typeof(Order)) {
                return "/commerce/orders/";
            }
            else throw new InvalidCastException("Unknown Mozu Type: " + data.GetType().FullName);
        }

    }
}
