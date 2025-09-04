#nullable enable

namespace Ultravox
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Publish an agent revision.<br/>
        /// Sets a specific agent revision as the published version, which will be used for all subsequent calls to this agent.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="revisionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Agent> AgentsRevisionsPublishCreateAsync(
            global::System.Guid agentId,
            global::System.Guid revisionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}