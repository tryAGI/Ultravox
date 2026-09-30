#nullable enable

namespace Ultravox
{
    public partial interface IAudioClipsClient
    {
        /// <summary>
        /// Provides the audio clip's audio via a redirect to a short-lived download URL.
        /// </summary>
        /// <param name="audioClipId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task AudioClipsAudioRetrieveAsync(
            global::System.Guid audioClipId,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Provides the audio clip's audio via a redirect to a short-lived download URL.
        /// </summary>
        /// <param name="audioClipId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AutoSDKHttpResponse> AudioClipsAudioRetrieveAsResponseAsync(
            global::System.Guid audioClipId,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}