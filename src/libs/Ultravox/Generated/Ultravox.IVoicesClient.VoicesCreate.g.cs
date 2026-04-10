#nullable enable

namespace Ultravox
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Create a new cloned voice from an audio sample. The created voice will be private to your account.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.ultravox.ai/api/voices \<br/>
        /// --header 'Content-Type: multipart/form-data' \<br/>
        /// --header 'X-API-Key: &lt;your-api-key&gt;' \<br/>
        /// --form 'file=@/path/to/voice.mp3' \<br/>
        /// --form 'name=My Custom Voice' \<br/>
        /// --form 'description=Voice recorded on Jan 1, 2024'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Ultravox.Voice> VoicesCreateAsync(

            global::Ultravox.VoicesCreateRequest request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new cloned voice from an audio sample. The created voice will be private to your account.
        /// </summary>
        /// <param name="file">
        /// An audio file containing a sample of the voice to clone.
        /// </param>
        /// <param name="filename">
        /// An audio file containing a sample of the voice to clone.
        /// </param>
        /// <param name="name">
        /// Name for the cloned voice. Must be unique within your account.<br/>
        /// Example: My Custom Voice
        /// </param>
        /// <param name="description">
        /// Optional description for the voice. If not provided, a default description will be generated.<br/>
        /// Example: Voice recorded on Jan 1, 2024
        /// </param>
        /// <param name="language">
        /// BCP47 language code for the language used in the recording.<br/>
        /// Default Value: en<br/>
        /// Example: en-US
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Voice> VoicesCreateAsync(
            byte[] file,
            string filename,
            string name,
            string? description = default,
            string? language = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}