#nullable enable

namespace Ultravox
{
    public partial interface IAccountsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AccountTtsKeys> AccountsMeTtsApiKeysPartialUpdateAsync(

            global::Ultravox.PatchedSetTtsApiKeysRequest request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="elevenLabs">
        /// Your ElevenLabs API key.<br/>
        /// https://elevenlabs.io/app/settings/api-keys
        /// </param>
        /// <param name="cartesia">
        /// Your Cartesia API key.<br/>
        /// https://play.cartesia.ai/keys
        /// </param>
        /// <param name="lmnt">
        /// Your LMNT API key.<br/>
        /// https://app.lmnt.com/account#api-keys
        /// </param>
        /// <param name="google">
        /// A service account JSON key for your Google Cloud project with the Text-to-Speech API enabled.<br/>
        /// https://cloud.google.com/text-to-speech/docs/quickstart-client-libraries#before-you-begin<br/>
        /// https://cloud.google.com/iam/docs/keys-create-delete#creating
        /// </param>
        /// <param name="inworld">
        /// Your Inworld API key.<br/>
        /// https://platform.inworld.ai/login
        /// </param>
        /// <param name="respeecher">
        /// Your Respeecher API key.<br/>
        /// https://space.respeecher.com/api-keys
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AccountTtsKeys> AccountsMeTtsApiKeysPartialUpdateAsync(
            string? elevenLabs = default,
            string? cartesia = default,
            string? lmnt = default,
            string? google = default,
            string? inworld = default,
            string? respeecher = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}