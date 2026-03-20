
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaybackClearBufferPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        PlaybackClearBuffer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaybackClearBufferPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaybackClearBufferPayloadType value)
        {
            return value switch
            {
                PlaybackClearBufferPayloadType.PlaybackClearBuffer => "playback_clear_buffer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaybackClearBufferPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "playback_clear_buffer" => PlaybackClearBufferPayloadType.PlaybackClearBuffer,
                _ => null,
            };
        }
    }
}