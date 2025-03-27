
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallStage
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("callId")]
        public global::System.Guid CallId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("callStageId")]
        public global::System.Guid CallStageId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime Created { get; set; } = default!;

        /// <summary>
        /// Messages spoken by the agent when the user is inactive for the specified duration. Durations are cumulative, so a message m &gt; 1 with duration 30s will be spoken 30 seconds after message m-1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inactivityMessages")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TimedMessage>? InactivityMessages { get; set; }

        /// <summary>
        /// BCP47 language code that may be used to guide speech recognition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languageHint")]
        public string? LanguageHint { get; set; }

        /// <summary>
        /// Default Value: fixie-ai/ultravox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double Temperature { get; set; } = default!;

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
        /// The number of errors in this call stage.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCount")]
        public int ErrorCount { get; set; } = default!;

        /// <summary>
        /// Experimental settings for this call stage.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentalSettings")]
        public object? ExperimentalSettings { get; set; }

        /// <summary>
        /// The initial state of the call stage which is readable/writable by tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initialState")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object InitialState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallStage" /> class.
        /// </summary>
        /// <param name="callId">
        /// Included only in responses
        /// </param>
        /// <param name="callStageId">
        /// Included only in responses
        /// </param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="inactivityMessages">
        /// Messages spoken by the agent when the user is inactive for the specified duration. Durations are cumulative, so a message m &gt; 1 with duration 30s will be spoken 30 seconds after message m-1.
        /// </param>
        /// <param name="languageHint">
        /// BCP47 language code that may be used to guide speech recognition.
        /// </param>
        /// <param name="model">
        /// Default Value: fixie-ai/ultravox
        /// </param>
        /// <param name="systemPrompt"></param>
        /// <param name="temperature">
        /// Included only in responses
        /// </param>
        /// <param name="timeExceededMessage"></param>
        /// <param name="voice"></param>
        /// <param name="errorCount">
        /// The number of errors in this call stage.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="experimentalSettings">
        /// Experimental settings for this call stage.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="initialState">
        /// The initial state of the call stage which is readable/writable by tools.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallStage(
            object initialState,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TimedMessage>? inactivityMessages,
            string? languageHint,
            string? model,
            string? systemPrompt,
            string? timeExceededMessage,
            string? voice,
            object? experimentalSettings,
            global::System.Guid callId = default!,
            global::System.Guid callStageId = default!,
            global::System.DateTime created = default!,
            double temperature = default!,
            int errorCount = default!)
        {
            this.InitialState = initialState ?? throw new global::System.ArgumentNullException(nameof(initialState));
            this.CallId = callId;
            this.CallStageId = callStageId;
            this.Created = created;
            this.InactivityMessages = inactivityMessages;
            this.LanguageHint = languageHint;
            this.Model = model;
            this.SystemPrompt = systemPrompt;
            this.Temperature = temperature;
            this.TimeExceededMessage = timeExceededMessage;
            this.Voice = voice;
            this.ErrorCount = errorCount;
            this.ExperimentalSettings = experimentalSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallStage" /> class.
        /// </summary>
        public CallStage()
        {
        }
    }
}