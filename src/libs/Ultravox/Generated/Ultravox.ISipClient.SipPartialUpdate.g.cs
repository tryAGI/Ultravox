#nullable enable

namespace Ultravox
{
    public partial interface ISipClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.SipConfig> SipPartialUpdateAsync(

            global::Ultravox.PatchedSipConfig request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AutoSDKHttpResponse<global::Ultravox.SipConfig>> SipPartialUpdateAsResponseAsync(

            global::Ultravox.PatchedSipConfig request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="allowedCidrRanges">
        /// The list of IPv4 CIDR ranges from which incoming SIP calls will be accepted.
        /// </param>
        /// <param name="allowAllAgents">
        /// If true, adds an implicit allowance for requests matching agent_&lt;agent_id&gt;@&lt;anydomain&gt; for any of your agents.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="allowedAgents">
        /// Calls must match a pattern for one of these agents (or the global agent pattern if allowAllAgents is true) to be accepted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.SipConfig> SipPartialUpdateAsync(
            global::System.Collections.Generic.IList<string>? allowedCidrRanges = default,
            bool? allowAllAgents = default,
            global::System.Collections.Generic.IList<global::Ultravox.AgentAllowance>? allowedAgents = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}