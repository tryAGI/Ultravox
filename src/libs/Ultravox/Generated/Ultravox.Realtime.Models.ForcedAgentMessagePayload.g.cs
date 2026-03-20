
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Force the agent to say specific text or invoke tools.
    /// </summary>
    public sealed partial class ForcedAgentMessagePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.ForcedAgentMessagePayloadTypeJsonConverter))]
        public global::Ultravox.Realtime.ForcedAgentMessagePayloadType Type { get; set; }

        /// <summary>
        /// Text for the agent to speak.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Tool calls for the agent to execute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCalls")]
        public global::System.Collections.Generic.IList<global::Ultravox.Realtime.ToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Whether the message cannot be interrupted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uninterruptible")]
        public bool? Uninterruptible { get; set; }

        /// <summary>
        /// How urgently the agent should respond.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urgency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.ForcedAgentMessagePayloadUrgencyJsonConverter))]
        public global::Ultravox.Realtime.ForcedAgentMessagePayloadUrgency? Urgency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForcedAgentMessagePayload" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="content">
        /// Text for the agent to speak.
        /// </param>
        /// <param name="toolCalls">
        /// Tool calls for the agent to execute.
        /// </param>
        /// <param name="uninterruptible">
        /// Whether the message cannot be interrupted.
        /// </param>
        /// <param name="urgency">
        /// How urgently the agent should respond.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForcedAgentMessagePayload(
            global::Ultravox.Realtime.ForcedAgentMessagePayloadType type,
            string? content,
            global::System.Collections.Generic.IList<global::Ultravox.Realtime.ToolCall>? toolCalls,
            bool? uninterruptible,
            global::Ultravox.Realtime.ForcedAgentMessagePayloadUrgency? urgency)
        {
            this.Type = type;
            this.Content = content;
            this.ToolCalls = toolCalls;
            this.Uninterruptible = uninterruptible;
            this.Urgency = urgency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForcedAgentMessagePayload" /> class.
        /// </summary>
        public ForcedAgentMessagePayload()
        {
        }
    }
}