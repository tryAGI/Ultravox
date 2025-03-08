#nullable enable

namespace Ultravox
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enableGreetingPrompt">
        /// Default Value: true
        /// </param>
        /// <param name="priorCallId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Call> CallsCreateAsync(
            global::Ultravox.AllOf<global::Ultravox.UltravoxV1StartCallRequest, global::Ultravox.CallsCreateRequest2> request,
            bool? enableGreetingPrompt = default,
            global::System.Guid? priorCallId = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="enableGreetingPrompt">
        /// Default Value: true
        /// </param>
        /// <param name="priorCallId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Call> CallsCreateAsync(
            bool? enableGreetingPrompt = default,
            global::System.Guid? priorCallId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}