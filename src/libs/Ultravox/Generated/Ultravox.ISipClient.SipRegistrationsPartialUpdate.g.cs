#nullable enable

namespace Ultravox
{
    public partial interface ISipClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="registrationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.SipRegistration> SipRegistrationsPartialUpdateAsync(
            string registrationId,

            global::Ultravox.PatchedSipRegistration request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="registrationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AutoSDKHttpResponse<global::Ultravox.SipRegistration>> SipRegistrationsPartialUpdateAsResponseAsync(
            string registrationId,

            global::Ultravox.PatchedSipRegistration request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="registrationId"></param>
        /// <param name="username">
        /// The SIP username to register as.
        /// </param>
        /// <param name="password">
        /// The SIP password for username.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="proxy">
        /// The SIP server to register with.
        /// </param>
        /// <param name="outboundProxy">
        /// A proxy used to reach your SIP server for registration. Most often unset, but may be used if you need to register as `alice@trunk.com` using `proxy.trunk.com` for example.
        /// </param>
        /// <param name="authUser">
        /// The authentication username, if different from the SIP username. Most often unset.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.SipRegistration> SipRegistrationsPartialUpdateAsync(
            string registrationId,
            string password,
            string? username = default,
            string? proxy = default,
            string? outboundProxy = default,
            string? authUser = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}