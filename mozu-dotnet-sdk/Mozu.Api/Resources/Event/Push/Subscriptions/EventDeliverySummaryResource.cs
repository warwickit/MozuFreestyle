
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

namespace Mozu.Api.Resources.Event.Push.Subscriptions
{
	/// <summary>
	/// Provides details for each attempted delivery of the event to the endpoint.
	/// </summary>
	public partial class EventDeliverySummaryResource  	{
		///
		/// <see cref="Mozu.Api.ApiContext"/>
		///
		private readonly IApiContext _apiContext;

		
		public EventDeliverySummaryResource(IApiContext apiContext) 
		{
			_apiContext = apiContext;
		}

		public EventDeliverySummaryResource CloneWithApiContext(Action<IApiContext> contextModification) 
		{
			return new EventDeliverySummaryResource(_apiContext.CloneWith(contextModification));
		}

				
		/// <summary>
		/// This operation method is the external/public event entity used specifically in pull/poll event scenarios.
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="subscriptionId">Unique identifier for a subscription, such as subscribing tenants for an event or to receive a notification.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Event.EventDeliverySummary"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var eventdeliverysummary = new EventDeliverySummary();
		///   var eventDeliverySummary = eventdeliverysummary.GetDeliveryAttemptSummary( subscriptionId,  id,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Event.EventDeliverySummary GetDeliveryAttemptSummary(string subscriptionId, int? id =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Event.EventDeliverySummary> response;
			var client = Mozu.Api.Clients.Event.Push.Subscriptions.EventDeliverySummaryClient.GetDeliveryAttemptSummaryClient( subscriptionId,  id,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// This operation method is the external/public event entity used specifically in pull/poll event scenarios.
		/// </summary>
		/// <param name="id">Unique identifier of the customer segment to retrieve.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="subscriptionId">Unique identifier for a subscription, such as subscribing tenants for an event or to receive a notification.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Event.EventDeliverySummary"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var eventdeliverysummary = new EventDeliverySummary();
		///   var eventDeliverySummary = await eventdeliverysummary.GetDeliveryAttemptSummaryAsync( subscriptionId,  id,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Event.EventDeliverySummary> GetDeliveryAttemptSummaryAsync(string subscriptionId, int? id =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Event.EventDeliverySummary> response;
			var client = Mozu.Api.Clients.Event.Push.Subscriptions.EventDeliverySummaryClient.GetDeliveryAttemptSummaryClient( subscriptionId,  id,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}

		/// <summary>
		/// Retrieves a collection of data for delivery attempts of events and notifications. These are notifications sent to subscribing sites and tenants. A paged list is returned sorted and filtered per the entered parameters.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=3`.</param>
		/// <param name="subscriptionId">Unique identifier for a subscription, such as subscribing tenants for an event or to receive a notification.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Event.EventDeliverySummaryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var eventdeliverysummary = new EventDeliverySummary();
		///   var eventDeliverySummaryCollection = eventdeliverysummary.GetDeliveryAttemptSummaries( subscriptionId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		[Obsolete("This method is obsolete; use the async method instead")]
		public virtual Mozu.Api.Contracts.Event.EventDeliverySummaryCollection GetDeliveryAttemptSummaries(string subscriptionId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Event.EventDeliverySummaryCollection> response;
			var client = Mozu.Api.Clients.Event.Push.Subscriptions.EventDeliverySummaryClient.GetDeliveryAttemptSummariesClient( subscriptionId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = client.Execute();
			return response.Result();

		}

		/// <summary>
		/// Retrieves a collection of data for delivery attempts of events and notifications. These are notifications sent to subscribing sites and tenants. A paged list is returned sorted and filtered per the entered parameters.
		/// </summary>
		/// <param name="filter">A set of expressions that consist of a field, operator, and value and represent search parameter syntax when filtering results of a query. Valid operators include equals (eq), does not equal (ne), greater than (gt), less than (lt), greater than or equal to (ge), less than or equal to (le), starts with (sw), or contains (cont). For example - "filter=IsDisplayed+eq+true"</param>
		/// <param name="pageSize">The number of results to display on each page when creating paged results from a query. The amount is divided and displayed on the `pageCount `amount of pages. The default is 20 and maximum value is 200 per page.</param>
		/// <param name="responseFields">Use this field to include those fields which are not included by default.</param>
		/// <param name="sortBy">The element to sort the results by and the channel in which the results appear. Either ascending (a-z) or descending (z-a) channel. Optional.</param>
		/// <param name="startIndex">When creating paged results from a query, this value indicates the zero-based offset in the complete result set where the returned entities begin. For example, with a `pageSize `of 25, to get the 51st through the 75th items, use `startIndex=3`.</param>
		/// <param name="subscriptionId">Unique identifier for a subscription, such as subscribing tenants for an event or to receive a notification.</param>
		/// <returns>
		/// <see cref="Mozu.Api.Contracts.Event.EventDeliverySummaryCollection"/>
		/// </returns>
		/// <example>
		/// <code>
		///   var eventdeliverysummary = new EventDeliverySummary();
		///   var eventDeliverySummaryCollection = await eventdeliverysummary.GetDeliveryAttemptSummariesAsync( subscriptionId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
		/// </code>
		/// </example>
		public virtual async Task<Mozu.Api.Contracts.Event.EventDeliverySummaryCollection> GetDeliveryAttemptSummariesAsync(string subscriptionId, int? startIndex =  null, int? pageSize =  null, string sortBy =  null, string filter =  null, string responseFields =  null)
		{
			MozuClient<Mozu.Api.Contracts.Event.EventDeliverySummaryCollection> response;
			var client = Mozu.Api.Clients.Event.Push.Subscriptions.EventDeliverySummaryClient.GetDeliveryAttemptSummariesClient( subscriptionId,  startIndex,  pageSize,  sortBy,  filter,  responseFields);
			client.WithContext(_apiContext);
			response = await client.ExecuteAsync();
			return await response.ResultAsync();

		}


	}

}

