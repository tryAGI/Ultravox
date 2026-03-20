#nullable enable

namespace Ultravox
{
    public partial interface IAccountsClient
    {
        /// <summary>
        /// Gets high-level billing information for the current account.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AccountBillingInfo> AccountsMeBillingRetrieveAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}