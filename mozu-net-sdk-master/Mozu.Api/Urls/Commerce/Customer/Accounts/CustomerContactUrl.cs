
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Mozu.Api.Urls.Commerce.Customer.Accounts
{
	public partial class CustomerContactUrl 
	{

		/// <summary>
        /// Get Resource Url for GetAccountContact
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account whose contact information is being retrieved.</param>
        /// <param name="contactId">Unique identifier of the customer account contact to retrieve.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAccountContactUrl(int accountId, int contactId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/contacts/{contactId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "contactId", contactId);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetAccountContacts
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account associated with the contact information to retrieve.</param>
        /// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
        /// <param name="sortBy"></param>
        /// <param name="startIndex"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetAccountContactsUrl(int accountId, string filter, int? pageSize, string sortBy, int? startIndex)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/contacts?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddAccountContact
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account containing the new contact.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddAccountContactUrl(int accountId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/contacts";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateAccountContact
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account whose contact information is being updated.</param>
        /// <param name="contactId">Unique identifer of the customer account contact being updated.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateAccountContactUrl(int accountId, int contactId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/contacts/{contactId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "contactId", contactId);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteAccountContact
        /// </summary>
        /// <param name="accountId">Unique identifier of the customer account.</param>
        /// <param name="contactId">Unique identifier of the customer account contact to delete.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteAccountContactUrl(int accountId, int contactId)
		{
			var url = "/api/commerce/customer/accounts/{accountId}/contacts/{contactId}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "accountId", accountId);
			mozuUrl.FormatUrl( "contactId", contactId);
			return mozuUrl;
		}

		
	}
}

