
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Instruct the agent to end the call.
    /// </summary>
    public sealed partial class HangUpPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.HangUpPayloadTypeJsonConverter))]
        public global::Ultravox.Realtime.HangUpPayloadType Type { get; set; }

        /// <summary>
        /// Optional goodbye message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HangUpPayload" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message">
        /// Optional goodbye message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HangUpPayload(
            global::Ultravox.Realtime.HangUpPayloadType type,
            string? message)
        {
            this.Type = type;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HangUpPayload" /> class.
        /// </summary>
        public HangUpPayload()
        {
        }
    }
}