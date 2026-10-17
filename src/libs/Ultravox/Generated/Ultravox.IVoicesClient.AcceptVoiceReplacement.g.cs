#nullable enable

namespace Ultravox
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Switches one of your voices to its replacement (see `replacedBy`). The voice keeps its ID and name and takes on the replacement's definition, description and primary language. Anything using the replacement switches to this voice, and the replacement is deleted, though its ID and name still refer to this voice. Accepting a replacement that was already accepted returns the voice unchanged.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Voice> AcceptVoiceReplacementAsync(
            global::System.Guid voiceId,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Switches one of your voices to its replacement (see `replacedBy`). The voice keeps its ID and name and takes on the replacement's definition, description and primary language. Anything using the replacement switches to this voice, and the replacement is deleted, though its ID and name still refer to this voice. Accepting a replacement that was already accepted returns the voice unchanged.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AutoSDKHttpResponse<global::Ultravox.Voice>> AcceptVoiceReplacementAsResponseAsync(
            global::System.Guid voiceId,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}