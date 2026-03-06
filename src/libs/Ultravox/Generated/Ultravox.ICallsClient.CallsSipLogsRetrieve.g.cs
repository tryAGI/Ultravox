#nullable enable

namespace Ultravox
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Redirects to sip logs for the call, if available.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task CallsSipLogsRetrieveAsync(
            global::System.Guid callId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}