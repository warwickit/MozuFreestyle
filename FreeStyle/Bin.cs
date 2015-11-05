using System;
using System.Runtime.Serialization;

namespace FreeStyle
{
    [DataContract]
    public class Bin
    {
        [DataMember(Order=1)] public string ProductID;
        [DataMember(Order=2)] public string BinID;
        [DataMember(Order=3)] public string Priority;
        [DataMember(Order=4)] public string BinType;
        [DataMember(Order=5)] public string BinName;
        [DataMember(Order=6)] public decimal TotalQuantity;
        [DataMember(Order=7)] public decimal AvailableQuantity;
        [DataMember(Order=8)] public decimal ComittedQuantity;
        [DataMember(Order=9)] public decimal ReturnedQuantity;
        [DataMember(Order=10)] public string WarehouseID;
        [DataMember(Order=11)] public string WarehouseName;
    }
}
