#nullable enable

namespace Ultravox
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List scheduled calls within a batch.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="batchId"></param>
        /// <param name="cursor"></param>
        /// <param name="pageSize"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.PaginatedScheduledCallList> AgentsScheduledBatchesScheduledCallsListAsync(
            global::System.Guid agentId,
            global::System.Guid batchId,
            string? cursor = default,
            int? pageSize = default,
            global::Ultravox.AgentsScheduledBatchesScheduledCallsListStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}