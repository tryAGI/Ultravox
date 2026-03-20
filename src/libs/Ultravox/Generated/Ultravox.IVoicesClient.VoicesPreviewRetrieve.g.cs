#nullable enable

namespace Ultravox
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Provides an audio sample for a voice, or the error caused by using it.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> VoicesPreviewRetrieveAsync(
            global::System.Guid voiceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}