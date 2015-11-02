
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.Core
{
		///
		///	Properties of a role assigned to a user for a defined scope.
		///
		public class UserRole
		{
			///
			///Properties of the developer account or Mozu tenant associated with the user role.
			///
			public UserScope AssignedInScope { get; set; }

			///
			///Identifier and datetime stamp information recorded when a user or application creates, updates, or deletes a resource entity. This value is system-supplied and read-only.
			///
			public AuditInfo AuditInfo { get; set; }

			///
			///Unique identifier of the user role.
			///
			public int RoleId { get; set; }

			///
			///The name of the user role, such as "developer" or "administrator".
			///
			public string RoleName { get; set; }

			///
			///Unique identifier of the customer account (shopper or system user). System-supplied and read-only. If the shopper user is anonymous, the user ID represents a system-generated user ID string.
			///
			public string UserId { get; set; }

		}

}