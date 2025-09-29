#nullable enable

namespace Ultravox
{
    public partial interface IAccountsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AccountTelephonyConfigOutput> AccountsMeTelephonyConfigRetrieveAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}