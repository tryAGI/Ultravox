#nullable enable

namespace Ultravox
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="throttle"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Call> AgentsCallsCreateAsync(
            global::System.Guid agentId,

            global::Ultravox.UltravoxV1StartAgentCallRequest request,
            string? throttle = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::Ultravox.Call> AgentsCallsCreateAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}