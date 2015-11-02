
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

namespace Mozu.Api.Resources.Commerce.Admin
{
	/// <summary>
	/// Use the Locations resource to manage each physical location associated with a tenant. Locations enable tenants to associate a physical address with product inventory, provide a store finder for in-store pickup, or both. Locations that support inventory can use both direct ship and in-store pickup fulfillment types.
	/// </summary>
	public partial class LocationResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public LocationResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public LocationResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new LocationResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// Retrieves a list of all locations associated with a tenant, according to any filter and sort criteria specified in the request.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.LocationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var locationCollection = location.GetLocations( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.LocationCollection GetLocations(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationCollection> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationClient.GetLocationsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of all locations associated with a tenant, according to any filter and sort criteria specified in the request.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.LocationCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var locationCollection = await location.GetLocationsAsync( startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Location.LocationCollection> GetLocationsAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.LocationCollection> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationClient.GetLocationsClient( startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of the location specified in the request by location code.
		/// </summary>
		/// <param name="locationCode">The unique, user-defined code that identifies a location. </param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.Location"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var location = location.GetLocation( locationCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.Location GetLocation(string locationCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationClient.GetLocationClient( locationCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of the location specified in the request by location code.
		/// </summary>
		/// <param name="locationCode">The unique, user-defined code that identifies a location. </param>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.Location"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var location = await location.GetLocationAsync( locationCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Location.Location> GetLocationAsync(string locationCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationClient.GetLocationClient( locationCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new physical location for the tenant specified in the request header.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="location">Properties of a physical location a tenant uses to manage inventory and fulfills orders, provide store finder functionality, or both.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.Location"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var location = location.AddLocation( location,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.Location AddLocation(Mozu.Api.Contracts.Location.Location location, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationClient.AddLocationClient( location,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new physical location for the tenant specified in the request header.
		/// </summary>
		/// <param name="responseFields">A list or array of fields returned for a call. These fields may be customized and may be used for various types of data calls in Mozu. For example, responseFields are returned for retrieving or updating attributes, carts, and messages in Mozu.</param>
		/// <param name="location">Properties of a physical location a tenant uses to manage inventory and fulfills orders, provide store finder functionality, or both.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.Location"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var location = await location.AddLocationAsync( location,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Location.Location> AddLocationAsync(Mozu.Api.Contracts.Location.Location location, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationClient.AddLocationClient( location,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates one or more details of a the location specified in the request by location code.
		/// </summary>
		/// <param name="locationCode">The unique, user-defined code that identifies a location. </param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="location">Properties of a physical location a tenant uses to manage inventory and fulfills orders, provide store finder functionality, or both.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.Location"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var location = location.UpdateLocation( location,  locationCode,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Location.Location UpdateLocation(Mozu.Api.Contracts.Location.Location location, string locationCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationClient.UpdateLocationClient( location,  locationCode,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates one or more details of a the location specified in the request by location code.
		/// </summary>
		/// <param name="locationCode">The unique, user-defined code that identifies a location. </param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="location">Properties of a physical location a tenant uses to manage inventory and fulfills orders, provide store finder functionality, or both.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Location.Location"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   var location = await location.UpdateLocationAsync( location,  locationCode,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Location.Location> UpdateLocationAsync(Mozu.Api.Contracts.Location.Location location, string locationCode, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Location.Location> response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationClient.UpdateLocationClient( location,  locationCode,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes the location specified in the request.
		/// </summary>
		/// <param name="locationCode">The unique, user-defined code that identifies a location. </param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   location.DeleteLocation( locationCode);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteLocation(string locationCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationClient.DeleteLocationClient( locationCode);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes the location specified in the request.
		/// </summary>
		/// <param name="locationCode">The unique, user-defined code that identifies a location. </param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var location = new Location();
		///   await location.DeleteLocationAsync( locationCode);
		/// </code>
		/// </example>
		public virtual async Task DeleteLocationAsync(string locationCode)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Admin.LocationClient.DeleteLocationClient( locationCode);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}

