#nullable enable

namespace Ultravox
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task SendDataMessageToCallAsync(
            global::System.Guid callId,

            global::Ultravox.SendCallDataMessage request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="type">
        /// The type of the data message.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SendDataMessageToCallAsync(
            global::System.Guid callId,
            string type,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}