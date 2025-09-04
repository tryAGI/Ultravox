#nullable enable

namespace Ultravox
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Get agent revision details.<br/>
        /// Retrieve detailed information about a specific agent revision.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="revisionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AgentRevision> AgentsRevisionsRetrieveAsync(
            global::System.Guid agentId,
            global::System.Guid revisionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}