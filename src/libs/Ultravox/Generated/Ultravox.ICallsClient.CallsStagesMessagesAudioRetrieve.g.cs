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
        /// <param name="callStageMessageIndex"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task CallsStagesMessagesAudioRetrieveAsync(
            global::System.Guid callId,
            global::System.Guid callStageId,
            int callStageMessageIndex,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}