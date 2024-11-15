#nullable enable

namespace Ultravox
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callStageId"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.PaginatedultravoxV1MessageList> CallsStagesMessagesListAsync(
            global::System.Guid callId,
            global::System.Guid callStageId,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}