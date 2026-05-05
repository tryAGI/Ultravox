#nullable enable

namespace Ultravox
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="batchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.ScheduledCallBatch> AgentsScheduledBatchesPartialUpdateAsync(
            global::System.Guid agentId,
            global::System.Guid batchId,

            global::Ultravox.PatchedScheduledCallBatch request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="batchId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AutoSDKHttpResponse<global::Ultravox.ScheduledCallBatch>> AgentsScheduledBatchesPartialUpdateAsResponseAsync(
            global::System.Guid agentId,
            global::System.Guid batchId,

            global::Ultravox.PatchedScheduledCallBatch request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="batchId"></param>
        /// <param name="windowStart">
        /// The start of the time window during which calls can be made.
        /// </param>
        /// <param name="windowEnd">
        /// The end of the time window during which calls can be made.
        /// </param>
        /// <param name="throttle">
        /// The name or ID of a call throttle. If specified, calls in this batch will be subject to the rate limits defined by the throttle.
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
        global::System.Threading.Tasks.Task<global::Ultravox.ScheduledCallBatch> AgentsScheduledBatchesPartialUpdateAsync(
            global::System.Guid agentId,
            global::System.Guid batchId,
            global::System.Collections.Generic.IList<global::Ultravox.ScheduledCall> calls,
            global::System.DateTime? windowStart = default,
            global::System.DateTime? windowEnd = default,
            string? throttle = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            bool? paused = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}