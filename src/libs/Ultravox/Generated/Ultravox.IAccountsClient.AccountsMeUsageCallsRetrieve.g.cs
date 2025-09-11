#nullable enable

namespace Ultravox
{
    public partial interface IAccountsClient
    {
        /// <summary>
        /// Gets aggregated call usage.
        /// </summary>
        /// <param name="agentIds"></param>
        /// <param name="durationMax"></param>
        /// <param name="durationMin"></param>
        /// <param name="fromDate"></param>
        /// <param name="metadata"></param>
        /// <param name="search"></param>
        /// <param name="toDate"></param>
        /// <param name="voiceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.CallUsage> AccountsMeUsageCallsRetrieveAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? agentIds = default,
            string? durationMax = default,
            string? durationMin = default,
            global::System.DateTime? fromDate = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? search = default,
            global::System.DateTime? toDate = default,
            global::System.Guid? voiceId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}