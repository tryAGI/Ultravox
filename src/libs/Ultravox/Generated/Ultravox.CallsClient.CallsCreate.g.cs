
#nullable enable

namespace Ultravox
{
    public partial class CallsClient
    {
        partial void PrepareCallsCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid? priorCallId,
            global::Ultravox.UltravoxV1StartCallRequest request);
        partial void PrepareCallsCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid? priorCallId,
            global::Ultravox.UltravoxV1StartCallRequest request);
        partial void ProcessCallsCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCallsCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="priorCallId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ultravox.Call> CallsCreateAsync(
            global::Ultravox.UltravoxV1StartCallRequest request,
            global::System.Guid? priorCallId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCallsCreateArguments(
                httpClient: HttpClient,
                priorCallId: ref priorCallId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/calls",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("priorCallId", priorCallId?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareCallsCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                priorCallId: priorCallId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCallsCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCallsCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::Ultravox.Call.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
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

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::Ultravox.Call.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="priorCallId"></param>
        /// <param name="systemPrompt">
        /// The system prompt provided to the model during generations.
        /// </param>
        /// <param name="temperature">
        /// The model temperature, between 0 and 1. Defaults to 0.
        /// </param>
        /// <param name="model">
        /// The model used for generations. Defaults to fixie-ai/ultravox.
        /// </param>
        /// <param name="voice">
        /// The ID (or name if unique) of the voice the agent should use for this call.
        /// </param>
        /// <param name="languageHint">
        /// A BCP47 language code that may be used to guide speech recognition and synthesis.
        /// </param>
        /// <param name="initialMessages">
        /// The conversation history to start from for this call.
        /// </param>
        /// <param name="joinTimeout">
        /// A timeout for joining the call. Defaults to 5 minutes.
        /// </param>
        /// <param name="maxDuration">
        /// The maximum duration of the call. Defaults to 1 hour.
        /// </param>
        /// <param name="timeExceededMessage">
        /// What the agent should say immediately before hanging up if the call's time limit is reached.
        /// </param>
        /// <param name="inactivityMessages">
        /// Messages spoken by the agent when the user is inactive for the specified duration.<br/>
        ///  Durations are cumulative, so a message m &gt; 1 with duration 30s will be spoken 30 seconds after message m-1.
        /// </param>
        /// <param name="selectedTools">
        /// The tools available to the agent for (the first stage of) this call.
        /// </param>
        /// <param name="medium">
        /// The medium used for this call.
        /// </param>
        /// <param name="initiator">
        /// Who was responsible for staring this call. Typically set to agent for outgoing calls and left as the default (user) otherwise.<br/>
        ///  DEPRECATED: Use first_speaker instead. Will be removed in November 2024.
        /// </param>
        /// <param name="recordingEnabled">
        /// Whether the call should be recorded.
        /// </param>
        /// <param name="firstSpeaker">
        /// Who should talk first when the call starts. Typically set to FIRST_SPEAKER_USER for outgoing<br/>
        ///  calls and left as the default (FIRST_SPEAKER_AGENT) otherwise.
        /// </param>
        /// <param name="transcriptOptional">
        /// Indicates whether a transcript is optional for the call.
        /// </param>
        /// <param name="initialOutputMedium">
        /// The medium to use for the call initially. May be altered by the client later.<br/>
        ///  Defaults to voice.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Ultravox.Call> CallsCreateAsync(
            global::System.Guid? priorCallId = default,
            string? systemPrompt = default,
            float? temperature = default,
            string? model = default,
            string? voice = default,
            string? languageHint = default,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Message>? initialMessages = default,
            string? joinTimeout = default,
            string? maxDuration = default,
            string? timeExceededMessage = default,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TimedMessage>? inactivityMessages = default,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SelectedTool>? selectedTools = default,
            global::Ultravox.UltravoxV1CallMedium? medium = default,
            global::Ultravox.UltravoxV1StartCallRequestInitiator? initiator = default,
            bool? recordingEnabled = default,
            global::Ultravox.UltravoxV1StartCallRequestFirstSpeaker? firstSpeaker = default,
            bool? transcriptOptional = default,
            global::Ultravox.UltravoxV1StartCallRequestInitialOutputMedium? initialOutputMedium = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Ultravox.UltravoxV1StartCallRequest
            {
                SystemPrompt = systemPrompt,
                Temperature = temperature,
                Model = model,
                Voice = voice,
                LanguageHint = languageHint,
                InitialMessages = initialMessages,
                JoinTimeout = joinTimeout,
                MaxDuration = maxDuration,
                TimeExceededMessage = timeExceededMessage,
                InactivityMessages = inactivityMessages,
                SelectedTools = selectedTools,
                Medium = medium,
                Initiator = initiator,
                RecordingEnabled = recordingEnabled,
                FirstSpeaker = firstSpeaker,
                TranscriptOptional = transcriptOptional,
                InitialOutputMedium = initialOutputMedium,
            };

            return await CallsCreateAsync(
                priorCallId: priorCallId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}