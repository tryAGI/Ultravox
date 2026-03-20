
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Request to clear the audio playback buffer.
    /// </summary>
    public sealed partial class PlaybackClearBufferPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.PlaybackClearBufferPayloadTypeJsonConverter))]
        public global::Ultravox.Realtime.PlaybackClearBufferPayloadType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaybackClearBufferPayload" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaybackClearBufferPayload(
            global::Ultravox.Realtime.PlaybackClearBufferPayloadType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaybackClearBufferPayload" /> class.
        /// </summary>
        public PlaybackClearBufferPayload()
        {
        }
    }
}