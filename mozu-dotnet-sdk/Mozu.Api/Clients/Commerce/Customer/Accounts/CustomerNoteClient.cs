
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

namespace Mozu.Api.Clients.Commerce.Customer.Accounts
{
	/// <summary>
	/// Tenant administrators can add and view internal notes for a customer account. For example, a client can track a shopper's interests or complaints. Only clients can add and view notes. Shoppers cannot view these notes from the My Account page.
	/// </summary>
	public partial class CustomerNoteClient 	{
		
		/// <summary>
		/// Retrieves the contents of a particular note attached to a specified customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerNote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccountNote( accountId,  noteId,  responseFields);
		///   var customerNoteClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerNote> GetAccountNoteClient(int accountId, int noteId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerNoteUrl.GetAccountNoteUrl(accountId, noteId, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerNote>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Retrieves a list of notes added to a customer account according to any specified filter criteria and sort options.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The maximum value is 200.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The property by which to sort results and whether the results appear in ascending (a-z) order, represented by ASC or in descending (z-a) order, represented by DESC. The sortBy parameter follows an available property. For example: "sortBy=productCode+asc"</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a PageSize of 25, to get the 51st through the 75th items, use startIndex=3.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerNoteCollection"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=GetAccountNotes( accountId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		///   var customerNoteCollectionClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerNoteCollection> GetAccountNotesClient(int accountId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerNoteUrl.GetAccountNotesUrl(accountId, startIndex, pageSize, sortBy, filter, responseFields);
			const string verb = "GET";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerNoteCollection>()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}

		/// <summary>
		/// Adds a new note to the specified customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="note">Properties of a note configured for a customer account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerNote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=AddAccountNote( note,  accountId,  responseFields);
		///   var customerNoteClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerNote> AddAccountNoteClient(Mozu.Api.Contracts.Customer.CustomerNote note, int accountId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerNoteUrl.AddAccountNoteUrl(accountId, responseFields);
			const string verb = "POST";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerNote>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerNote>(note);
			return mozuClient;

		}

		/// <summary>
		/// Modifies an existing note for a customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="note">Properties of a note configured for a customer account.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />{<see cref="Mozu.Api.Contracts.Customer.CustomerNote"/>}
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=UpdateAccountNote( note,  accountId,  noteId,  responseFields);
		///   var customerNoteClient = mozuClient.WithBaseAddress(url).Execute().Result();
		/// </code>
		/// </example>
		public static MozuClient<Mozu.Api.Contracts.Customer.CustomerNote> UpdateAccountNoteClient(Mozu.Api.Contracts.Customer.CustomerNote note, int accountId, int noteId, string responseFields =  null)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerNoteUrl.UpdateAccountNoteUrl(accountId, noteId, responseFields);
			const string verb = "PUT";
			var mozuClient = new MozuClient<Mozu.Api.Contracts.Customer.CustomerNote>()
									.WithVerb(verb).WithResourceUrl(url)
									.WithBody<Mozu.Api.Contracts.Customer.CustomerNote>(note);
			return mozuClient;

		}

		/// <summary>
		/// Removes a note from the specified customer account.
		/// </summary>
		/// <param name="accountId">Unique identifier of the customer account.</param>
		/// <param name="noteId">Unique identifier of a particular note to retrieve.</param>
		/// <returns>
		///  <see cref="Mozu.Api.MozuClient" />
		/// </returns>
		/// <example>
		/// <code>
		///   var mozuClient=DeleteAccountNote( accountId,  noteId);
		///mozuClient.WithBaseAddress(url).Execute();
		/// </code>
		/// </example>
		public static MozuClient DeleteAccountNoteClient(int accountId, int noteId)
		{
			var url = Mozu.Api.Urls.Commerce.Customer.Accounts.CustomerNoteUrl.DeleteAccountNoteUrl(accountId, noteId);
			const string verb = "DELETE";
			var mozuClient = new MozuClient()
									.WithVerb(verb).WithResourceUrl(url)
;
			return mozuClient;

		}


	}

}


