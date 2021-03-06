
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Properties of the product such as product code, product name, and product price.
		///
        [DataContract]
		public class Product
		{
			///
			///Merchant-generated product code for the product that any variation stems from.
			///
            [DataMember(Name="baseProductCode")]
			public string BaseProductCode { get; set; }

            [DataMember(Name="fulfillmentTypesSupported")]
			public List<string> FulfillmentTypesSupported { get; set; }

			///
			///If true, the product has configurable options. This option means that a product is not purchasable until the shopper selects options that resolve into a product variation. Configurable options for a product are the choices a shopper makes when ordering a product. Size and color are configurable options. System-supplied and read-only.
			///
            [DataMember(Name="hasConfigurableOptions")]
			public bool HasConfigurableOptions { get; set; }

			///
			///If true, this product has stand alone options that a shopper can select which can exist without product variations. Stand alone options. System-supplied and read-only.
			///
            [DataMember(Name="hasStandAloneOptions")]
			public bool HasStandAloneOptions { get; set; }

			///
			///If true, the product must be packaged on its own and should not be jointly packaged with other products.
			///
            [DataMember(Name="isPackagedStandAlone")]
			public bool? IsPackagedStandAlone { get; set; }

			///
			///If true, the product can be purchased or fulfilled at regular intervals such as a monthly billing cycle or a digital or physical subscription. This property is reserved for future functionality and is system-supplied and read only.
			///
            [DataMember(Name="isRecurring")]
			public bool? IsRecurring { get; set; }

			///
			///If true, the entity is subject to tax based on the relevant tax rate.
			///
            [DataMember(Name="isTaxable")]
			public bool? IsTaxable { get; set; }

			///
			///If true, the entity is valid for the product type provided.
			///
            [DataMember(Name="isValidForProductType")]
			public bool? IsValidForProductType { get; set; }

			///
			///If true, the product in this request is a product variation of a product that has configurable options. System-supplied and read-only.
			///
            [DataMember(Name="isVariation")]
			public bool IsVariation { get; set; }

            [DataMember(Name="masterCatalogId")]
			public int? MasterCatalogId { get; set; }

			///
			///Merchant-created code that uniquely identifies the product such as a SKU or item number. Once created, the product code is read-only.
			///
            [DataMember(Name="productCode")]
			public string ProductCode { get; set; }

			///
			///Integer that represents the sequential order of the product.
			///
            [DataMember(Name="productSequence")]
			public int? ProductSequence { get; set; }

			///
			///Identifier of the product type.
			///
            [DataMember(Name="productTypeId")]
			public int? ProductTypeId { get; set; }

            [DataMember(Name="productUsage")]
			public string ProductUsage { get; set; }

			///
			///Identifier of the shipping class.
			///
            [DataMember(Name="shippingClassId")]
			public int? ShippingClassId { get; set; }

			///
			///If the product must be packaged separately, the type of standalone package to use.
			///
            [DataMember(Name="standAlonePackageType")]
			public string StandAlonePackageType { get; set; }

			///
			///The universal product code (UPC code) of the product.
			///
            [DataMember(Name="upc")]
			public string Upc { get; set; }

			///
			///System-generated key that represents the attribute values that uniquely identify a specific product variation.
			///
            [DataMember(Name="variationKey")]
			public string VariationKey { get; set; }

			///
			///List of discounts available for a product.
			///
            [DataMember(Name="applicableDiscounts")]
			public List<Discount> ApplicableDiscounts { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
            [DataMember(Name="auditInfo")]
			public AuditInfo AuditInfo { get; set; }

            [DataMember(Name="bundledProducts")]
			public List<BundledProduct> BundledProducts { get; set; }

			///
			///Product content set in product admin.
			///
            [DataMember(Name="content")]
			public ProductLocalizedContent Content { get; set; }

			///
			///The list of extras set up in product admin.
			///
            [DataMember(Name="extras")]
			public List<ProductExtra> Extras { get; set; }

			///
			///Properties of the inventory levels manages for the product.
			///
            [DataMember(Name="inventoryInfo")]
			public ProductInventoryInfo InventoryInfo { get; set; }

			///
			///The list of options set up in product admin.
			///
            [DataMember(Name="options")]
			public List<ProductOption> Options { get; set; }

			///
			///Height of the package in imperial units of feet and inches.
			///
            [DataMember(Name="packageHeight")]
			public Measurement PackageHeight { get; set; }

			///
			///Length of the package in imperial units of feet and inches.
			///
            [DataMember(Name="packageLength")]
			public Measurement PackageLength { get; set; }

			///
			///Weight of the package in imperial units of pounds and ounces.
			///
            [DataMember(Name="packageWeight")]
			public Measurement PackageWeight { get; set; }

			///
			///Width of the package in imperial units of feet and inches.
			///
            [DataMember(Name="packageWidth")]
			public Measurement PackageWidth { get; set; }

            [DataMember(Name="price")]
			public ProductPrice Price { get; set; }

            [DataMember(Name="pricingBehavior")]
			public ProductPricingBehaviorInfo PricingBehavior { get; set; }

			///
			///Properties defined for a product as they appear in its associated catalogs.
			///
            [DataMember(Name="productInCatalogs")]
			public List<ProductInCatalogInfo> ProductInCatalogs { get; set; }

			///
			///The list of product properties to set in product admin.
			///
            [DataMember(Name="properties")]
			public List<ProductProperty> Properties { get; set; }

			///
			///Properties of the product publishing settings for the associated product.
			///
            [DataMember(Name="publishingInfo")]
			public ProductPublishingInfo PublishingInfo { get; set; }

			///
			///search engine optimized product content.
			///
            [DataMember(Name="seoContent")]
			public ProductLocalizedSEOContent SeoContent { get; set; }

            [DataMember(Name="supplierInfo")]
			public ProductSupplierInfo SupplierInfo { get; set; }

			///
			///The list of product variation options that exist in product admin.
			///
            [DataMember(Name="variationOptions")]
			public List<ProductVariationOption> VariationOptions { get; set; }

		}

}