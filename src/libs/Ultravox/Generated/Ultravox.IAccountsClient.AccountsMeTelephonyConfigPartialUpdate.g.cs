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
        global::System.Threading.Tasks.Task<global::Ultravox.AccountTelephonyConfigOutput> AccountsMeTelephonyConfigPartialUpdateAsync(
            global::Ultravox.PatchedAccountTelephonyConfig request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="twilio">
        /// Your Twilio configuration. See https://console.twilio.com/
        /// </param>
        /// <param name="telnyx">
        /// Your Telnyx configuration. See https://portal.telnyx.com/
        /// </param>
        /// <param name="plivo">
        /// Your Plivo configuration. See https://console.plivo.com/dashboard/
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AccountTelephonyConfigOutput> AccountsMeTelephonyConfigPartialUpdateAsync(
            global::Ultravox.TwilioConfig? twilio = default,
            global::Ultravox.TelnyxConfig? telnyx = default,
            global::Ultravox.PlivoConfig? plivo = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}