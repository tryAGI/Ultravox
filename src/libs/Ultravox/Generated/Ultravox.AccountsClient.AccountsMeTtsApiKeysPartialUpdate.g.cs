
#nullable enable

namespace Ultravox
{
    public partial class AccountsClient
    {
        partial void PrepareAccountsMeTtsApiKeysPartialUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Ultravox.PatchedSetTtsApiKeysRequest request);
        partial void PrepareAccountsMeTtsApiKeysPartialUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Ultravox.PatchedSetTtsApiKeysRequest request);
        partial void ProcessAccountsMeTtsApiKeysPartialUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAccountsMeTtsApiKeysPartialUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ultravox.AccountTtsKeys> AccountsMeTtsApiKeysPartialUpdateAsync(
            global::Ultravox.PatchedSetTtsApiKeysRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAccountsMeTtsApiKeysPartialUpdateArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Ultravox.PathBuilder(
                path: "/api/accounts/me/tts_api_keys",
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
            PrepareAccountsMeTtsApiKeysPartialUpdateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAccountsMeTtsApiKeysPartialUpdateResponse(
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
                ProcessAccountsMeTtsApiKeysPartialUpdateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Ultravox.AccountTtsKeys.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Ultravox.AccountTtsKeys.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// <param name="elevenLabs">
        /// Your ElevenLabs API key.<br/>
        /// https://elevenlabs.io/app/settings/api-keys
        /// </param>
        /// <param name="cartesia">
        /// Your Cartesia API key.<br/>
        /// https://play.cartesia.ai/keys
        /// </param>
        /// <param name="playHt">
        /// Your PlayHT API key.<br/>
        /// Note: This must come from play.ht, not play.ai. Their users are NOT interchangeable!<br/>
        /// https://play.ht/studio/api-access
        /// </param>
        /// <param name="lmnt">
        /// Your LMNT API key.<br/>
        /// https://app.lmnt.com/account#api-keys
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ultravox.AccountTtsKeys> AccountsMeTtsApiKeysPartialUpdateAsync(
            string? elevenLabs = default,
            string? cartesia = default,
            string? playHt = default,
            string? lmnt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ultravox.PatchedSetTtsApiKeysRequest
            {
                ElevenLabs = elevenLabs,
                Cartesia = cartesia,
                PlayHt = playHt,
                Lmnt = lmnt,
            };

            return await AccountsMeTtsApiKeysPartialUpdateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}