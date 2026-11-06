#nullable enable

namespace Ultravox
{
    public partial interface ITriggersClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Trigger> TriggersCreateAsync(

            global::Ultravox.Trigger request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AutoSDKHttpResponse<global::Ultravox.Trigger>> TriggersCreateAsResponseAsync(

            global::Ultravox.Trigger request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="trigger1">
        /// A rule that sends data messages into a call when an event occurs and a condition is met.<br/>
        ///  Triggers run shortly after their events, in the order the events occur, so their actions<br/>
        ///  may interleave with other activity in the call. If one of its conditions can't be<br/>
        ///  evaluated, that run of the trigger stops, and a trigger whose runs fail three times in a<br/>
        ///  row is dropped for the rest of the call.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Trigger> TriggersCreateAsync(
            global::Ultravox.UltravoxV1Trigger trigger1,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}