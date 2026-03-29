
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Call started notification.
    /// </summary>
    public sealed partial class CallStartedPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.CallStartedPayloadTypeJsonConverter))]
        public global::Ultravox.Realtime.CallStartedPayloadType Type { get; set; }

        /// <summary>
        /// Unique call identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallStartedPayload" /> class.
        /// </summary>
        /// <param name="callId">
        /// Unique call identifier.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallStartedPayload(
            string callId,
            global::Ultravox.Realtime.CallStartedPayloadType type)
        {
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallStartedPayload" /> class.
        /// </summary>
        public CallStartedPayload()
        {
        }
    }
}