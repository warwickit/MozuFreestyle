using System;
using System.Runtime.Serialization;

namespace FreeStyle
{
    [DataContract]
    public class Item
    {
        [DataMember(Order=1)] public string ProductSKU;
        [DataMember(Order=2)] public decimal Quantity;
        [DataMember(Order=3)] public decimal Price;
        [DataMember(Order=4)] public decimal Discount;
    }
}
