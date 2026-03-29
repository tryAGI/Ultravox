
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Speech transcript event.
    /// </summary>
    public sealed partial class TranscriptPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.TranscriptPayloadTypeJsonConverter))]
        public global::Ultravox.Realtime.TranscriptPayloadType Type { get; set; }

        /// <summary>
        /// Speaker role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.TranscriptPayloadRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ultravox.Realtime.TranscriptPayloadRole Role { get; set; }

        /// <summary>
        /// Medium of the transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.TranscriptPayloadMediumJsonConverter))]
        public global::Ultravox.Realtime.TranscriptPayloadMedium? Medium { get; set; }

        /// <summary>
        /// Full transcript text (mutually exclusive with delta).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Incremental transcript text (mutually exclusive with text).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public string? Delta { get; set; }

        /// <summary>
        /// Whether more updates are expected for this utterance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("final")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Final { get; set; }

        /// <summary>
        /// Message ordering index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ordinal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Ordinal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptPayload" /> class.
        /// </summary>
        /// <param name="role">
        /// Speaker role.
        /// </param>
        /// <param name="final">
        /// Whether more updates are expected for this utterance.
        /// </param>
        /// <param name="ordinal">
        /// Message ordering index.
        /// </param>
        /// <param name="type"></param>
        /// <param name="medium">
        /// Medium of the transcript.
        /// </param>
        /// <param name="text">
        /// Full transcript text (mutually exclusive with delta).
        /// </param>
        /// <param name="delta">
        /// Incremental transcript text (mutually exclusive with text).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptPayload(
            global::Ultravox.Realtime.TranscriptPayloadRole role,
            bool final,
            int ordinal,
            global::Ultravox.Realtime.TranscriptPayloadType type,
            global::Ultravox.Realtime.TranscriptPayloadMedium? medium,
            string? text,
            string? delta)
        {
            this.Type = type;
            this.Role = role;
            this.Medium = medium;
            this.Text = text;
            this.Delta = delta;
            this.Final = final;
            this.Ordinal = ordinal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptPayload" /> class.
        /// </summary>
        public TranscriptPayload()
        {
        }
    }
}