using System;
using Utilities.Crypto;
using Utilities.Network;
using Utilities.Contract;

namespace FreeStyle
{
    [Serializable]
    public abstract class FreeStyle : Warehouse.ICRUD
    {
        [NonSerialized()] private HTTP _http;
        //[NonSerialized()] private const string _url = "https://www.freestylecommerce.info/webapi/V1/";
        [NonSerialized()] private const string _url = "https://staging.freestylecommerce.com/webapi/V1/";
        //[NonSerialized()] private const string _user = "api@warwickfulfillment.com";
        //[NonSerialized()] private const string _password = "155120091130232053139086053071149030245122030175";
        [NonSerialized()] protected string _type;
        [NonSerialized()] public string ID;// { get; set; }
        [NonSerialized()] public int Page;
        [NonSerialized()] public int Limit;
        [NonSerialized()] public string Filter;
        [NonSerialized()] public static string Username;
        [NonSerialized()] public static string Password;

        public FreeStyle()
        {
            if (string.IsNullOrWhiteSpace(Username)) Username = Utilities.Settings.get("username");
            if (string.IsNullOrWhiteSpace(Password)) Password = Utilities.Settings.get("password");
            if (Password.Length < 30) {
                AES aes = new AES();
                Password = aes.Encrypt(Password);
            }

            _http = new HTTP {
                User = Username,
                Password = new AES(Password)
            };
            _http.Content = HTTP.ContentType.JSON;
        }


        protected abstract string getFilter();


        public virtual bool Create()
        {
            string url = _url + _type;

            string json = JSON.Serialize(this);
            json = json.Replace("\"id\":null,", "");//remove id field
            json = json.Replace("\"CustomerNumber\":null,", "");
            json = json.Replace("\"ProductGuid\":\"00000000-0000-0000-0000-000000000000\",", "");
            json = json.Replace(",\"VolumeUnit\":null,\"Comments\":null,\"ImageURL\":null,\"ImageThumbnailURL\":null,\"HasAttributedProduct\":null,\"IsGiftMessageProduct\":null,\"CreateTime\":null,\"UpdateTime\":null,\"AvailableQuantity\":0,\"ComittedQuantity\":0,\"BackorderedQuantity\":0,\"ReturnedQuantity\":0,\"OnOrderQuantity\":null,\"PreAssembledQuantity\":0,\"InventoryLowLevel\":0,\"ProductType\":null,\"KitStaysTogetherUponReturn\":null,\"EanCode\":null,\"BarCode\":null,\"Bins\":null,\"Suppliers\":null", "");
            json = json.Replace(",\"Status\":null", "");
            json = json.Replace(",\"ComittedQuantity\":0,\"BackorderedQuantity\":0,\"ReturnedQuantity\":0,\"OnOrderQuantity\":null,\"PreAssembledQuantity\":0,\"InventoryLowLevel\":0,\"ProductType\":null,\"KitStaysTogetherUponReturn\":null,\"EanCode\":null,\"BarCode\":null,\"Bins\":null,\"Suppliers\":null", "");
            json = json.Replace("\"Comments\":null,\"ImageURL\":null,\"ImageThumbnailURL\":null,\"HasAttributedProduct\":null,\"IsGiftMessageProduct\":null,\"CreateTime\":null,\"UpdateTime\":null,", "");
            json = json.Replace("\"Isbn\":null,\"UpcCode\":\"\",", "");
            json = json.Replace("\"Isbn\":null,", "");
            json = json.Replace("\"ShortDescription\":null,", "");
            json = json.Replace("\"UpcCode\":null,", "");
            //json = "{\"ProductName\": \"Baldwin PF7777 Fuel Filter\",\"ShortDescription\":\"PF7778 FuelWater Separator Element Fits : Chrysler, Bering, Ford, Freightliner, Kenworth, Peterbilt Trucks; Cummins ISB Engines; Cummins 5.9 Liter Turbo Diesel 2000 - June 2002 Replaces : Chrysler 5015581AA; Cummins 3942470; Fleetguard FS19579\",\"RetailPrice\": \"17.02\",\"AvailableQuantity\": 6,\"Length\":\"0.00\",\"Width\":\"0.00\",\"Height\":\"0.00\",\"VolumeUnit\":\"in\",\"Weight\": 0.5,\"WeightUnit\":\"lbs\",\"ProductSku\": \"PF7780\"}";
            //json = "{\"ProductName\":\"Womens Mackie MID-SMI 27\",\"ProductSKU\":\"243790\",\"ShortDescription\":\"W145SNF27\",\"RetailPrice\":\"17.02\",\"AvailableQuantity\": 6,\"Length\":\"0.00\",\"Width\":\"0.00\",\"Height\":\"0.00\",\"VolumeUnit\":\"in\",\"Weight\": 0.5,\"WeightUnit\":\"lbs\"}";
            
            if (_type == "Orders") { 
                Order o = (Order) this;
                json = string.Format(@"{{
                    ""OrderNumber"":""{0}"",
                    ""OrderDate"":""{1}"",
                    ""ShippingMethod"":""{2}"",
                    ""BillingAddress"":{{
                                ""FirstName"":""{3}"",
                                ""LastName"":""{4}"",
                                ""Company"":""{5}"",
                                ""AddressLine1"":""{6}"",
                                ""AddressLine2"":""{7}"",
                                ""City"":""{8}"",
                                ""State"":""{9}"",
                                ""Postcode"":""{10}"",
                                ""Country"":""{11}"",
                                ""Email"":""{12}"",
                                ""Phone"":""{13}""
                    }},
                    ""ShippingAddress"":{{
                                ""FirstName"":""{14}"",
                                ""LastName"":""{15}"",
                                ""Company"":""{16}"",
                                ""AddressLine1"":""{17}"",
                                ""AddressLine2"":""{18}"",  
                                ""City"":""{19}"",
                                ""State"":""{20}"",
                                ""Postcode"":""{21}"",
                                ""Country"":""{22}"",
                                ""Email"":""{23}"",
                                ""Phone"":""{24}""
                    }},
                    ""UpdateAt"":""{25}"",
                    ""OrderStatus"":""New"",
                    ""TotalAmount"":{26},
                    ""PaidAmount"":{27},
                    ""ShippingAmount"":{28},
                    ""TaxAmount"":{29},
                    ""OrderItems"":{30},
                    ""SalesChannelId"":""{31}""
                }}", o.OrderNumber, o.OrderDate, o.ShippingMethod,
                    o.BillingAddress.FirstName, o.BillingAddress.LastName, o.BillingAddress.Company, o.BillingAddress.AddressLine1, o.BillingAddress.AddressLine2, o.BillingAddress.City, o.BillingAddress.State, o.BillingAddress.Postcode, o.BillingAddress.Country, o.BillingAddress.Email, o.BillingAddress.Phone,
                    o.ShippingAddress.FirstName, o.ShippingAddress.LastName, o.ShippingAddress.Company, o.ShippingAddress.AddressLine1, o.ShippingAddress.AddressLine2, o.ShippingAddress.City, o.ShippingAddress.State, o.ShippingAddress.Postcode, o.ShippingAddress.Country, o.ShippingAddress.Email, o.ShippingAddress.Phone,
                    DateTime.Now.ToString(), o.TotalAmount, o.PaidAmount, o.ShippingAmount, o.TaxAmount, JSON.Serialize(o.OrderItems), o.SalesChannelId);
                /*json = @"{
                    ""OrderNumber"":""1123489"",
                    ""OrderDate"":""11/20/2014 5:06:39 AM"",
                    ""ShippingMethod"":""2-Day Domestic"",
                    ""BillingAddress"":{
                                ""FirstName"":""Mary"",
                                ""LastName"":""Jane"",
                                ""Company"":"""",
                                ""AddressLine1"":""9 Hispalis Rd"",
                                ""AddressLine2"":"""",
                                ""City"":""Andover"",
                                ""State"":""MA"",
                                ""Postcode"":""01810"",
                                ""Country"":""US"",
                                ""Email"":""Joe@Test.com"",
                                ""Phone"":""9785553902""
                    },
                    ""ShippingAddress"":{
                                ""FirstName"":""Mary"",
                                ""LastName"":""Jane"",
                                ""Company"":"""",
                                ""AddressLine1"":""9 Hispalis Rd"",
                                ""AddressLine2"":"""",  
                                ""City"":""Andover"",
                                ""State"":""MA"",
                                ""Postcode"":""01810"",
                                ""Country"":""US"",
                                ""Email"":""Joe@Test.com"",
                                ""Phone"":""9785553902""
                    },
                    ""UpdateAt"":""11/20/2014 5:06:39 AM"",
                    ""OrderStatus"":""New"",
                    ""TotalAmount"":22.70,
                    ""PaidAmount"":0.0,
                    ""ShippingAmount"":6.95,
                    ""TaxAmount"":0.00,
                    ""OrderItems"":[{
                                ""ProductSKU"":""test"",
                                ""Quantity"":""1.00"",
                                ""Price"":""15.75"",
                                ""Discount"":""0.00""
                    }],
                    ""SalesChannelId"":""fa0970f9-1684-4456-bca1-a45a00d945a0""
                }";*/
            }

            /** customer test */
            if (_type == "Customers") {
                /*json = @"{
	                ""LastName"": ""TestPost4"",
	                ""MiddleName"": null,
	                ""FirstName"": ""John"",
	                ""Salutation"": """",
	                ""Title"": """",
	                ""Email"": ""testpost48@channelbrain.com"",
	                ""Phone"": ""603-111-1111"",
	                ""PhoneExtension"": """",
	                ""Fax"": """",
	                ""Priority"": 1,
	                ""Status"": 0,
	                ""AddressLine1"": ""9L Rocco Drive"",
	                ""CustomerAddress"": null,
	                ""RegionName"": ""New Hampshire"",
	                ""ZipCode"": ""03038"",
	                ""Company"": """",
	                ""CountryName"": ""United States"",
	                ""CityName"": ""Derry"",
                    ""BillingAddress"":{
                                ""FirstName"":""Mary"",
                                ""LastName"":""Jane"",
                                ""Company"":"""",
                                ""AddressLine1"":""9 Hispalis Rd"",
                                ""AddressLine2"":"""",
                                ""City"":""Andover"",
                                ""State"":""MA"",
                                ""Postcode"":""01810"",
                                ""Country"":""US"",
                                ""Email"":""MaryJane@gmail.com"",
                                ""Phone"":""9785553902""
                    }
                }";*/
            }


            string output = _http.POSTRaw(url, json, "application/json");

            return true;
        }


        public object Read<T>()
        {
            /** determine the url */
            string url = _url + _type;
            if (! string.IsNullOrWhiteSpace(this.ID)) url += "/" + this.ID;
            else {
                string filter = this.getFilter();
                url += "?" + filter;
                if (this.Page > 0) url += "&page=" + this.Page;
                if (this.Limit > 0) url += "&limit=" + this.Limit;
            }
            url = url.Replace("?&", "?");

            /** make the call */
            Console.WriteLine("Calling FreeStyle API: " + url);
            string json = _http.GET(url);
            json = json.Replace(@"""TotalQuantity"":"""",", @"""TotalQuantity"": ""0"",");
            T results = (T) JSON.Deserialize(json, typeof(T));

            return results;
        }


        public bool Update()
        {
            string url = _url + _type + "/" + this.ID;
            string json = JSON.Serialize(this);
            _http.PUT(url, json, "application/json");

            return true;
        }


        public bool Delete()
        {
            string url = _url + _type + "/" + this.ID;
            string json = JSON.Serialize(this);
            _http.DELETE(url, json, "application/json");

            return true;
        }

    }
}
