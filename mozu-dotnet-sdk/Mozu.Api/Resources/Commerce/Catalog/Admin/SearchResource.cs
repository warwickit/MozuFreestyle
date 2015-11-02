
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin
{
	/// <summary>
	/// The Search resource manages all settings and options for providing product search on your site.
	/// </summary>
	public partial class SearchResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public SearchResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public SearchResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new SearchResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// admin-search Get GetSearchTuningRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="searchTuningRuleCode"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchTuningRule = search.GetSearchTuningRule( searchTuningRuleCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule GetSearchTuningRule(string searchTuningRuleCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSearchTuningRuleClient( searchTuningRuleCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// admin-search Get GetSearchTuningRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="searchTuningRuleCode"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchTuningRule = await search.GetSearchTuningRuleAsync( searchTuningRuleCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> GetSearchTuningRuleAsync(string searchTuningRuleCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSearchTuningRuleClient( searchTuningRuleCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// admin-search Get GetSearchTuningRules description DOCUMENT_HERE 
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=3`.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchTuningRuleCollection = search.GetSearchTuningRules( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleCollection GetSearchTuningRules(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSearchTuningRulesClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// admin-search Get GetSearchTuningRules description DOCUMENT_HERE 
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=3`.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchTuningRuleCollection = await search.GetSearchTuningRulesAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleCollection> GetSearchTuningRulesAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSearchTuningRulesClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var stream = search.GetSearchTuningRuleSortFields();
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual System.IO.Stream GetSearchTuningRuleSortFields()
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSearchTuningRuleSortFieldsClient();
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="System.IO.Stream"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var stream = await search.GetSearchTuningRuleSortFieldsAsync();
		/// </code>
		/// </example>
		public virtual async Task<System.IO.Stream> GetSearchTuningRuleSortFieldsAsync()
		{
			MozuClient<System.IO.Stream> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSearchTuningRuleSortFieldsClient();
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Get site search settings
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SearchSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchSettings = search.GetSettings( responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.SearchSettings GetSettings(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSettingsClient( responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Get site search settings
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SearchSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchSettings = await search.GetSettingsAsync( responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.SearchSettings> GetSettingsAsync(string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.GetSettingsClient( responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// admin-search Post AddSearchTuningRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="searchTuningRuleIn">Mozu.ProductAdmin.Contracts.Search.SearchTuningRule ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchTuningRule = search.AddSearchTuningRule( searchTuningRuleIn,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule AddSearchTuningRule(Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule searchTuningRuleIn, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.AddSearchTuningRuleClient( searchTuningRuleIn,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// admin-search Post AddSearchTuningRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="searchTuningRuleIn">Mozu.ProductAdmin.Contracts.Search.SearchTuningRule ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchTuningRule = await search.AddSearchTuningRuleAsync( searchTuningRuleIn,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> AddSearchTuningRuleAsync(Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule searchTuningRuleIn, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.AddSearchTuningRuleClient( searchTuningRuleIn,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="searchTuningRuleSortFieldsIn"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   search.UpdateSearchTuningRuleSortFields( searchTuningRuleSortFieldsIn);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void UpdateSearchTuningRuleSortFields(Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields searchTuningRuleSortFieldsIn)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.UpdateSearchTuningRuleSortFieldsClient( searchTuningRuleSortFieldsIn);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="searchTuningRuleSortFieldsIn"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   await search.UpdateSearchTuningRuleSortFieldsAsync( searchTuningRuleSortFieldsIn);
		/// </code>
		/// </example>
		public virtual async Task UpdateSearchTuningRuleSortFieldsAsync(Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRuleSortFields searchTuningRuleSortFieldsIn)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.UpdateSearchTuningRuleSortFieldsClient( searchTuningRuleSortFieldsIn);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}

		/// <summary>
		/// admin-search Put UpdateSearchTuningRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="searchTuningRuleCode"></param>
		/// <param name="searchTuningRuleIn">Mozu.ProductAdmin.Contracts.Search.SearchTuningRule ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchTuningRule = search.UpdateSearchTuningRule( searchTuningRuleIn,  searchTuningRuleCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule UpdateSearchTuningRule(Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule searchTuningRuleIn, string searchTuningRuleCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.UpdateSearchTuningRuleClient( searchTuningRuleIn,  searchTuningRuleCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// admin-search Put UpdateSearchTuningRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="searchTuningRuleCode"></param>
		/// <param name="searchTuningRuleIn">Mozu.ProductAdmin.Contracts.Search.SearchTuningRule ApiType DOCUMENT_HERE </param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchTuningRule = await search.UpdateSearchTuningRuleAsync( searchTuningRuleIn,  searchTuningRuleCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> UpdateSearchTuningRuleAsync(Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule searchTuningRuleIn, string searchTuningRuleCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.Search.SearchTuningRule> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.UpdateSearchTuningRuleClient( searchTuningRuleIn,  searchTuningRuleCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Adds or Updates (Upsert) the Search Settings for a specific site
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="settings">The settings to control product search and indexing behavior.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SearchSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchSettings = search.UpdateSettings( settings,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.SearchSettings UpdateSettings(Mozu.Api.Contracts.ProductAdmin.SearchSettings settings, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.UpdateSettingsClient( settings,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Adds or Updates (Upsert) the Search Settings for a specific site
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="settings">The settings to control product search and indexing behavior.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.SearchSettings"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   var searchSettings = await search.UpdateSettingsAsync( settings,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.SearchSettings> UpdateSettingsAsync(Mozu.Api.Contracts.ProductAdmin.SearchSettings settings, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.SearchSettings> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.UpdateSettingsClient( settings,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// admin-search Delete DeleteSearchTuningRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="searchTuningRuleCode"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   search.DeleteSearchTuningRule( searchTuningRuleCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteSearchTuningRule(string searchTuningRuleCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.DeleteSearchTuningRuleClient( searchTuningRuleCode);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// admin-search Delete DeleteSearchTuningRule description DOCUMENT_HERE 
		/// </summary>
		/// <param name="searchTuningRuleCode"></param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var search = new Search();
		///   await search.DeleteSearchTuningRuleAsync( searchTuningRuleCode);
		/// </code>
		/// </example>
		public virtual async Task DeleteSearchTuningRuleAsync(string searchTuningRuleCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.SearchClient.DeleteSearchTuningRuleClient( searchTuningRuleCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


