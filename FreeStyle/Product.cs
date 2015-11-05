using System;
using System.Runtime.Serialization;

namespace FreeStyle
{
    [DataContract]
    public class Product : FreeStyle
    {
        [DataMember(Name="id", Order=1)] public new string ID { get; set; }
        [DataMember(Order=2)] public Guid ProductGuid;
        [DataMember(Order=3)] public string ProductName;
        [DataMember(Order=4)] public string ProductSku;
        [DataMember(Order=5)] public string ShortDescription;
        [DataMember(Order=6)] public string LongDescription;
        [DataMember(Order=7)] public string Isbn;
        [DataMember(Order=8)] public string UpcCode;
        [DataMember(Order=9)] public string Status;
        [DataMember(Order=10)] public decimal RetailPrice;
        [DataMember(Order=11)] public decimal MaxAllowedDiscount;
        [DataMember(Order=12)] public decimal Weight;
        [DataMember(Order=13)] public string WeightUnit;
        [DataMember(Order=14)] public decimal Length;
        [DataMember(Order=15)] public decimal Width;
        [DataMember(Order=16)] public string VolumeUnit;
        [DataMember(Order=17)] public string Comments;
        [DataMember(Order=18)] public string ImageURL;
        [DataMember(Order=19)] public string ImageThumbnailURL;
        [DataMember(Order=20)] public string HasAttributedProduct;
        [DataMember(Order=21)] public string IsGiftMessageProduct;
        [DataMember(Order=22)] public string CreateTime;
        [DataMember(Order=23)] public string UpdateTime;
        [DataMember(Order=24)] public decimal AvailableQuantity;
        [DataMember(Order=25)] public decimal ComittedQuantity;
        [DataMember(Order=26)] public decimal? BackorderedQuantity;
        [DataMember(Order=27)] public decimal ReturnedQuantity;
        [DataMember(Order=28)] public string OnOrderQuantity;
        [DataMember(Order=29)] public decimal? PreAssembledQuantity;
        [DataMember(Order=30)] public decimal InventoryLowLevel;
        [DataMember(Order=31)] public string ProductType;
        [DataMember(Order=32)] public string KitStaysTogetherUponReturn;
        [DataMember(Order=33)] public string EanCode;
        [DataMember(Order=34)] public string BarCode;
        [DataMember(Order=35)] public Bin[] Bins;
        [DataMember(Order=36)] public Supplier[] Suppliers;

        [IgnoreDataMember] public DateTime MinDateModified;
        [IgnoreDataMember] public DateTime MaxDateModified;
        [IgnoreDataMember] public int MinQuantity;
        [IgnoreDataMember] public int MaxQuantity;
        [IgnoreDataMember] public decimal MinPrice;
        [IgnoreDataMember] public decimal MaxPrice;


        public Product() : base()
        {
            _type = "Products";
        }
        public Product(Warehouse.Inventory item) : base()
        {
            _type = "Products";
            this.ProductSku = item.SKU;
            this.UpcCode = item.UPC;
            this.ProductName = item.Description;
            this.LongDescription = item.Description;
            this.ShortDescription = item.Description2;
            this.RetailPrice = (decimal) item.Price;
        }


        protected override string getFilter()
        {
            string filter = "";
            if (! string.IsNullOrWhiteSpace(this.ProductName)) filter += "&ProductName=" + this.ProductName;
            if (! string.IsNullOrWhiteSpace(this.ProductSku)) filter += "&ProductSKU=" + this.ProductSku;
            if (! string.IsNullOrWhiteSpace(this.Status)) filter += "&Status=" + this.Status;
            if (! string.IsNullOrWhiteSpace(this.ShortDescription)) filter += "&ShortDescription=" + this.ShortDescription;
            if (! string.IsNullOrWhiteSpace(this.HasAttributedProduct)) filter += "&HasAttributedProduct=" + this.HasAttributedProduct;
            if (this.MinDateModified != new DateTime()) filter += "&min_date_modified=" + this.MinDateModified;
            if (this.MaxDateModified != new DateTime()) filter += "&max_date_modified=" + this.MaxDateModified;
            if (this.MinQuantity != 0) filter += "&min_quantity=" + this.MinQuantity;
            if (this.MaxQuantity != 0) filter += "&max_quantity=" + this.MaxQuantity;
            if (this.MinPrice != 0) filter += "&min_price=" + this.MaxPrice;
            if (this.MaxPrice != 0) filter += "&max_price=" + this.ProductName;
            if (! string.IsNullOrWhiteSpace(this.ProductType)) filter += "&ProductType=" + this.ProductType;

            if (filter.Length > 0) filter = filter.Substring(1);//remove ampersand at the beginning
            return filter;
        }


        public override bool Create()
        {
            if (this.WeightUnit == null) this.WeightUnit = "lbs";
            if (this.VolumeUnit == null) this.VolumeUnit = "in";
            return base.Create();
        }

        
        public bool Exists()
        {
            if (string.IsNullOrWhiteSpace(this.ProductSku)) throw new InvalidProgramException("Must specify sku in Product.Exists()");
            Product product = new Product();
            product.ProductSku = this.ProductSku;
            Product[] products = (Product[]) product.Read<Product[]>();
            if (products.Length > 0 && ! string.IsNullOrWhiteSpace(products[0].ProductSku)) return true;
            else return false;
        }
        

    }
}
