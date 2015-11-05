
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


namespace Mozu.Api.Resources.Commerce.Orders.BillingInfo
{
	/// <summary>
	/// Use the Billing Info subresource to manage the billing information stored for an order.
	/// </summary>
	public partial class BillingInfoResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		public BillingInfoResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves the billing information associated with an order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var billinginfo = new BillingInfo();
		///   var billingInfo = billinginfo.GetBillingInfo( orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo GetBillingInfo(string orderId)
		{
			return GetBillingInfo( orderId,  null);
		}

		/// <summary>
		/// Retrieves the billing information associated with an order.
		/// </summary>
		/// <param name="draft">If true, retrieve the draft version of the order billing information, which might include uncommitted changes.</param>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var billinginfo = new BillingInfo();
		///   var billingInfo = billinginfo.GetBillingInfo( orderId,  draft);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo GetBillingInfo(string orderId, bool? draft =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo> response;
			var client = Mozu.Api.Clients.Commerce.Orders.BillingInfo.BillingInfoClient.GetBillingInfoClient( orderId,  draft);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates the billing information supplied for an order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="billingInfo">The properties of the order billing information to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var billinginfo = new BillingInfo();
		///   var billingInfo = billinginfo.SetBillingInfo( billingInfo,  orderId);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo SetBillingInfo(Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo billingInfo, string orderId)
		{
			return SetBillingInfo( billingInfo,  orderId,  null,  null);
		}

		/// <summary>
		/// Updates the billing information supplied for an order.
		/// </summary>
		/// <param name="orderId">Unique identifier of the order.</param>
		/// <param name="updateMode">Specifies whether to set the billing information by updating the original order, updating the order in draft mode, or updating the order in draft mode and then committing the changes to the original. Draft mode enables users to make incremental order changes before committing the changes to the original order. Valid values are "ApplyToOriginal," "ApplyToDraft," or "ApplyAndCommit."</param>
		/// <param name="version">System-supplied integer that represents the current version of the order, which prevents users from unintentionally overriding changes to the order. When a user performs an operation for a defined order, the system validates that the version of the updated order matches the version of the order on the server. After the operation completes successfully, the system increments the version number by one.</param>
		/// <param name="billingInfo">The properties of the order billing information to update.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var billinginfo = new BillingInfo();
		///   var billingInfo = billinginfo.SetBillingInfo( billingInfo,  orderId,  updateMode,  version);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo SetBillingInfo(Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo billingInfo, string orderId, string updateMode =  null, string version =  null)
		{
			MozuClient<Mozu.Api.Contracts.CommerceRuntime.Payments.BillingInfo> response;
			var client = Mozu.Api.Clients.Commerce.Orders.BillingInfo.BillingInfoClient.SetBillingInfoClient( billingInfo,  orderId,  updateMode,  version);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}


	}

}


