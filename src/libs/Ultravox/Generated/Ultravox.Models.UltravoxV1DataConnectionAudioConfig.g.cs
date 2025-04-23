
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Configuration for audio in data connections
    /// </summary>
    public sealed partial class UltravoxV1DataConnectionAudioConfig
    {
        /// <summary>
        /// The sample rate of the audio stream. If not set, will default to 16000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleRate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// The audio channel mode to use. CHANNEL_MODE_MIXED will combine user and agent audio<br/>
        ///  into a single mono output while CHANNEL_MODE_SEPARATED will result in stereo audio<br/>
        ///  where user and agent are separated. The latter is the default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channelMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.UltravoxV1DataConnectionAudioConfigChannelModeJsonConverter))]
        public global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode? ChannelMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1DataConnectionAudioConfig" /> class.
        /// </summary>
        /// <param name="sampleRate">
        /// The sample rate of the audio stream. If not set, will default to 16000.
        /// </param>
        /// <param name="channelMode">
        /// The audio channel mode to use. CHANNEL_MODE_MIXED will combine user and agent audio<br/>
        ///  into a single mono output while CHANNEL_MODE_SEPARATED will result in stereo audio<br/>
        ///  where user and agent are separated. The latter is the default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1DataConnectionAudioConfig(
            int? sampleRate,
            global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode? channelMode)
        {
            this.SampleRate = sampleRate;
            this.ChannelMode = channelMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1DataConnectionAudioConfig" /> class.
        /// </summary>
        public UltravoxV1DataConnectionAudioConfig()
        {
        }
    }
}