#nullable enable

namespace Ultravox
{
    public partial interface ITelephonyConfigsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.PlivoConfig> TelephonyConfigsPlivoCreateAsync(

            global::Ultravox.PlivoConfig request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AutoSDKHttpResponse<global::Ultravox.PlivoConfig>> TelephonyConfigsPlivoCreateAsResponseAsync(

            global::Ultravox.PlivoConfig request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="callCreationAllowedAgentIds">
        /// List of agents for whom calls may be directly created by this telephony provider to facilitate incoming calls. May not be set if callCreationAllowAllAgents is true.
        /// </param>
        /// <param name="callCreationAllowAllAgents">
        /// If true, calls may be directly created by this telephony provider for all agents. If false, only agents listed in callCreationAllowedAgentIds are allowed.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestContextMapping">
        /// Maps (dot separated) request fields to (dot separated) context fields for incoming call creation.
        /// </param>
        /// <param name="authId">
        /// Your Plivo Auth ID.
        /// </param>
        /// <param name="authToken">
        /// Your Plivo Auth Token.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.PlivoConfig> TelephonyConfigsPlivoCreateAsync(
            string authId,
            string authToken,
            global::System.Collections.Generic.IList<global::System.Guid>? callCreationAllowedAgentIds = default,
            bool? callCreationAllowAllAgents = default,
            global::System.Collections.Generic.Dictionary<string, string>? requestContextMapping = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}