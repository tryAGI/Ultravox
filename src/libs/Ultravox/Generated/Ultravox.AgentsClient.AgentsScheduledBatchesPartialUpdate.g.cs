
#nullable enable

namespace Ultravox
{
    public partial class AgentsClient
    {
        partial void PrepareAgentsScheduledBatchesPartialUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid agentId,
            ref global::System.Guid batchId,
            global::Ultravox.PatchedScheduledCallBatch request);
        partial void PrepareAgentsScheduledBatchesPartialUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid agentId,
            global::System.Guid batchId,
            global::Ultravox.PatchedScheduledCallBatch request);
        partial void ProcessAgentsScheduledBatchesPartialUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAgentsScheduledBatchesPartialUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="batchId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ultravox.ScheduledCallBatch> AgentsScheduledBatchesPartialUpdateAsync(
            global::System.Guid agentId,
            global::System.Guid batchId,
            global::Ultravox.PatchedScheduledCallBatch request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAgentsScheduledBatchesPartialUpdateArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                batchId: ref batchId,
                request: request);

            var __pathBuilder = new global::Ultravox.PathBuilder(
                path: $"/api/agents/{agentId}/scheduled_batches/{batchId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAgentsScheduledBatchesPartialUpdateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                agentId: agentId,
                batchId: batchId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAgentsScheduledBatchesPartialUpdateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessAgentsScheduledBatchesPartialUpdateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Ultravox.ScheduledCallBatch.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Ultravox.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Ultravox.ScheduledCallBatch.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="batchId"></param>
        /// <param name="windowStart">
        /// The start of the time window during which calls can be made.
        /// </param>
        /// <param name="windowEnd">
        /// The end of the time window during which calls can be made.
        /// </param>
        /// <param name="webhookUrl">
        /// The URL to which a request will be made (synchronously) when a call in the batch is created, excluding those with an outgoing medium. Required if any call has a non-outgoing medium and not allowed otherwise.
        /// </param>
        /// <param name="webhookSecret">
        /// The signing secret for requests made to the webhookUrl. This is used to verify that the request came from Ultravox. If unset, an appropriate secret will be chosen for you (but you'll still need to make your endpoint aware of it to verify requests).
        /// </param>
        /// <param name="paused"></param>
        /// <param name="calls">
        /// Included only in requests
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ultravox.ScheduledCallBatch> AgentsScheduledBatchesPartialUpdateAsync(
            global::System.Guid agentId,
            global::System.Guid batchId,
            global::System.Collections.Generic.IList<global::Ultravox.ScheduledCall> calls,
            global::System.DateTime? windowStart = default,
            global::System.DateTime? windowEnd = default,
            string? webhookUrl = default,
            string? webhookSecret = default,
            bool? paused = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ultravox.PatchedScheduledCallBatch
            {
                WindowStart = windowStart,
                WindowEnd = windowEnd,
                WebhookUrl = webhookUrl,
                WebhookSecret = webhookSecret,
                Paused = paused,
                Calls = calls,
            };

            return await AgentsScheduledBatchesPartialUpdateAsync(
                agentId: agentId,
                batchId: batchId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}