
#nullable enable

namespace Ultravox
{
    public partial class CallsClient
    {
        partial void PrepareCallsStagesMessagesAudioRetrieveArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid callId,
            ref global::System.Guid callStageId,
            ref int callStageMessageIndex);
        partial void PrepareCallsStagesMessagesAudioRetrieveRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid callId,
            global::System.Guid callStageId,
            int callStageMessageIndex);
        partial void ProcessCallsStagesMessagesAudioRetrieveResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="callStageId"></param>
        /// <param name="callStageMessageIndex"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        public async global::System.Threading.Tasks.Task CallsStagesMessagesAudioRetrieveAsync(
            global::System.Guid callId,
            global::System.Guid callStageId,
            int callStageMessageIndex,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCallsStagesMessagesAudioRetrieveArguments(
                httpClient: HttpClient,
                callId: ref callId,
                callStageId: ref callStageId,
                callStageMessageIndex: ref callStageMessageIndex);

            var __pathBuilder = new PathBuilder(
                path: $"/api/calls/{callId}/stages/{callStageId}/messages/{callStageMessageIndex}/audio",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCallsStagesMessagesAudioRetrieveRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                callId: callId,
                callStageId: callStageId,
                callStageMessageIndex: callStageMessageIndex);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCallsStagesMessagesAudioRetrieveResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::Ultravox.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }
    }
}