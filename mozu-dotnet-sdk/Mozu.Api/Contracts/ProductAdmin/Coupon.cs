
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

using Mozu.Api.Contracts.Core;

namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	Mozu.ProductAdmin.Contracts.Coupon ApiType DOCUMENT_HERE 
		///
		public class Coupon
		{
			///
			///Basic audit info about the object, including date, time, and user account. Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Mozu.ProductAdmin.Contracts.Coupon canBeDeleted ApiTypeMember DOCUMENT_HERE 
			///
			public bool CanBeDeleted { get; set; }

			///
			///Code of a discount coupon. This code can be used by a shopper when a coupon code is required to earn the associated discount on a purchase.
			///
			public string CouponCode { get; set; }

			///
			///Link to associated coupon
			///
			public string CouponSetCode { get; set; }

			///
			///ReadOnly system id for releated couponset.
			///
			public int CouponSetId { get; set; }

			///
			///Total number of times this code has been redeemed. ReadOnly, calculated. Only returned with response group includeCounts
			///
			public int? RedemptionCount { get; set; }

		}

}