#nullable enable

namespace Ultravox
{
    public partial interface IDeletedCallsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.CallTombstone> DeletedCallsRetrieveAsync(
            global::System.Guid callId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}