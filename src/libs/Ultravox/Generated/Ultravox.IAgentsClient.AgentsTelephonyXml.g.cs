#nullable enable

namespace Ultravox
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Allows supported telephony providers to create incoming calls with an agent, returning XML instructions for handling the call.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AgentsTelephonyXmlAsync(
            global::System.Guid agentId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Allows supported telephony providers to create incoming calls with an agent, returning XML instructions for handling the call.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AgentsTelephonyXmlAsync(
            global::System.Guid agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}