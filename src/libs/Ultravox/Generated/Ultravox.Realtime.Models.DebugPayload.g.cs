
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Debug information from the server.
    /// </summary>
    public sealed partial class DebugPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.DebugPayloadTypeJsonConverter))]
        public global::Ultravox.Realtime.DebugPayloadType Type { get; set; }

        /// <summary>
        /// Debug message content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugPayload" /> class.
        /// </summary>
        /// <param name="message">
        /// Debug message content.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DebugPayload(
            string message,
            global::Ultravox.Realtime.DebugPayloadType type)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DebugPayload" /> class.
        /// </summary>
        public DebugPayload()
        {
        }
    }
}