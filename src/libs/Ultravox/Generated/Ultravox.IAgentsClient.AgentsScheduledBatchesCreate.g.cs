#nullable enable

namespace Ultravox
{
    public partial interface IAgentsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.ScheduledCallBatch> AgentsScheduledBatchesCreateAsync(
            global::System.Guid agentId,

            global::Ultravox.ScheduledCallBatch request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AutoSDKHttpResponse<global::Ultravox.ScheduledCallBatch>> AgentsScheduledBatchesCreateAsResponseAsync(
            global::System.Guid agentId,

            global::Ultravox.ScheduledCallBatch request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="name">
        /// A name to help you identify the batch.
        /// </param>
        /// <param name="windowStart">
        /// The start of the time window during which calls can be made.
        /// </param>
        /// <param name="windowEnd">
        /// The end of the time window during which calls can be made.
        /// </param>
        /// <param name="throttle">
        /// The name or ID of a call throttle. If specified, calls in this batch will be subject to the rate limits defined by the throttle.
        /// </param>
        /// <param name="quotaUtilizationLimit">
        /// The fraction of your account's call quota (greater than 0 and at most 1) that calls in this batch may use, leaving the rest for other calls. The fraction scales your whole quota and counts all of your account's calls on the same model, so two batches on one model that each set 0.3 share about 30% of your quota (roughly 15% each), not 30% each. Defaults to your account's batch limit, which is 0.9 unless changed. Not available to accounts with a fixed concurrency limit.
        /// </param>
        /// <param name="webhookUrl">
        /// The URL to which a request will be made (synchronously) when a call in the batch is created, excluding those with an outgoing medium. Required if any call has a non-outgoing medium and not allowed otherwise.
        /// </param>
        /// <param name="webhookSecret">
        /// The signing secret for requests made to the webhookUrl. This is used to verify that the request came from Ultravox. If unset, an appropriate secret will be chosen for you (but you'll still need to make your endpoint aware of it to verify requests).
        /// </param>
        /// <param name="paused"></param>
        /// <param name="calls">
        /// Included only in requests
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.ScheduledCallBatch> AgentsScheduledBatchesCreateAsync(
            global::System.Guid agentId,
            string? name = default,
            global::System.DateTime? windowStart = default,
            global::System.DateTime? windowEnd = default,
            string? throttle = default,
            double? quotaUtilizationLimit = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            bool? paused = default,
            global::System.Collections.Generic.IList<global::Ultravox.ScheduledCall>? calls = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}