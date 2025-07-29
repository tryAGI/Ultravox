#nullable enable

namespace Ultravox
{
    public partial interface IAccountsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AccountTtsKeys> AccountsMeTtsApiKeysPartialUpdateAsync(
            global::Ultravox.PatchedSetTtsApiKeysRequest request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AccountTtsKeys> AccountsMeTtsApiKeysPartialUpdateAsync(
            string? elevenLabs = default,
            string? cartesia = default,
            string? lmnt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}