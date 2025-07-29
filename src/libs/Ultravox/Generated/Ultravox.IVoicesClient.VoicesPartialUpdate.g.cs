#nullable enable

namespace Ultravox
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Voice> VoicesPartialUpdateAsync(
            global::System.Guid voiceId,
            global::Ultravox.PatchedVoice request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="voiceId"></param>
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
        global::System.Threading.Tasks.Task<global::Ultravox.Voice> VoicesPartialUpdateAsync(
            global::System.Guid voiceId,
            string? name = default,
            string? description = default,
            global::Ultravox.UltravoxV1ExternalVoice? definition = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}