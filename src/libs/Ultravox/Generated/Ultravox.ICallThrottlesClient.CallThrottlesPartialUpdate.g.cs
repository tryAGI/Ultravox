#nullable enable

namespace Ultravox
{
    public partial interface ICallThrottlesClient
    {
        /// <summary>
        /// Partially updates a call throttle.
        /// </summary>
        /// <param name="throttleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.CallThrottle> CallThrottlesPartialUpdateAsync(
            global::System.Guid throttleId,

            global::Ultravox.PatchedCallThrottle request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Partially updates a call throttle.
        /// </summary>
        /// <param name="throttleId"></param>
        /// <param name="name"></param>
        /// <param name="rules"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.CallThrottle> CallThrottlesPartialUpdateAsync(
            global::System.Guid throttleId,
            string? name = default,
            global::System.Collections.Generic.IList<global::Ultravox.CallThrottleRule>? rules = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}