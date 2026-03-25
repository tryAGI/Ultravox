#nullable enable

namespace Ultravox
{
    public partial interface IAccountsClient
    {
        /// <summary>
        /// Gets historical call concurrency for the account.
        /// </summary>
        /// <param name="bucket">
        /// Default Value: minute
        /// </param>
        /// <param name="end"></param>
        /// <param name="start"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.ConcurrencyResponse> AccountsMeUsageConcurrencyRetrieveAsync(
            global::Ultravox.AccountsMeUsageConcurrencyRetrieveBucket? bucket = default,
            global::System.DateTime? end = default,
            global::System.DateTime? start = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}