
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Customer
{
	public partial class CustomerAccountUrl 
	{

		/// <summary>
        /// Get Resource Url for GetAccounts
        /// </summary>
        /// <param name="fields">The fields to include in the response.</param>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="isAnonymous">If true, retrieve anonymous shopper accounts in the response.</param>
        /// <param name="pageSize"></param>
        /// <param name="q">A list of order search terms (not phrases) to use in the query when searching across order number and the name or email of the billing contact. When entering, separate multiple search terms with a space character.</param>
        /// <param name="qLimit">The maximum number of search results to return in the response. You can limit any range between 1-100.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAccountsUrl(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string fields =  null, string q =  null, int? qLimit =  null, bool? isAnonymous =  null, string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&fields={fields}&q={q}&qLimit={qLimit}&isAnonymous={isAnonymous}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "fields", fields);
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "isAnonymous", isAnonymous);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "q", q);
			mozuUrl.FormatUrl( "qLimit", qLimit);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetLoginState
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLoginStateUrl(int accountId, string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/loginstate?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetAccount
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAccountUrl(int accountId, string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/{accountId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddAccount
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddAccountUrl(string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for ChangePassword
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="unlockAccount"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ChangePasswordUrl(int accountId, bool? unlockAccount =  null)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/Change-Password?unlockAccount={unlockAccount}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "unlockAccount", unlockAccount);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for AddLoginToExistingCustomer
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddLoginToExistingCustomerUrl(int accountId, string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/Create-Login?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for RecomputeCustomerLifetimeValue
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl RecomputeCustomerLifetimeValueUrl(int accountId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/recomputelifetimevalue";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for SetLoginLocked
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl SetLoginLockedUrl(int accountId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/Set-Login-Locked";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for SetPasswordChangeRequired
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl SetPasswordChangeRequiredUrl(int accountId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/Set-Password-Change-Required";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for AddAccountAndLogin
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddAccountAndLoginUrl(string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/Add-Account-And-Login?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for AddAccounts
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddAccountsUrl(string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/Bulk?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for ChangePasswords
        /// </summary>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ChangePasswordsUrl(string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/Change-Passwords?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetLoginStateByEmailAddress
        /// </summary>
        /// <param name="emailAddress">The email address associated with the customer account.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLoginStateByEmailAddressUrl(string emailAddress, string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/loginstatebyemailaddress?emailAddress={emailAddress}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "emailAddress", emailAddress);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetLoginStateByUserName
        /// </summary>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <param name="userName">The user name associated with the customer account.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetLoginStateByUserNameUrl(string userName, string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/loginstatebyusername?userName={userName}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "userName", userName);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for ResetPassword
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl ResetPasswordUrl()
		{
			var url = "/api/commerce/customer/accounts/Reset-Password";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateAccount
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateAccountUrl(int accountId, string responseFields =  null)
		{
			var url = "/api/commerce/customer/accounts/{accountId}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteAccount
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteAccountUrl(int accountId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			return mozuUrl;
		}

		
	}
}
