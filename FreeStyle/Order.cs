using System;
using System.Runtime.Serialization;

namespace FreeStyle
{
    [DataContract]
    public class Order : FreeStyle
    {
        [DataMember(Name="id", Order=1)] public new string ID { get; set; }
        [DataMember(Order=2)] public string OrderNumber { get; set; }
        [DataMember(Order=3)] public string OrderDate { get; set; }
        [DataMember(Order=4)] public string ShippingMethod { get; set; }
        [DataMember(Order=5)] public Address BillingAddress { get; set; }
        [DataMember(Order=6)] public Address ShippingAddress { get; set; }
        [DataMember(Order=7)] public string UpdateAt { get; set; }
        [DataMember(Order=8)] public string OrderStatus { get; set; }
        [DataMember(Order=9)] public decimal TotalAmount { get; set; }
        [DataMember(Order=10)] public decimal PaidAmount { get; set; }
        [DataMember(Order=11)] public decimal ShippingAmount { get; set; }
        [DataMember(Order=12)] public decimal TaxAmount { get; set; }
        [DataMember(Order=13)] public Item[] OrderItems { get; set; }
        [DataMember(Order=14)] public string HandlingInstructions { get; set; }
        [DataMember(Order=15)] public string SpecialInstructions { get; set; }
        [DataMember(Order=16)] public string PromotionCode { get; set; }
        [DataMember(Order=17)] public string SalesChannelId { get; set; }
        [DataMember(Order=18)] public string[] Shipments { get; set; }
        [DataMember(Order=19)] public string[] Dropships { get; set; }

        [IgnoreDataMember] public string MinID;
        [IgnoreDataMember] public string MaxID;


        public Order()
        {
            _type = "Orders";
        }


        public bool Exists()
        {
            if (string.IsNullOrWhiteSpace(this.OrderNumber)) throw new InvalidProgramException("Must specify order number in Order.Exists()");
            Order order = new Order();
            order.OrderNumber = this.OrderNumber;
            Order[] orders = (Order[]) order.Read<Order[]>();
            if (orders.Length > 0 && ! string.IsNullOrWhiteSpace(orders[0].OrderNumber)) return true;
            else return false;
        }

        protected override string getFilter()
        {
            string filter = "";
            if (! string.IsNullOrWhiteSpace(this.OrderStatus)) filter += "&OrderStatus=" + this.OrderStatus;
            if (! string.IsNullOrWhiteSpace(this.MinID)) filter += "&ProductSKU=" + this.MinID;
            if (! string.IsNullOrWhiteSpace(this.MaxID)) filter += "&Status=" + this.MaxID;
            if (! string.IsNullOrWhiteSpace(this.SalesChannelId)) filter += "&SalesChannelID=" + this.SalesChannelId;

            if (filter.Length > 0) filter = filter.Substring(1);//remove ampersand at the beginning
            return filter;
        }
    }
}
