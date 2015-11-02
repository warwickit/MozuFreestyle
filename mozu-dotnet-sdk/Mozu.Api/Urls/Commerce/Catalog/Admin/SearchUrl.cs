
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

namespace Mozu.Api.Urls.Commerce.Catalog.Admin
{
	public partial class SearchUrl 
	{

		/// <summary>
        /// Get Resource Url for GetSearchTuningRule
        /// </summary>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <param name="searchTuningRuleCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetSearchTuningRuleUrl(string searchTuningRuleCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/search/searchtuningrules/{searchTuningRuleCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "searchTuningRuleCode", searchTuningRuleCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetSearchTuningRules
        /// </summary>
        /// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
        /// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
        /// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=3`.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetSearchTuningRulesUrl(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/search/searchtuningrules?startIndex={startIndex}&pageSize={pageSize}&sortBy={sortBy}&filter={filter}&responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "filter", filter);
			mozuUrl.FormatUrl( "pageSize", pageSize);
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "sortBy", sortBy);
			mozuUrl.FormatUrl( "startIndex", startIndex);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetSearchTuningRuleSortFields
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetSearchTuningRuleSortFieldsUrl()
		{
			var url = "/api/commerce/catalog/admin/search/searchtuningrulesortfields";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for GetSettings
        /// </summary>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl GetSettingsUrl(string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/search/settings?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for AddSearchTuningRule
        /// </summary>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl AddSearchTuningRuleUrl(string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/search/searchtuningrules?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UpdateSearchTuningRuleSortFields
        /// </summary>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateSearchTuningRuleSortFieldsUrl()
		{
			var url = "/api/commerce/catalog/admin/search/searchtuningrulesortfields";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for UpdateSearchTuningRule
        /// </summary>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <param name="searchTuningRuleCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateSearchTuningRuleUrl(string searchTuningRuleCode, string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/search/searchtuningrules/{searchTuningRuleCode}?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			mozuUrl.FormatUrl( "searchTuningRuleCode", searchTuningRuleCode);
			return mozuUrl;
		}

		/// <summary>
        /// Get Resource Url for UpdateSettings
        /// </summary>
        /// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl UpdateSettingsUrl(string responseFields =  null)
		{
			var url = "/api/commerce/catalog/admin/search/settings?responseFields={responseFields}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "responseFields", responseFields);
			return mozuUrl;
		}

				/// <summary>
        /// Get Resource Url for DeleteSearchTuningRule
        /// </summary>
        /// <param name="searchTuningRuleCode"></param>
        /// <returns>
        /// String - Resource Url
        /// </returns>
        public static MozuUrl DeleteSearchTuningRuleUrl(string searchTuningRuleCode)
		{
			var url = "/api/commerce/catalog/admin/search/searchtuningrules/{searchTuningRuleCode}";
			var mozuUrl = new MozuUrl(url, MozuUrl.UrlLocation.TENANT_POD, false) ;
			mozuUrl.FormatUrl( "searchTuningRuleCode", searchTuningRuleCode);
			return mozuUrl;
		}

		
	}
}
