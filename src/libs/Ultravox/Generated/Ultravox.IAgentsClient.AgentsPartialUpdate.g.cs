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
        global::System.Threading.Tasks.Task<global::Ultravox.Agent> AgentsPartialUpdateAsync(
            global::System.Guid agentId,
            global::Ultravox.PatchedAgent request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="name"></param>
        /// <param name="callTemplate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Agent> AgentsPartialUpdateAsync(
            global::System.Guid agentId,
            string? name = default,
            global::Ultravox.UltravoxV1CallTemplate? callTemplate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}