
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


namespace Mozu.Api.Resources.Commerce.Carts
{
	/// <summary>
	/// 
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

		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartId"></param>
		/// <param name="couponCode"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var applieddiscount = new AppliedDiscount();
		///   var cart = applieddiscount.ApplyCoupon( cartId,  couponCode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.Cart ApplyCoupon(string cartId, string couponCode)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.Carts.AppliedDiscountClient.ApplyCouponClient( cartId,  couponCode);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartId"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var applieddiscount = new AppliedDiscount();
		///   var cart = applieddiscount.RemoveCoupons( cartId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.Cart RemoveCoupons(string cartId)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.Carts.AppliedDiscountClient.RemoveCouponsClient( cartId);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cartId"></param>
		/// <param name="couponCode"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var applieddiscount = new AppliedDiscount();
		///   var cart = applieddiscount.RemoveCoupon( cartId,  couponCode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Carts.Cart RemoveCoupon(string cartId, string couponCode)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> response;
			var client = Mozu.Api.Clients.Commerce.Carts.AppliedDiscountClient.RemoveCouponClient( cartId,  couponCode);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}


	}

}


