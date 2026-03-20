#nullable enable

namespace Ultravox
{
    public partial interface IAccountsClient
    {
        /// <summary>
        /// Gets usage information for the current account in the given period.
        /// </summary>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.UsageResponse> AccountsMeBillingUsageRetrieveAsync(
            global::System.DateTime? fromDate = default,
            global::System.DateTime? toDate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}