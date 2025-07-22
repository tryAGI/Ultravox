#nullable enable

namespace Ultravox
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="cursor"></param>
        /// <param name="mode">
        /// Default Value: last_stage
        /// </param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.PaginatedultravoxV1MessageList> CallsMessagesListAsync(
            global::System.Guid callId,
            string? cursor = default,
            global::Ultravox.CallsMessagesListMode? mode = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}