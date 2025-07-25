
#nullable enable

namespace Ultravox
{
    public partial class CorporaClient
    {
        partial void PrepareCorporaSourcesUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid corpusId,
            ref global::System.Guid sourceId,
            global::Ultravox.UltravoxV1CorpusSource request);
        partial void PrepareCorporaSourcesUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid corpusId,
            global::System.Guid sourceId,
            global::Ultravox.UltravoxV1CorpusSource request);
        partial void ProcessCorporaSourcesUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCorporaSourcesUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="sourceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ultravox.UltravoxV1CorpusSource> CorporaSourcesUpdateAsync(
            global::System.Guid corpusId,
            global::System.Guid sourceId,
            global::Ultravox.UltravoxV1CorpusSource request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCorporaSourcesUpdateArguments(
                httpClient: HttpClient,
                corpusId: ref corpusId,
                sourceId: ref sourceId,
                request: request);

            var __pathBuilder = new global::Ultravox.PathBuilder(
                path: $"/api/corpora/{corpusId}/sources/{sourceId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            PrepareCorporaSourcesUpdateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                corpusId: corpusId,
                sourceId: sourceId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCorporaSourcesUpdateResponse(
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
                ProcessCorporaSourcesUpdateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Ultravox.UltravoxV1CorpusSource.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Ultravox.UltravoxV1CorpusSource.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// <param name="corpusId"></param>
        /// <param name="sourceId"></param>
        /// <param name="requestCorpusId">
        /// The id of this source's corpus.
        /// </param>
        /// <param name="requestSourceId">
        /// The unique ID of this source.
        /// </param>
        /// <param name="created">
        /// When this source was created.
        /// </param>
        /// <param name="name">
        /// The name of this source.
        /// </param>
        /// <param name="description">
        /// A description of this source.
        /// </param>
        /// <param name="stats">
        /// The current stats for this source.
        /// </param>
        /// <param name="loadSpec">
        /// DEPRECATED. Prefer setting crawl instead. If either crawl or upload is set, this field will be ignored.
        /// </param>
        /// <param name="crawl">
        /// Allows loading documents by crawling the web.
        /// </param>
        /// <param name="upload">
        /// Allows loading from a uploaded document.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ultravox.UltravoxV1CorpusSource> CorporaSourcesUpdateAsync(
            global::System.Guid corpusId,
            global::System.Guid sourceId,
            string? requestCorpusId = default,
            string? requestSourceId = default,
            global::System.DateTime? created = default,
            string? name = default,
            string? description = default,
            global::Ultravox.UltravoxV1SourceStats? stats = default,
            global::Ultravox.UltravoxV1CrawlSpec? loadSpec = default,
            global::Ultravox.UltravoxV1CrawlSpec? crawl = default,
            global::Ultravox.UltravoxV1UploadSpec? upload = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ultravox.UltravoxV1CorpusSource
            {
                CorpusId = requestCorpusId,
                SourceId = requestSourceId,
                Created = created,
                Name = name,
                Description = description,
                Stats = stats,
                LoadSpec = loadSpec,
                Crawl = crawl,
                Upload = upload,
            };

            return await CorporaSourcesUpdateAsync(
                corpusId: corpusId,
                sourceId: sourceId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}