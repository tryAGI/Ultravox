
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallEvent
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
        /// The timestamp of the event, relative to call start.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callTimestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallTimestamp { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.SeverityEnumJsonConverter))]
        public global::Ultravox.SeverityEnum Severity { get; set; } = default!;

        /// <summary>
        /// The type of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public object? Extras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallEvent" /> class.
        /// </summary>
        /// <param name="callId">
        /// Included only in responses
        /// </param>
        /// <param name="callStageId">
        /// Included only in responses
        /// </param>
        /// <param name="callTimestamp">
        /// The timestamp of the event, relative to call start.
        /// </param>
        /// <param name="severity">
        /// Included only in responses
        /// </param>
        /// <param name="type">
        /// The type of the event.
        /// </param>
        /// <param name="text"></param>
        /// <param name="extras"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallEvent(
            string callTimestamp,
            string type,
            string text,
            object? extras,
            global::System.Guid callId = default!,
            global::System.Guid callStageId = default!,
            global::Ultravox.SeverityEnum severity = default!)
        {
            this.CallTimestamp = callTimestamp ?? throw new global::System.ArgumentNullException(nameof(callTimestamp));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.CallId = callId;
            this.CallStageId = callStageId;
            this.Severity = severity;
            this.Extras = extras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallEvent" /> class.
        /// </summary>
        public CallEvent()
        {
        }
    }
}