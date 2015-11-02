
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

namespace Mozu.Api.Clients.Commerce
{
	/// <summary>
	/// Use this resource to manage storefront shopping carts as shoppers add and remove items for purchase. Each time a shopper's cart is modified, the Carts resource updates the estimated total with any applicable discounts.
	/// </summary>
	public partial class CartClient 	{
		
		/// <summary>
		/// Retrieves the cart specified in the request.
		/// </summary>
		/// <param name="cartId">Identifier of the cart to delete.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCart( cartId,  responseFields);
		///   var cartClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> GetCartClient(string cartId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.CartUrl.GetCartUrl(cartId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a cart's contents for the current shopper. If the shopper does not have an active cart on the site, the service creates one.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetOrCreateCart( responseFields);
		///   var cartClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> GetOrCreateCartClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.CartUrl.GetOrCreateCartUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves summary information associated with the cart of the current shopper, including the number of items, the current total, and whether the cart has expired. All anonymous idle carts that do not proceed to checkout expire after 14 days.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetCartSummary( responseFields);
		///   var cartSummaryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary> GetCartSummaryClient(string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.CartUrl.GetCartSummaryUrl(responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves summary information associated with the cart of user specified in the request, including the number of items in the cart, the current total, and whether the cart has expired. All anonymous idle carts that do not proceed to checkout expire after 14 days.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetUserCartSummary( userId,  responseFields);
		///   var cartSummaryClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary> GetUserCartSummaryClient(string userId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.CartUrl.GetUserCartSummaryUrl(userId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.CartSummary>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves the cart of the user specified in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="userId">Unique identifier of the user whose tenant scopes you want to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetUserCart( userId,  responseFields);
		///   var cartClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> GetUserCartClient(string userId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.CartUrl.GetUserCartUrl(userId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Update the current shopper's cart.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="cart">Properties of a shopping cart.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.CommerceRuntime.Carts.Cart"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateCart( cart,  responseFields);
		///   var cartClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart> UpdateCartClient(Mozu.Api.Contracts.CommerceRuntime.Carts.Cart cart, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.CartUrl.UpdateCartUrl(responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.CommerceRuntime.Carts.Cart>(cart);
			return mozuClient;

		}

		/// <summary>
		/// Deletes the cart specified in the request.
		/// </summary>
		/// <param name="cartId">Identifier of the cart to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteCart( cartId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteCartClient(string cartId)
		{
			var url = Mozu.Api.Urls.Commerce.CartUrl.DeleteCartUrl(cartId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Deletes the cart of the currently active shopper.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteCurrentCart();
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteCurrentCartClient()
		{
			var url = Mozu.Api.Urls.Commerce.CartUrl.DeleteCurrentCartUrl();
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


