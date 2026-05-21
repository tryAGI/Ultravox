#nullable enable

namespace Ultravox
{
    public partial interface ICallThrottlesClient
    {
        /// <summary>
        /// Updates a call throttle (full replacement).
        /// </summary>
        /// <param name="throttleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.CallThrottle> CallThrottlesUpdateAsync(
            global::System.Guid throttleId,

            global::Ultravox.CallThrottle request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a call throttle (full replacement).
        /// </summary>
        /// <param name="throttleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AutoSDKHttpResponse<global::Ultravox.CallThrottle>> CallThrottlesUpdateAsResponseAsync(
            global::System.Guid throttleId,

            global::Ultravox.CallThrottle request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a call throttle (full replacement).
        /// </summary>
        /// <param name="throttleId"></param>
        /// <param name="name"></param>
        /// <param name="rules"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.CallThrottle> CallThrottlesUpdateAsync(
            global::System.Guid throttleId,
            string name,
            global::System.Collections.Generic.IList<global::Ultravox.CallThrottleRule> rules,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}