#nullable enable

namespace Ultravox
{
    public partial interface ITelephonyConfigsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.TelnyxConfig> TelephonyConfigsTelnyxCreateAsync(

            global::Ultravox.TelnyxConfig request,
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
        /// <param name="accountSid">
        /// Your Telnyx Account SID. See https://portal.telnyx.com/#/account/general
        /// </param>
        /// <param name="apiKey">
        /// Your Telnyx API Key. See https://portal.telnyx.com/#/api-keys<br/>
        /// Included only in requests
        /// </param>
        /// <param name="publicKey">
        /// Your Telnyx Public Key. See https://portal.telnyx.com/#/api-keys/public-key<br/>
        /// Included only in requests
        /// </param>
        /// <param name="applicationSid">
        /// Your Telnyx Application SID. This must be configured with an Outbound Voice Profile that allows calls to your destination. See https://portal.telnyx.com/#/call-control/texml
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.TelnyxConfig> TelephonyConfigsTelnyxCreateAsync(
            string accountSid,
            string apiKey,
            string publicKey,
            string applicationSid,
            global::System.Collections.Generic.IList<global::System.Guid>? callCreationAllowedAgentIds = default,
            bool? callCreationAllowAllAgents = default,
            global::System.Collections.Generic.Dictionary<string, string>? requestContextMapping = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}