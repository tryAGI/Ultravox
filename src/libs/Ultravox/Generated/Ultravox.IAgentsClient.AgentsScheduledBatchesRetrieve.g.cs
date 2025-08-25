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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.ScheduledCallBatch> AgentsScheduledBatchesRetrieveAsync(
            global::System.Guid agentId,
            global::System.Guid batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}