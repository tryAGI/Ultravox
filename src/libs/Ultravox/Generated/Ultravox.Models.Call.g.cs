
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Call
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("callId")]
        public global::System.Guid CallId { get; set; } = default!;

        /// <summary>
        /// The version of the client that joined this call.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientVersion")]
        public string? ClientVersion { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime Created { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended")]
        public global::System.DateTime? Ended { get; set; }

        /// <summary>
        /// The reason the call ended.<br/>
        /// * `unjoined` - Client never joined<br/>
        /// * `hangup` - Client hung up<br/>
        /// * `timeout` - Call timed out<br/>
        /// * `connection_error` - Connection error<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.OneOfJsonConverter<global::Ultravox.EndReasonEnum?, global::Ultravox.NullEnum?>))]
        public global::Ultravox.OneOf<global::Ultravox.EndReasonEnum?, global::Ultravox.NullEnum?>? EndReason { get; set; }

        /// <summary>
        /// Who was supposed to talk first when the call started. Typically set to FIRST_SPEAKER_USER for outgoing calls and left as the default (FIRST_SPEAKER_AGENT) otherwise.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstSpeaker")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.FirstSpeakerEnumJsonConverter))]
        public global::Ultravox.FirstSpeakerEnum FirstSpeaker { get; set; } = default!;

        /// <summary>
        /// Messages spoken by the agent when the user is inactive for the specified duration. Durations are cumulative, so a message m &gt; 1 with duration 30s will be spoken 30 seconds after message m-1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivityMessages")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TimedMessage>? InactivityMessages { get; set; }

        /// <summary>
        /// The medium used initially by the agent. May later be changed by the client.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("initialOutputMedium")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.InitialOutputMediumEnumJsonConverter))]
        public global::Ultravox.InitialOutputMediumEnum InitialOutputMedium { get; set; } = default!;

        /// <summary>
        /// Default Value: 60s
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joinTimeout")]
        public string? JoinTimeout { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joinUrl")]
        public string? JoinUrl { get; set; }

        /// <summary>
        /// BCP47 language code that may be used to guide speech recognition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageHint")]
        public string? LanguageHint { get; set; }

        /// <summary>
        /// Default Value: 3600s
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDuration")]
        public string? MaxDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium")]
        public global::Ultravox.UltravoxV1CallMedium? Medium { get; set; }

        /// <summary>
        /// Default Value: fixie-ai/ultravox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Default Value: false<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recordingEnabled")]
        public bool? RecordingEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeExceededMessage")]
        public string? TimeExceededMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Indicates whether a transcript is optional for the call.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptOptional")]
        public bool? TranscriptOptional { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Call" /> class.
        /// </summary>
        /// <param name="callId">
        /// Included only in responses
        /// </param>
        /// <param name="clientVersion">
        /// The version of the client that joined this call.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="ended">
        /// Included only in responses
        /// </param>
        /// <param name="endReason">
        /// The reason the call ended.<br/>
        /// * `unjoined` - Client never joined<br/>
        /// * `hangup` - Client hung up<br/>
        /// * `timeout` - Call timed out<br/>
        /// * `connection_error` - Connection error<br/>
        /// Included only in responses
        /// </param>
        /// <param name="firstSpeaker">
        /// Who was supposed to talk first when the call started. Typically set to FIRST_SPEAKER_USER for outgoing calls and left as the default (FIRST_SPEAKER_AGENT) otherwise.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="inactivityMessages">
        /// Messages spoken by the agent when the user is inactive for the specified duration. Durations are cumulative, so a message m &gt; 1 with duration 30s will be spoken 30 seconds after message m-1.
        /// </param>
        /// <param name="initialOutputMedium">
        /// The medium used initially by the agent. May later be changed by the client.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="joinTimeout">
        /// Default Value: 60s
        /// </param>
        /// <param name="joinUrl">
        /// Included only in responses
        /// </param>
        /// <param name="languageHint">
        /// BCP47 language code that may be used to guide speech recognition.
        /// </param>
        /// <param name="maxDuration">
        /// Default Value: 3600s
        /// </param>
        /// <param name="medium"></param>
        /// <param name="model">
        /// Default Value: fixie-ai/ultravox
        /// </param>
        /// <param name="recordingEnabled">
        /// Default Value: false<br/>
        /// Included only in requests
        /// </param>
        /// <param name="systemPrompt"></param>
        /// <param name="temperature">
        /// Default Value: 0
        /// </param>
        /// <param name="timeExceededMessage"></param>
        /// <param name="voice"></param>
        /// <param name="transcriptOptional">
        /// Indicates whether a transcript is optional for the call.<br/>
        /// Default Value: true
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Call(
            string? clientVersion,
            global::System.DateTime? ended,
            global::Ultravox.OneOf<global::Ultravox.EndReasonEnum?, global::Ultravox.NullEnum?>? endReason,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TimedMessage>? inactivityMessages,
            string? joinTimeout,
            string? joinUrl,
            string? languageHint,
            string? maxDuration,
            global::Ultravox.UltravoxV1CallMedium? medium,
            string? model,
            bool? recordingEnabled,
            string? systemPrompt,
            double? temperature,
            string? timeExceededMessage,
            string? voice,
            bool? transcriptOptional,
            global::System.Guid callId = default!,
            global::System.DateTime created = default!,
            global::Ultravox.FirstSpeakerEnum firstSpeaker = default!,
            global::Ultravox.InitialOutputMediumEnum initialOutputMedium = default!)
        {
            this.CallId = callId;
            this.ClientVersion = clientVersion;
            this.Created = created;
            this.Ended = ended;
            this.EndReason = endReason;
            this.FirstSpeaker = firstSpeaker;
            this.InactivityMessages = inactivityMessages;
            this.InitialOutputMedium = initialOutputMedium;
            this.JoinTimeout = joinTimeout;
            this.JoinUrl = joinUrl;
            this.LanguageHint = languageHint;
            this.MaxDuration = maxDuration;
            this.Medium = medium;
            this.Model = model;
            this.RecordingEnabled = recordingEnabled;
            this.SystemPrompt = systemPrompt;
            this.Temperature = temperature;
            this.TimeExceededMessage = timeExceededMessage;
            this.Voice = voice;
            this.TranscriptOptional = transcriptOptional;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Call" /> class.
        /// </summary>
        public Call()
        {
        }
    }
}