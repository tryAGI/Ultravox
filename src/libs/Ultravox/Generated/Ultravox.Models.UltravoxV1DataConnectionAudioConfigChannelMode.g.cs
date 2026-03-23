
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// The audio channel mode to use. CHANNEL_MODE_MIXED will combine user and agent audio<br/>
    ///  into a single mono output while CHANNEL_MODE_SEPARATED will result in stereo audio<br/>
    ///  where user and agent are separated. The latter is the default.
    /// </summary>
    public enum UltravoxV1DataConnectionAudioConfigChannelMode
    {
        /// <summary>
        /// 
        /// </summary>
        ChannelModeMixed,
        /// <summary>
        /// 
        /// </summary>
        ChannelModeSeparated,
        /// <summary>
        /// 
        /// </summary>
        ChannelModeUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1DataConnectionAudioConfigChannelModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1DataConnectionAudioConfigChannelMode value)
        {
            return value switch
            {
                UltravoxV1DataConnectionAudioConfigChannelMode.ChannelModeMixed => "CHANNEL_MODE_MIXED",
                UltravoxV1DataConnectionAudioConfigChannelMode.ChannelModeSeparated => "CHANNEL_MODE_SEPARATED",
                UltravoxV1DataConnectionAudioConfigChannelMode.ChannelModeUnspecified => "CHANNEL_MODE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1DataConnectionAudioConfigChannelMode? ToEnum(string value)
        {
            return value switch
            {
                "CHANNEL_MODE_MIXED" => UltravoxV1DataConnectionAudioConfigChannelMode.ChannelModeMixed,
                "CHANNEL_MODE_SEPARATED" => UltravoxV1DataConnectionAudioConfigChannelMode.ChannelModeSeparated,
                "CHANNEL_MODE_UNSPECIFIED" => UltravoxV1DataConnectionAudioConfigChannelMode.ChannelModeUnspecified,
                _ => null,
            };
        }
    }
}