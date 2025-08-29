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
        global::System.Threading.Tasks.Task<global::Ultravox.AccountTelephonyKeys> AccountsMeTelephonyApiKeysPartialUpdateAsync(
            global::Ultravox.PatchedSetTelephonyApiKeysRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="telnyx">
        /// Your Telnyx API key.<br/>
        /// https://portal.telnyx.com/#/api-keys
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AccountTelephonyKeys> AccountsMeTelephonyApiKeysPartialUpdateAsync(
            string? telnyx = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}