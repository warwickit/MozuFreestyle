//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Usings Setup

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using Mozu.Api;
using Mozu.Api.Security;
using Mozu.Api.Test.Helpers;
using System.Diagnostics;

#endregion

namespace Mozu.Api.Test.Factories
{
	/// <summary>
	/// Type rules are subresources of product attributes which could be specifications that can be shared across products in a store or assigned to specific products. Attribute type rules provide definitions of how attribute types will appear on the user interface.
	/// </summary>
	public partial class AttributeTypeRuleFactory : BaseDataFactory
	{

		/// <summary> 
		/// Retrieves a list of attribute type rules according to optional filter criteria and sort options. Attribute type rules help drive the behavior of attributes on a storefront page.
		/// <example> 
		///  <code> 
		/// var result = AttributeTypeRuleFactory.GetAttributeTypeRules(handler : handler,  startIndex :  startIndex,  pageSize :  pageSize,  sortBy :  sortBy,  filter :  filter,  dataViewMode: dataViewMode,  expectedCode: expectedCode, successCode: successCode); 
		/// var optionalCasting = ConvertClass<AttributeTypeRuleCollection/>(result); 
		/// return optionalCasting;
		///  </code> 
		/// </example> 
		/// </summary>
		public static Mozu.Api.Contracts.ProductAdmin.AttributeTypeRuleCollection GetAttributeTypeRules(ServiceClientMessageHandler handler, 
 		 int? startIndex = null, int? pageSize = null, string sortBy = null, string filter = null,  DataViewMode dataViewMode= DataViewMode.Live, 
		 HttpStatusCode expectedCode = HttpStatusCode.OK, HttpStatusCode successCode = HttpStatusCode.OK)
		{
			SetSdKparameters();
			var currentClassName = System.Reflection.MethodInfo.GetCurrentMethod().DeclaringType.Name;
			var currentMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
			Debug.WriteLine(currentMethodName  + '.' + currentMethodName );
			var apiClient = Mozu.Api.Clients.Commerce.Catalog.Admin.Attributedefinition.Attributes.AttributeTypeRuleClient.GetAttributeTypeRulesClient(
				 startIndex :  startIndex,  pageSize :  pageSize,  sortBy :  sortBy,  filter :  filter, dataViewMode: dataViewMode		);
			try
			{
				apiClient.WithContext(handler.ApiContext).Execute();
			}
			catch (ApiException ex)
			{
				// Custom error handling for test cases can be placed here
				Exception customException = TestFailException.GetCustomTestException(ex, currentClassName, currentMethodName, expectedCode);
				if (customException != null)
					throw customException;
				return null;
			}
			return ResponseMessageFactory.CheckResponseCodes(apiClient.HttpResponse.StatusCode, expectedCode, successCode) 
					 ? (apiClient.Result()) 
					 : null;

		}
  

	}

}

