
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
using Mozu.Api.Security;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Mozu.Api.Resources.Commerce.Carts
{
	/// <summary>
	/// Use the Cart Coupons subresource to apply a coupon to a defined cart or remove a coupon from a cart. When the shopper proceeds to checkout, the coupons applied to the cart apply to the order.
	/// </summary>
	public partial class AppliedDiscountResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public AppliedDiscountResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public AppliedDiscountResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new AppliedDiscountResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Applies a defined coupon to the cart specified in the request.
		/// </summary>
		/// <param name="cartId">Identifier of the cart to delete.</param>
		/// <param name="couponCode">Code associated with the coupon to remove from the cart.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var applieddiscount = new AppliedDiscount();
		///   var cart = applieddiscount.ApplyCoupon( cartId,  couponCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.Cart ApplyCoupon(string cartId, string couponCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.Carts.AppliedDiscountClient.ApplyCouponClient( cartId,  couponCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Applies a defined coupon to the cart specified in the request.
		/// </summary>
		/// <param name="cartId">Identifier of the cart to delete.</param>
		/// <param name="couponCode">Code associated with the coupon to remove from the cart.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var applieddiscount = new AppliedDiscount();
		///   var cart = await applieddiscount.ApplyCouponAsync( cartId,  couponCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> ApplyCouponAsync(string cartId, string couponCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.Carts.AppliedDiscountClient.ApplyCouponClient( cartId,  couponCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Removes all coupons from the cart specified in the request.
		/// </summary>
		/// <param name="cartId">Identifier of the cart to delete.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var applieddiscount = new AppliedDiscount();
		///   var cart = applieddiscount.RemoveCoupons( cartId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.Cart RemoveCoupons(string cartId)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.Carts.AppliedDiscountClient.RemoveCouponsClient( cartId);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Removes all coupons from the cart specified in the request.
		/// </summary>
		/// <param name="cartId">Identifier of the cart to delete.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var applieddiscount = new AppliedDiscount();
		///   var cart = await applieddiscount.RemoveCouponsAsync( cartId);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> RemoveCouponsAsync(string cartId)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.Carts.AppliedDiscountClient.RemoveCouponsClient( cartId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Removes an applied coupon from the cart specified in the request.
		/// </summary>
		/// <param name="cartId">Identifier of the cart to delete.</param>
		/// <param name="couponCode">Code associated with the coupon to remove from the cart.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var applieddiscount = new AppliedDiscount();
		///   var cart = applieddiscount.RemoveCoupon( cartId,  couponCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.Cart RemoveCoupon(string cartId, string couponCode)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.Carts.AppliedDiscountClient.RemoveCouponClient( cartId,  couponCode);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Removes an applied coupon from the cart specified in the request.
		/// </summary>
		/// <param name="cartId">Identifier of the cart to delete.</param>
		/// <param name="couponCode">Code associated with the coupon to remove from the cart.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var applieddiscount = new AppliedDiscount();
		///   var cart = await applieddiscount.RemoveCouponAsync( cartId,  couponCode);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> RemoveCouponAsync(string cartId, string couponCode)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.Carts.AppliedDiscountClient.RemoveCouponClient( cartId,  couponCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}

