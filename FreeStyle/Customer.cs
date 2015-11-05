using System;
using System.Runtime.Serialization;

namespace FreeStyle
{
    [DataContract]
    public class Customer : FreeStyle
    {
        [DataMember(Name="id", Order=1)] public new string ID { get; set; }
        [DataMember(Order=2)] public string LastName;
        [DataMember(Order=3)] public string MiddleName;
        [DataMember(Order=4)] public string FirstName;
        [DataMember(Order=5)] public string Salutation;
        [DataMember(Order=6)] public string Title;
        [DataMember(Order=7)] public string CustomerNumber;
        [DataMember(Order=8)] public string Company;
        [DataMember(Order=9)] public string AddressLine1;
        [DataMember(Order=10)] public string AddressLine2;
        [DataMember(Order=11)] public string CityName;
        [DataMember(Order=12)] public string RegionName;
        [DataMember(Order=13)] public string Postcode;
        [DataMember(Order=14)] public string CountryName;
        [DataMember(Order=15)] public string Email;
        [DataMember(Order=16)] public string Phone;
        [DataMember(Order=17)] public string PhoneExtension;
        [DataMember(Order=18)] public string Fax;
        [DataMember(Order=19)] public int Priority;
        [DataMember(Order=20)] public int Status;
        [DataMember(Order=21)] public string Fraud;
        [DataMember(Order=22)] public string ChannelID;


        public Customer() : base()
        {
            _type = "Customers";
        }
        public Customer(Warehouse.Customer customer) : base()
        {
            _type = "Customers";
            this.FirstName = customer.FirstName;
            this.LastName = customer.LastName;
            this.AddressLine1 = customer.Address1;
            this.AddressLine2 = customer.Address2;
            this.CityName = customer.City;
            this.RegionName = customer.State;
            this.Postcode = customer.ZipCode;
            this.Email = customer.Email;
            this.Phone = customer.Phone;
        }


        public override bool Create()
        {
            if (this.Salutation == null) this.Salutation = "";
            if (this.Title == null) this.Title = "";
            if (this.Company == null) this.Company = "";
            if (this.CountryName == null) this.CountryName = "United States";
            if (this.Fraud == null) this.Fraud = "";
            if (this.PhoneExtension == null) this.PhoneExtension = "";
            if (this.Fax == null) this.Fax = "";

            return base.Create();
        }


        public bool Exists()
        {
            if (string.IsNullOrWhiteSpace(this.FirstName)) throw new InvalidProgramException("Must specify name in Customer.Exists()");
            Customer customer = new Customer();
            customer.FirstName = this.FirstName;
            customer.LastName = this.LastName;
            customer.AddressLine1 = this.AddressLine1;
            customer.AddressLine1 = this.AddressLine2;
            customer.CityName = this.CityName;
            customer.RegionName = this.RegionName;
            customer.Postcode = this.Postcode;
            Customer[] customers = (Customer[]) customer.Read<Customer[]>();
            if (customers.Length > 0 && ! string.IsNullOrWhiteSpace(customers[0].FirstName)) return true;
            else return false;
        }


        protected override string getFilter()
        {
            string filter = "";
            if (! string.IsNullOrWhiteSpace(this.CustomerNumber)) filter += "&CustomerNumber=" + this.CustomerNumber;
            if (! string.IsNullOrWhiteSpace(this.FirstName)) filter += "&FirstName=" + this.FirstName;
            if (! string.IsNullOrWhiteSpace(this.LastName)) filter += "&LastName=" + this.LastName;
            if (! string.IsNullOrWhiteSpace(this.Company)) filter += "&Company=" + this.Company;
            if (! string.IsNullOrWhiteSpace(this.AddressLine1)) filter += "&AddressLine1=" + this.AddressLine1;
            if (! string.IsNullOrWhiteSpace(this.AddressLine2)) filter += "&AddressLine2=" + this.AddressLine2;
            if (! string.IsNullOrWhiteSpace(this.CityName)) filter += "&City=" + this.CityName;
            if (! string.IsNullOrWhiteSpace(this.RegionName)) filter += "&State=" + this.RegionName;
            if (! string.IsNullOrWhiteSpace(this.Postcode)) filter += "&Postcode=" + this.Postcode;
            if (! string.IsNullOrWhiteSpace(this.CountryName)) filter += "&Country=" + this.CountryName;
            if (! string.IsNullOrWhiteSpace(this.Email)) filter += "&Email=" + this.Email;
            if (! string.IsNullOrWhiteSpace(this.Phone)) filter += "&Phone=" + this.Phone;
            if (this.Status > 0) filter += "&Status=" + this.Status;
            if (! string.IsNullOrWhiteSpace(this.Fraud)) filter += "&Fraud=" + this.Fraud;
            if (! string.IsNullOrWhiteSpace(this.ChannelID)) filter += "&ChannelID=" + this.ChannelID;

            if (filter.Length > 0) filter = filter.Substring(1);//remove ampersand at the beginning
            return filter;
        }
    }
}
