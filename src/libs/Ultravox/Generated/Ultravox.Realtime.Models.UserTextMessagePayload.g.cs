
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Text input from the user.
    /// </summary>
    public sealed partial class UserTextMessagePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.UserTextMessagePayloadTypeJsonConverter))]
        public global::Ultravox.Realtime.UserTextMessagePayloadType Type { get; set; }

        /// <summary>
        /// The text message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// How urgently the agent should respond.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urgency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.UserTextMessagePayloadUrgencyJsonConverter))]
        public global::Ultravox.Realtime.UserTextMessagePayloadUrgency? Urgency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTextMessagePayload" /> class.
        /// </summary>
        /// <param name="text">
        /// The text message.
        /// </param>
        /// <param name="type"></param>
        /// <param name="urgency">
        /// How urgently the agent should respond.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserTextMessagePayload(
            string text,
            global::Ultravox.Realtime.UserTextMessagePayloadType type,
            global::Ultravox.Realtime.UserTextMessagePayloadUrgency? urgency)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Urgency = urgency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserTextMessagePayload" /> class.
        /// </summary>
        public UserTextMessagePayload()
        {
        }
    }
}