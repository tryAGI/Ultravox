
#nullable enable

namespace Ultravox
{
    public partial class VoicesClient
    {
        partial void PrepareVoicesListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Ultravox.VoicesListBillingStyle? billingStyle,
            ref string? cursor,
            ref global::Ultravox.VoicesListOwnership? ownership,
            ref int? pageSize,
            ref string? primaryLanguage,
            ref string? search);
        partial void PrepareVoicesListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Ultravox.VoicesListBillingStyle? billingStyle,
            string? cursor,
            global::Ultravox.VoicesListOwnership? ownership,
            int? pageSize,
            string? primaryLanguage,
            string? search);
        partial void ProcessVoicesListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessVoicesListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List all voices in your account.
        /// </summary>
        /// <param name="billingStyle"></param>
        /// <param name="cursor"></param>
        /// <param name="ownership"></param>
        /// <param name="pageSize"></param>
        /// <param name="primaryLanguage"></param>
        /// <param name="search"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ultravox.PaginatedVoiceList> VoicesListAsync(
            global::Ultravox.VoicesListBillingStyle? billingStyle = default,
            string? cursor = default,
            global::Ultravox.VoicesListOwnership? ownership = default,
            int? pageSize = default,
            string? primaryLanguage = default,
            string? search = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareVoicesListArguments(
                httpClient: HttpClient,
                billingStyle: ref billingStyle,
                cursor: ref cursor,
                ownership: ref ownership,
                pageSize: ref pageSize,
                primaryLanguage: ref primaryLanguage,
                search: ref search);

            var __pathBuilder = new global::Ultravox.PathBuilder(
                path: "/api/voices",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("billingStyle", billingStyle?.ToValueString()) 
                .AddOptionalParameter("cursor", cursor) 
                .AddOptionalParameter("ownership", ownership?.ToValueString()) 
                .AddOptionalParameter("pageSize", pageSize?.ToString()) 
                .AddOptionalParameter("primaryLanguage", primaryLanguage) 
                .AddOptionalParameter("search", search) 
                ; 
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
            PrepareVoicesListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                billingStyle: billingStyle,
                cursor: cursor,
                ownership: ownership,
                pageSize: pageSize,
                primaryLanguage: primaryLanguage,
                search: search);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessVoicesListResponse(
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
                ProcessVoicesListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Ultravox.PaginatedVoiceList.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Ultravox.PaginatedVoiceList.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
    }
}