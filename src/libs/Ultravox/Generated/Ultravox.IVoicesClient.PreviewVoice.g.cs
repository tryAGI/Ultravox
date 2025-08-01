#nullable enable

namespace Ultravox
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Performs a test generation of a voice, returning the resulting audio or error.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> PreviewVoiceAsync(
            global::Ultravox.Voice request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Performs a test generation of a voice, returning the resulting audio or error.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="definition">
        /// A voice not known to Ultravox Realtime that can nonetheless be used for a call.<br/>
        ///  Such voices are significantly less validated than normal voices and you'll be<br/>
        ///  responsible for your own TTS-related errors.<br/>
        ///  Exactly one field must be set.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> PreviewVoiceAsync(
            string name,
            global::Ultravox.UltravoxV1ExternalVoice definition,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}