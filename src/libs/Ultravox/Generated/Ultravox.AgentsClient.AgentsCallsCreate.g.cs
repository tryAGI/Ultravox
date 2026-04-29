
#nullable enable

namespace Ultravox
{
    public partial class AgentsClient
    {


        private static readonly global::Ultravox.EndPointSecurityRequirement s_AgentsCallsCreateSecurityRequirement0 =
            new global::Ultravox.EndPointSecurityRequirement
            {
                Authorizations = new global::Ultravox.EndPointAuthorizationRequirement[]
                {                    new global::Ultravox.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyXApiKey",
                        Location = "Header",
                        Name = "X-API-Key",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::Ultravox.EndPointSecurityRequirement[] s_AgentsCallsCreateSecurityRequirements =
            new global::Ultravox.EndPointSecurityRequirement[]
            {                s_AgentsCallsCreateSecurityRequirement0,
            };
        partial void PrepareAgentsCallsCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid agentId,
            ref string? throttle,
            global::Ultravox.UltravoxV1StartAgentCallRequest request);
        partial void PrepareAgentsCallsCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid agentId,
            string? throttle,
            global::Ultravox.UltravoxV1StartAgentCallRequest request);
        partial void ProcessAgentsCallsCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAgentsCallsCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="throttle"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ultravox.Call> AgentsCallsCreateAsync(
            global::System.Guid agentId,

            global::Ultravox.UltravoxV1StartAgentCallRequest request,
            string? throttle = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAgentsCallsCreateArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                throttle: ref throttle,
                request: request);


            var __authorizations = global::Ultravox.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AgentsCallsCreateSecurityRequirements,
                operationName: "AgentsCallsCreateAsync");

            using var __timeoutCancellationTokenSource = global::Ultravox.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Ultravox.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Ultravox.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::Ultravox.PathBuilder(
                                path: $"/api/agents/{agentId}/calls",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("throttle", throttle) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Ultravox.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::Ultravox.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareAgentsCallsCreateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    agentId: agentId!,
                    throttle: throttle,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Ultravox.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Ultravox.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AgentsCallsCreate",
                                methodName: "AgentsCallsCreateAsync",
                                pathTemplate: "$\"/api/agents/{agentId}/calls\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Ultravox.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Ultravox.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AgentsCallsCreate",
                                methodName: "AgentsCallsCreateAsync",
                                pathTemplate: "$\"/api/agents/{agentId}/calls\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Ultravox.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Ultravox.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Ultravox.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Ultravox.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AgentsCallsCreate",
                                methodName: "AgentsCallsCreateAsync",
                                pathTemplate: "$\"/api/agents/{agentId}/calls\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Ultravox.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessAgentsCallsCreateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Ultravox.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Ultravox.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AgentsCallsCreate",
                                methodName: "AgentsCallsCreateAsync",
                                pathTemplate: "$\"/api/agents/{agentId}/calls\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Ultravox.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Ultravox.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AgentsCallsCreate",
                                methodName: "AgentsCallsCreateAsync",
                                pathTemplate: "$\"/api/agents/{agentId}/calls\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessAgentsCallsCreateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Ultravox.Call.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Ultravox.Call.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

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

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="throttle"></param>
        /// <param name="templateContext">
        /// Context for filling any mustache templates for the call.
        /// </param>
        /// <param name="initialMessages">
        /// The conversation history to start from for this call.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs to associate with the call. All values must be strings.<br/>
        ///  Keys may not start with "ultravox.", which is reserved for system-provided metadata.
        /// </param>
        /// <param name="medium">
        /// The (overridden) medium used for this call.
        /// </param>
        /// <param name="joinTimeout">
        /// The (overridden) timeout for joining this call.
        /// </param>
        /// <param name="maxDuration">
        /// The (overridden) maximum duration of this call.
        /// </param>
        /// <param name="recordingEnabled">
        /// The (overridden) setting for whether the call should be recorded.
        /// </param>
        /// <param name="initialOutputMedium">
        /// The (overridden) medium initially used by the agent. May be altered by the client later.
        /// </param>
        /// <param name="firstSpeakerSettings">
        /// The (overridden) settings for the initial message to get a conversation started.<br/>
        ///  Defaults to `agent: {}` which means the agent will start the conversation with an<br/>
        ///  (interruptible) greeting generated based on the system prompt and any initial messages.<br/>
        ///  (If first_speaker is set and this is not, first_speaker will be used instead.)
        /// </param>
        /// <param name="dataConnection">
        /// The (overridden) data connection configuration.
        /// </param>
        /// <param name="experimentalSettings">
        /// Experimental settings for the call.
        /// </param>
        /// <param name="callbacks">
        /// Callbacks for call lifecycle events.
        /// </param>
        /// <param name="voice">
        /// The name or ID of the voice the agent should be forced to use. Typically this is set<br/>
        ///  in the agent's CallTemplate and omitted here. Setting here may be useful for scenarios<br/>
        ///  where your agent uses different voices for different calls.
        /// </param>
        /// <param name="voiceOverrides">
        /// Overrides for the agent's forced voice. Only valid when `voice` is set explicitly<br/>
        ///  in this request. Typically the agent's voice and any relevant overrides should be<br/>
        ///  set on the agent's CallTemplate instead.
        /// </param>
        /// <param name="toolOverrides">
        /// Overrides for the agent's tool set. Allows adding or removing tools,<br/>
        ///  optionally replacing the entire tool list. Removals are applied before<br/>
        ///  additions.
        /// </param>
        /// <param name="retentionPolicy">
        /// The (overridden) retention policy for the call's data after it ends.
        /// </param>
        /// <param name="sharedSecrets">
        /// Shared secrets used to sign outbound requests (e.g. data connection websocket).<br/>
        ///  When set, X-Ultravox-Call-ID, X-Ultravox-Signature-Timestamp, and<br/>
        ///  X-Ultravox-Signature headers will be included. If multiple secrets are provided,<br/>
        ///  one signature per secret is produced (comma-separated in X-Ultravox-Signature).<br/>
        ///  Write-only: this field is never included in API responses.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ultravox.Call> AgentsCallsCreateAsync(
            global::System.Guid agentId,
            string? throttle = default,
            object? templateContext = default,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Message>? initialMessages = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Ultravox.UltravoxV1CallMedium? medium = default,
            string? joinTimeout = default,
            string? maxDuration = default,
            bool? recordingEnabled = default,
            global::Ultravox.UltravoxV1StartAgentCallRequestInitialOutputMedium? initialOutputMedium = default,
            global::Ultravox.UltravoxV1FirstSpeakerSettings? firstSpeakerSettings = default,
            global::Ultravox.UltravoxV1DataConnectionConfig? dataConnection = default,
            object? experimentalSettings = default,
            global::Ultravox.UltravoxV1Callbacks? callbacks = default,
            string? voice = default,
            global::Ultravox.UltravoxV1ExternalVoice? voiceOverrides = default,
            global::Ultravox.UltravoxV1ToolOverrides? toolOverrides = default,
            global::Ultravox.UltravoxV1StartAgentCallRequestRetentionPolicy? retentionPolicy = default,
            global::System.Collections.Generic.IList<string>? sharedSecrets = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ultravox.UltravoxV1StartAgentCallRequest
            {
                TemplateContext = templateContext,
                InitialMessages = initialMessages,
                Metadata = metadata,
                Medium = medium,
                JoinTimeout = joinTimeout,
                MaxDuration = maxDuration,
                RecordingEnabled = recordingEnabled,
                InitialOutputMedium = initialOutputMedium,
                FirstSpeakerSettings = firstSpeakerSettings,
                DataConnection = dataConnection,
                ExperimentalSettings = experimentalSettings,
                Callbacks = callbacks,
                Voice = voice,
                VoiceOverrides = voiceOverrides,
                ToolOverrides = toolOverrides,
                RetentionPolicy = retentionPolicy,
                SharedSecrets = sharedSecrets,
            };

            return await AgentsCallsCreateAsync(
                agentId: agentId,
                throttle: throttle,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}