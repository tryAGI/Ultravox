
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A request to start a call.
    /// </summary>
    public sealed partial class UltravoxV1StartCallRequest
    {
        /// <summary>
        /// The system prompt provided to the model during generations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// The model temperature, between 0 and 1. Defaults to 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// The model used for generations. Defaults to fixie-ai/ultravox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The ID (or name if unique) of the voice the agent should use for this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// A BCP47 language code that may be used to guide speech recognition and synthesis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageHint")]
        public string? LanguageHint { get; set; }

        /// <summary>
        /// The conversation history to start from for this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initialMessages")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Message>? InitialMessages { get; set; }

        /// <summary>
        /// A timeout for joining the call. Defaults to 5 minutes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joinTimeout")]
        public string? JoinTimeout { get; set; }

        /// <summary>
        /// The maximum duration of the call. Defaults to 1 hour.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDuration")]
        public string? MaxDuration { get; set; }

        /// <summary>
        /// What the agent should say immediately before hanging up if the call's time limit is reached.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeExceededMessage")]
        public string? TimeExceededMessage { get; set; }

        /// <summary>
        /// Messages spoken by the agent when the user is inactive for the specified duration.<br/>
        ///  Durations are cumulative, so a message m &gt; 1 with duration 30s will be spoken 30 seconds after message m-1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivityMessages")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TimedMessage>? InactivityMessages { get; set; }

        /// <summary>
        /// The tools available to the agent for (the first stage of) this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selectedTools")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SelectedTool>? SelectedTools { get; set; }

        /// <summary>
        /// The medium used for this call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium")]
        public global::Ultravox.UltravoxV1CallMedium? Medium { get; set; }

        /// <summary>
        /// Who was responsible for staring this call. Typically set to agent for outgoing calls and left as the default (user) otherwise.<br/>
        ///  DEPRECATED: Use first_speaker instead. Will be removed in November 2024.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initiator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.UltravoxV1StartCallRequestInitiatorJsonConverter))]
        public global::Ultravox.UltravoxV1StartCallRequestInitiator? Initiator { get; set; }

        /// <summary>
        /// Whether the call should be recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingEnabled")]
        public bool? RecordingEnabled { get; set; }

        /// <summary>
        /// Who should talk first when the call starts. Typically set to FIRST_SPEAKER_USER for outgoing<br/>
        ///  calls and left as the default (FIRST_SPEAKER_AGENT) otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstSpeaker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.UltravoxV1StartCallRequestFirstSpeakerJsonConverter))]
        public global::Ultravox.UltravoxV1StartCallRequestFirstSpeaker? FirstSpeaker { get; set; }

        /// <summary>
        /// Indicates whether a transcript is optional for the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptOptional")]
        public bool? TranscriptOptional { get; set; }

        /// <summary>
        /// The medium to use for the call initially. May be altered by the client later.<br/>
        ///  Defaults to voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initialOutputMedium")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.UltravoxV1StartCallRequestInitialOutputMediumJsonConverter))]
        public global::Ultravox.UltravoxV1StartCallRequestInitialOutputMedium? InitialOutputMedium { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1StartCallRequest" /> class.
        /// </summary>
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1StartCallRequest(
            string? systemPrompt,
            float? temperature,
            string? model,
            string? voice,
            string? languageHint,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Message>? initialMessages,
            string? joinTimeout,
            string? maxDuration,
            string? timeExceededMessage,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TimedMessage>? inactivityMessages,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SelectedTool>? selectedTools,
            global::Ultravox.UltravoxV1CallMedium? medium,
            global::Ultravox.UltravoxV1StartCallRequestInitiator? initiator,
            bool? recordingEnabled,
            global::Ultravox.UltravoxV1StartCallRequestFirstSpeaker? firstSpeaker,
            bool? transcriptOptional,
            global::Ultravox.UltravoxV1StartCallRequestInitialOutputMedium? initialOutputMedium)
        {
            this.SystemPrompt = systemPrompt;
            this.Temperature = temperature;
            this.Model = model;
            this.Voice = voice;
            this.LanguageHint = languageHint;
            this.InitialMessages = initialMessages;
            this.JoinTimeout = joinTimeout;
            this.MaxDuration = maxDuration;
            this.TimeExceededMessage = timeExceededMessage;
            this.InactivityMessages = inactivityMessages;
            this.SelectedTools = selectedTools;
            this.Medium = medium;
            this.Initiator = initiator;
            this.RecordingEnabled = recordingEnabled;
            this.FirstSpeaker = firstSpeaker;
            this.TranscriptOptional = transcriptOptional;
            this.InitialOutputMedium = initialOutputMedium;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1StartCallRequest" /> class.
        /// </summary>
        public UltravoxV1StartCallRequest()
        {
        }
    }
}