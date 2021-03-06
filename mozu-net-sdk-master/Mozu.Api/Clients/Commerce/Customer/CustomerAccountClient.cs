
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


namespace Mozu.Api.Clients.Commerce.Customer
{
	/// <summary>
	/// Use the Customer Accounts resource to manage the components of shopper accounts, including attributes, contact information, company notes, and groups associated with the customer account.
	/// </summary>
	public partial class CustomerAccountClient 	{
		
		/// <summary>
		/// Retrieves a list of customer accounts.
		/// </summary>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAccountCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccounts();
		///   var customerAccountCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAccountCollection> GetAccountsClient()
		{
			return GetAccountsClient( null,  null,  null,  null,  null,  null,  null,  null);
		}

		/// <summary>
		/// Retrieves a list of customer accounts.
		/// </summary>
		/// <param name="fields">The fields to include in the response.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="isAnonymous"></param>
		/// <param name="pageSize"></param>
		/// <param name="q">A list of customer account search terms to use in the query when searching across customer name and email. Separate multiple search terms with a space character.</param>
		/// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAccountCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccounts( startIndex,  pageSize,  sortBy,  filter,  fields,  q,  qLimit,  isAnonymous);
		///   var customerAccountCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAccountCollection> GetAccountsClient(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string fields =  null, string q =  null, int? qLimit =  null, bool? isAnonymous =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.GetAccountsUrl(fields, filter, isAnonymous, pageSize, q, qLimit, sortBy, startIndex);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAccountCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieve details of a customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAccount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccount( accountId);
		///   var customerAccountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount> GetAccountClient(int accountId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.GetAccountUrl(accountId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.LoginState"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLoginState( accountId);
		///   var loginStateClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.LoginState> GetLoginStateClient(int accountId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.GetLoginStateUrl(accountId);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.LoginState>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Creates a new customer account based on the information specified in the request.
		/// </summary>
		/// <param name="account">Properties of the customer account to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAccount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAccount( account);
		///   var customerAccountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount> AddAccountClient(Mozu.Api.Contracts.Customer.CustomerAccount account)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.AddAccountUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerAccount>(account);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="passwordInfo"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ChangePassword( passwordInfo,  accountId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient ChangePasswordClient(Mozu.Api.Contracts.Customer.PasswordInfo passwordInfo, int accountId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.ChangePasswordUrl(accountId);
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.PasswordInfo>(passwordInfo);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="customerAuthInfo"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAuthTicket"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddLoginToExistingCustomer( customerAuthInfo,  accountId);
		///   var customerAuthTicketClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket> AddLoginToExistingCustomerClient(Mozu.Api.Contracts.Customer.CustomerLoginInfo customerAuthInfo, int accountId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.AddLoginToExistingCustomerUrl(accountId);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerLoginInfo>(customerAuthInfo);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=RecomputeCustomerLifetimeValue( accountId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient RecomputeCustomerLifetimeValueClient(int accountId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.RecomputeCustomerLifetimeValueUrl(accountId);
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="isLocked"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=SetLoginLocked( isLocked,  accountId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient SetLoginLockedClient(bool isLocked, int accountId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.SetLoginLockedUrl(accountId);
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(isLocked);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountId"></param>
		/// <param name="isPasswordChangeRequired"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=SetPasswordChangeRequired( isPasswordChangeRequired,  accountId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient SetPasswordChangeRequiredClient(bool isPasswordChangeRequired, int accountId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.SetPasswordChangeRequiredUrl(accountId);
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody(isPasswordChangeRequired);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="accountAndAuthInfo"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAuthTicket"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAccountAndLogin( accountAndAuthInfo);
		///   var customerAuthTicketClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket> AddAccountAndLoginClient(Mozu.Api.Contracts.Customer.CustomerAccountAndAuthInfo accountAndAuthInfo)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.AddAccountAndLoginUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAuthTicket>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerAccountAndAuthInfo>(accountAndAuthInfo);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="customers"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAccountCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAccounts( customers);
		///   var customerAccountCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAccountCollection> AddAccountsClient(List<Mozu.Api.Contracts.Customer.CustomerAccountAndAuthInfo> customers)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.AddAccountsUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAccountCollection>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<List<Mozu.Api.Contracts.Customer.CustomerAccountAndAuthInfo>>(customers);
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="emailAddress"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.LoginState"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLoginStateByEmailAddress( emailAddress);
		///   var loginStateClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.LoginState> GetLoginStateByEmailAddressClient(string emailAddress)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.GetLoginStateByEmailAddressUrl(emailAddress);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.LoginState>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="userName"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.LoginState"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetLoginStateByUserName( userName);
		///   var loginStateClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.LoginState> GetLoginStateByUserNameClient(string userName)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.GetLoginStateByUserNameUrl(userName);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.LoginState>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="resetPasswordInfo"></param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=ResetPassword( resetPasswordInfo);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient ResetPasswordClient(Mozu.Api.Contracts.Customer.ResetPasswordInfo resetPasswordInfo)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.ResetPasswordUrl();
			const string verb = "POST";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.ResetPasswordInfo>(resetPasswordInfo);
			return mozuClient;

		}

		/// <summary>
		/// Updates a customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="account">Properties of the customer account to update.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerAccount"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAccount( account,  accountId);
		///   var customerAccountClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount> UpdateAccountClient(Mozu.Api.Contracts.Customer.CustomerAccount account, int accountId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.UpdateAccountUrl(accountId);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerAccount>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerAccount>(account);
			return mozuClient;

		}

		/// <summary>
		/// Deletes a customer account. A customer account cannot be deleted if any orders exist, past or present.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account to delete.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteAccount( accountId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteAccountClient(int accountId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.CustomerAccountUrl.DeleteAccountUrl(accountId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


