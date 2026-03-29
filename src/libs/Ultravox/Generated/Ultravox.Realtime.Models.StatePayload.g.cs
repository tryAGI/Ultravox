
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Agent state change notification.
    /// </summary>
    public sealed partial class StatePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.StatePayloadTypeJsonConverter))]
        public global::Ultravox.Realtime.StatePayloadType Type { get; set; }

        /// <summary>
        /// Current agent state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.StatePayloadStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ultravox.Realtime.StatePayloadState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StatePayload" /> class.
        /// </summary>
        /// <param name="state">
        /// Current agent state.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StatePayload(
            global::Ultravox.Realtime.StatePayloadState state,
            global::Ultravox.Realtime.StatePayloadType type)
        {
            this.Type = type;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatePayload" /> class.
        /// </summary>
        public StatePayload()
        {
        }
    }
}