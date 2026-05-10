
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Pong response to a ping.
    /// </summary>
    public sealed partial class PongPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.PongPayloadTypeJsonConverter))]
        public global::Ultravox.Realtime.PongPayloadType Type { get; set; }

        /// <summary>
        /// Echoed timestamp from the ping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PongPayload" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Echoed timestamp from the ping.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PongPayload(
            double timestamp,
            global::Ultravox.Realtime.PongPayloadType type)
        {
            this.Type = type;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PongPayload" /> class.
        /// </summary>
        public PongPayload()
        {
        }

    }
}