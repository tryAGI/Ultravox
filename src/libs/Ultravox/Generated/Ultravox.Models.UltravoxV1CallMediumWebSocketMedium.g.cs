
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Details for a WebSocket call.
    /// </summary>
    public sealed partial class UltravoxV1CallMediumWebSocketMedium
    {
        /// <summary>
        /// The sample rate for input (user) audio. Required.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputSampleRate")]
        public int? InputSampleRate { get; set; }

        /// <summary>
        /// The desired sample rate for output (agent) audio. If unset, defaults to the input_sample_rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSampleRate")]
        public int? OutputSampleRate { get; set; }

        /// <summary>
        /// The size of the client-side audio buffer in milliseconds. Smaller buffers allow for faster<br/>
        ///  interruptions but may cause audio underflow if network latency fluctuates too greatly. For<br/>
        ///  the best of both worlds, set this to some large value (e.g. 30000) and implement support for<br/>
        ///  playback_clear_buffer messages. Defaults to 60.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientBufferSizeMs")]
        public int? ClientBufferSizeMs { get; set; }

        /// <summary>
        /// Controls which data messages are enabled for the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataMessages")]
        public global::Ultravox.UltravoxV1EnabledDataMessages? DataMessages { get; set; }

        /// <summary>
        /// Depending on your implementation, severe underflow from something further downstream from<br/>
        ///  your server may result in audio no longer being delivered to Ultravox at all (despite<br/>
        ///  heartbeats continuing). If media_idle_timeout is set and Ultravox stops receiving audio for<br/>
        ///  longer than this duration, the call will be ended with a "Connection error" end reason.<br/>
        ///  Values in the 30s to 60s range are recommended (and may become the default in the future).<br/>
        ///  Values below 10s will be treated as 10s.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mediaIdleTimeout")]
        public string? MediaIdleTimeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumWebSocketMedium" /> class.
        /// </summary>
        /// <param name="inputSampleRate">
        /// The sample rate for input (user) audio. Required.
        /// </param>
        /// <param name="outputSampleRate">
        /// The desired sample rate for output (agent) audio. If unset, defaults to the input_sample_rate.
        /// </param>
        /// <param name="clientBufferSizeMs">
        /// The size of the client-side audio buffer in milliseconds. Smaller buffers allow for faster<br/>
        ///  interruptions but may cause audio underflow if network latency fluctuates too greatly. For<br/>
        ///  the best of both worlds, set this to some large value (e.g. 30000) and implement support for<br/>
        ///  playback_clear_buffer messages. Defaults to 60.
        /// </param>
        /// <param name="dataMessages">
        /// Controls which data messages are enabled for the call.
        /// </param>
        /// <param name="mediaIdleTimeout">
        /// Depending on your implementation, severe underflow from something further downstream from<br/>
        ///  your server may result in audio no longer being delivered to Ultravox at all (despite<br/>
        ///  heartbeats continuing). If media_idle_timeout is set and Ultravox stops receiving audio for<br/>
        ///  longer than this duration, the call will be ended with a "Connection error" end reason.<br/>
        ///  Values in the 30s to 60s range are recommended (and may become the default in the future).<br/>
        ///  Values below 10s will be treated as 10s.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CallMediumWebSocketMedium(
            int? inputSampleRate,
            int? outputSampleRate,
            int? clientBufferSizeMs,
            global::Ultravox.UltravoxV1EnabledDataMessages? dataMessages,
            string? mediaIdleTimeout)
        {
            this.InputSampleRate = inputSampleRate;
            this.OutputSampleRate = outputSampleRate;
            this.ClientBufferSizeMs = clientBufferSizeMs;
            this.DataMessages = dataMessages;
            this.MediaIdleTimeout = mediaIdleTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumWebSocketMedium" /> class.
        /// </summary>
        public UltravoxV1CallMediumWebSocketMedium()
        {
        }
    }
}