
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

namespace Mozu.Api.Resources.Commerce.Catalog.Admin.Attributedefinition
{
	/// <summary>
	/// Use the Product Types resource to manage the types for your product catalog. Product types act as configuration templates, which store a set of attributes common to all products associated with that type. Unlike categories, products can only be associated with a single product type.
	/// </summary>
	public partial class ProductTypeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		private readonly DataViewMode _dataViewMode;
		
		public ProductTypeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
			_dataViewMode = DataViewMode.Live;
		}

		public ProductTypeResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new ProductTypeResource(_apiContext.CloneWith(contextModification), _dataViewMode);
		}

		public ProductTypeResource(IApiContext apiContext, DataViewMode dataViewMode) 
		{
			_apiContext = apiContext;
			_dataViewMode = dataViewMode;
		}
				
		/// <summary>
		/// Retrieves a list of product types according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   var productTypeCollection = producttype.GetProductTypes(_dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection GetProductTypes(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.ProductTypeClient.GetProductTypesClient(_dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a list of product types according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="filter">A set of filter expressions representing the search parameters for a query: eq=equals, ne=not equals, gt=greater than, lt = less than or equals, gt = greater than or equals, lt = less than or equals, sw = starts with, or cont = contains. Optional.</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy"></param>
		/// <param name="startIndex"></param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   var productTypeCollection = await producttype.GetProductTypesAsync(_dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection> GetProductTypesAsync(int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductTypeCollection> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.ProductTypeClient.GetProductTypesClient(_dataViewMode,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves the details of the product type specified in the request.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   var productType = producttype.GetProductType(_dataViewMode,  productTypeId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductType GetProductType(int productTypeId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.ProductTypeClient.GetProductTypeClient(_dataViewMode,  productTypeId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves the details of the product type specified in the request.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   var productType = await producttype.GetProductTypeAsync(_dataViewMode,  productTypeId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductType> GetProductTypeAsync(int productTypeId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.ProductTypeClient.GetProductTypeClient(_dataViewMode,  productTypeId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Creates a new product type based on the information supplied in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="productType">A product type is like a product template.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   var productType = producttype.AddProductType(_dataViewMode,  productType,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductType AddProductType(Mozu.Api.Contracts.ProductAdmin.ProductType productType, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.ProductTypeClient.AddProductTypeClient(_dataViewMode,  productType,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Creates a new product type based on the information supplied in the request.
		/// </summary>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="productType">A product type is like a product template.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   var productType = await producttype.AddProductTypeAsync(_dataViewMode,  productType,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductType> AddProductTypeAsync(Mozu.Api.Contracts.ProductAdmin.ProductType productType, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.ProductTypeClient.AddProductTypeClient(_dataViewMode,  productType,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Updates one or more properties of a product type.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="productType">A product type is like a product template.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   var productType = producttype.UpdateProductType(_dataViewMode,  productType,  productTypeId,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.ProductAdmin.ProductType UpdateProductType(Mozu.Api.Contracts.ProductAdmin.ProductType productType, int productTypeId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.ProductTypeClient.UpdateProductTypeClient(_dataViewMode,  productType,  productTypeId,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Updates one or more properties of a product type.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <param name="productType">A product type is like a product template.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.ProductAdmin.ProductType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   var productType = await producttype.UpdateProductTypeAsync(_dataViewMode,  productType,  productTypeId,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.ProductAdmin.ProductType> UpdateProductTypeAsync(Mozu.Api.Contracts.ProductAdmin.ProductType productType, int productTypeId, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.ProductAdmin.ProductType> response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.ProductTypeClient.UpdateProductTypeClient(_dataViewMode,  productType,  productTypeId,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Deletes the product type by providing the product type ID.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   producttype.DeleteProductType(_dataViewMode,  productTypeId);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual void DeleteProductType(int productTypeId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.ProductTypeClient.DeleteProductTypeClient(_dataViewMode,  productTypeId);
			client.WithContext(_apiContext);
			response = client.Execute();

		}

		/// <summary>
		/// Deletes the product type by providing the product type ID.
		/// </summary>
		/// <param name="productTypeId">Identifier of the product type.</param>
		/// <param name="dataViewMode">{<see cref="Mozu.Api.DataViewMode"/>}</param>
		/// <returns>
		/// 
		/// </returns>
		/// <example>
		/// <code>
		///   var producttype = new ProductType();
		///   await producttype.DeleteProductTypeAsync(_dataViewMode,  productTypeId);
		/// </code>
		/// </example>
		public virtual async Task DeleteProductTypeAsync(int productTypeId)
		{
			MozuClient response;
			var client = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.ProductTypeClient.DeleteProductTypeClient(_dataViewMode,  productTypeId);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();

		}


	}

}


