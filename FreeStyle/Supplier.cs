using System;
using System.Runtime.Serialization;

namespace FreeStyle
{
    [DataContract]
    public class Supplier
    {
        [DataMember(Order=1)] public string SupplierName;
    }
}
