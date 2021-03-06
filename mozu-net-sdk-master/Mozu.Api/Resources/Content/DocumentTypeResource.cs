
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


namespace Mozu.Api.Resources.Content
{
	/// <summary>
	/// The DocumentTypes resource is a part of the Content Service.
	/// </summary>
	public partial class DocumentTypeResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		public DocumentTypeResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		
		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentTypeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttype = new DocumentType();
		///   var documentTypeCollection = documenttype.GetDocumentTypes(dataViewMode);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Content.DocumentTypeCollection GetDocumentTypes(DataViewMode dataViewMode)
		{
			return GetDocumentTypes(dataViewMode,  null,  null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="pageSize"></param>
		/// <param name="startIndex"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentTypeCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttype = new DocumentType();
		///   var documentTypeCollection = documenttype.GetDocumentTypes(dataViewMode,  pageSize,  startIndex);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Content.DocumentTypeCollection GetDocumentTypes(DataViewMode dataViewMode, int? pageSize =  null, int? startIndex =  null)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentTypeCollection> response;
			var client = Mozu.Api.Clients.Content.DocumentTypeClient.GetDocumentTypesClient(dataViewMode,  pageSize,  startIndex);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="documentTypeName"></param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Content.DocumentType"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var documenttype = new DocumentType();
		///   var documentType = documenttype.GetDocumentType(dataViewMode,  documentTypeName);
		/// </code>
		/// </example>
		public virtual Mozu.Api.Contracts.Content.DocumentType GetDocumentType(DataViewMode dataViewMode, string documentTypeName)
		{
			MozuClient<Mozu.Api.Contracts.Content.DocumentType> response;
			var client = Mozu.Api.Clients.Content.DocumentTypeClient.GetDocumentTypeClient(dataViewMode,  documentTypeName);
			client.WithContext(_apiContext);
			response= client.Execute();
			return response.Result();

		}


	}

}


