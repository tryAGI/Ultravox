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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AgentRevision> AgentsRevisionsCreateAsync(
            global::System.Guid agentId,
            global::Ultravox.AgentRevision request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="callTemplate">
        /// A CallTemplate that can be used to create Ultravox calls with shared properties.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AgentRevision> AgentsRevisionsCreateAsync(
            global::System.Guid agentId,
            global::Ultravox.UltravoxV1CallTemplate callTemplate,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}