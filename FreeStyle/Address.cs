using System;
using System.Runtime.Serialization;

namespace FreeStyle
{
    [DataContract]
    public class Address
    {
        [DataMember(Order=1)] public string FirstName;
        [DataMember(Order=2)] public string LastName;
        [DataMember(Order=3)] public string Company;
        [DataMember(Order=4)] public string AddressLine1;
        [DataMember(Order=5)] public string AddressLine2;
        [DataMember(Order=6)] public string City;
        [DataMember(Order=7)] public string State;
        [DataMember(Order=8)] public string Postcode;
        [DataMember(Order=9)] public string Country;
        [DataMember(Order=10)] public string Email;
        [DataMember(Order=11)] public string Phone;
    }
}
