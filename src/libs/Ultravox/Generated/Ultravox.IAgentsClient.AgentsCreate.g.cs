#nullable enable

namespace Ultravox
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Agent> AgentsCreateAsync(
            global::Ultravox.Agent request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callTemplate">
        /// A CallTemplate that can be used to create Ultravox calls with shared properties.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Agent> AgentsCreateAsync(
            string name,
            global::Ultravox.UltravoxV1CallTemplate? callTemplate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}