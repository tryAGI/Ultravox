
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Ping message to measure round-trip latency.
    /// </summary>
    public sealed partial class PingPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.PingPayloadTypeJsonConverter))]
        public global::Ultravox.Realtime.PingPayloadType Type { get; set; }

        /// <summary>
        /// Unix timestamp with millisecond precision.
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
        /// Initializes a new instance of the <see cref="PingPayload" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Unix timestamp with millisecond precision.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PingPayload(
            double timestamp,
            global::Ultravox.Realtime.PingPayloadType type)
        {
            this.Type = type;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PingPayload" /> class.
        /// </summary>
        public PingPayload()
        {
        }
    }
}