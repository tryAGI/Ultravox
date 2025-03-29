#nullable enable

namespace Ultravox
{
    public partial interface IAccountsClient
    {
        /// <summary>
        /// Redirects to the billing portal for the current account.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task AccountsMeBillingSubscriptionRetrieveAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}