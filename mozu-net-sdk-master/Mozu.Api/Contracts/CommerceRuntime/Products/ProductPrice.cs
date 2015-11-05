
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;

namespace Mozu.Api.Contracts.CommerceRuntime.Products
{
		///
		///	The price of a product that appears on a storefront after any applied discounts.
		///
        [DataContract]
		public class ProductPrice
		{
            [DataMember(Name="msrp")]
			public decimal? Msrp { get; set; }

			///
			///The price the merchant charges for a product on a storefront if no sales price is defined.
			///
            [DataMember(Name="price")]
			public decimal? Price { get; set; }

			///
			///Current sale price defined for a product on a storefront.
			///
            [DataMember(Name="salePrice")]
			public decimal? SalePrice { get; set; }

            [DataMember(Name="tenantOverridePrice")]
			public decimal? TenantOverridePrice { get; set; }

		}

}