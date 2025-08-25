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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.ScheduledCallBatch> AgentsScheduledBatchesPartialUpdateAsync(
            global::System.Guid agentId,
            global::System.Guid batchId,
            global::Ultravox.PatchedScheduledCallBatch request,
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
        /// <param name="webhookUrl">
        /// The URL to which a request will be made (synchronously) when a call in the batch is created, excluding those with an outgoing sip medium. Required if any call has a medium other than outgoing sip.
        /// </param>
        /// <param name="webhookSecret">
        /// The signing secret for requests made to the webhookUrl. This is used to verify that the request came from Ultravox. If unset, an appropriate secret will be chosen for you (but you'll still need to make your endpoint aware of it to verify requests).
        /// </param>
        /// <param name="paused"></param>
        /// <param name="calls">
        /// Included only in requests
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.ScheduledCallBatch> AgentsScheduledBatchesPartialUpdateAsync(
            global::System.Guid agentId,
            global::System.Guid batchId,
            global::System.Collections.Generic.IList<global::Ultravox.ScheduledCall> calls,
            global::System.DateTime? windowStart = default,
            global::System.DateTime? windowEnd = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            bool? paused = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}