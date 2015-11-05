
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


namespace Mozu.Api.Resources.Platform.TenantData
{
	/// <summary>
	/// Use the tenant data resource to store tenant-level information required for a third-party application in the Mozu database.
	/// </summary>
	public partial class TenantDataResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		public TenantDataResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// Retrieves the value of a record in the Mozu database.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry query string used to retrieve the record information.</param>
		/// <returns>
		/// string
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantdata = new TenantData();
		///   var string = tenantdata.GetDBValue( dbEntryQuery);
		/// </code>
		/// </example>
		public virtual string GetDBValue(string dbEntryQuery)
		{
			MozuClient<string> response;
			var client = Mozu.Api.Clients.Platform.TenantData.TenantDataClient.GetDBValueClient( dbEntryQuery);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new record in the Mozu database based on the information supplied in the request.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry string to create.</param>
		/// <param name="value">The value string to create.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantdata = new TenantData();
		///   tenantdata.CreateDBValue( value,  dbEntryQuery);
		/// </code>
		/// </example>
		public virtual void CreateDBValue(string value, string dbEntryQuery)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.TenantData.TenantDataClient.CreateDBValueClient( value,  dbEntryQuery);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		/// <summary>
		/// Updates a record in the Mozu database based on the information supplied in the request.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry query string used to update the record information.</param>
		/// <param name="value">The database value to update.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantdata = new TenantData();
		///   tenantdata.UpdateDBValue( value,  dbEntryQuery);
		/// </code>
		/// </example>
		public virtual void UpdateDBValue(string value, string dbEntryQuery)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.TenantData.TenantDataClient.UpdateDBValueClient( value,  dbEntryQuery);
			client.WithContext(_apiContext);
			response= client.Execute();

		}

		/// <summary>
		/// Removes a previously defined record in the Mozu database.
		/// </summary>
		/// <param name="dbEntryQuery">The database entry string to delete.</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var tenantdata = new TenantData();
		///   tenantdata.DeleteDBValue( dbEntryQuery);
		/// </code>
		/// </example>
		public virtual void DeleteDBValue(string dbEntryQuery)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Platform.TenantData.TenantDataClient.DeleteDBValueClient( dbEntryQuery);
			client.WithContext(_apiContext);
			response= client.Execute();

		}


	}

}


