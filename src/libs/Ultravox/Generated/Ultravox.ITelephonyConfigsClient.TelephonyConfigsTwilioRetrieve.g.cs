#nullable enable

namespace Ultravox
{
    public partial interface ITelephonyConfigsClient
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.TwilioConfig> TelephonyConfigsTwilioRetrieveAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}