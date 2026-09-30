#nullable enable

namespace Ultravox
{
    public partial interface IAudioClipsClient
    {
        /// <summary>
        /// Create a new audio clip from a WAV file. The created clip will be private to your account.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AudioClip> AudioClipsCreateAsync(

            global::Ultravox.AudioClipsCreateRequest request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new audio clip from a WAV file. The created clip will be private to your account.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AutoSDKHttpResponse<global::Ultravox.AudioClip>> AudioClipsCreateAsResponseAsync(

            global::Ultravox.AudioClipsCreateRequest request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new audio clip from a WAV file. The created clip will be private to your account.
        /// </summary>
        /// <param name="file">
        /// A mono 16-bit PCM WAV file with a sample rate between 16kHz and 48kHz containing at most 60 seconds of audio.
        /// </param>
        /// <param name="filename">
        /// A mono 16-bit PCM WAV file with a sample rate between 16kHz and 48kHz containing at most 60 seconds of audio.
        /// </param>
        /// <param name="name">
        /// Name for the audio clip. Must be unique within your account.<br/>
        /// Example: my_office
        /// </param>
        /// <param name="description">
        /// Optional description for the audio clip.<br/>
        /// Example: Background chatter recorded in our office
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AudioClip> AudioClipsCreateAsync(
            byte[] file,
            string filename,
            string name,
            string? description = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new audio clip from a WAV file. The created clip will be private to your account.
        /// </summary>
        /// <param name="file">
        /// A mono 16-bit PCM WAV file with a sample rate between 16kHz and 48kHz containing at most 60 seconds of audio.
        /// </param>
        /// <param name="filename">
        /// A mono 16-bit PCM WAV file with a sample rate between 16kHz and 48kHz containing at most 60 seconds of audio.
        /// </param>
        /// <param name="name">
        /// Name for the audio clip. Must be unique within your account.<br/>
        /// Example: my_office
        /// </param>
        /// <param name="description">
        /// Optional description for the audio clip.<br/>
        /// Example: Background chatter recorded in our office
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AudioClip> AudioClipsCreateAsync(
            global::System.IO.Stream file,
            string filename,
            string name,
            string? description = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new audio clip from a WAV file. The created clip will be private to your account.
        /// </summary>
        /// <param name="file">
        /// A mono 16-bit PCM WAV file with a sample rate between 16kHz and 48kHz containing at most 60 seconds of audio.
        /// </param>
        /// <param name="filename">
        /// A mono 16-bit PCM WAV file with a sample rate between 16kHz and 48kHz containing at most 60 seconds of audio.
        /// </param>
        /// <param name="name">
        /// Name for the audio clip. Must be unique within your account.<br/>
        /// Example: my_office
        /// </param>
        /// <param name="description">
        /// Optional description for the audio clip.<br/>
        /// Example: Background chatter recorded in our office
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AutoSDKHttpResponse<global::Ultravox.AudioClip>> AudioClipsCreateAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            string name,
            string? description = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}