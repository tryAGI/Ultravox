#nullable enable

namespace Ultravox
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Fetch the (paginated) event log for a call, possibly filtered by severity.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="cursor"></param>
        /// <param name="minimumSeverity">
        /// Default Value: info
        /// </param>
        /// <param name="pageSize"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.PaginatedCallEventList> CallsEventsListAsync(
            global::System.Guid callId,
            string? cursor = default,
            global::Ultravox.CallsEventsListMinimumSeverity? minimumSeverity = default,
            int? pageSize = default,
            string? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}