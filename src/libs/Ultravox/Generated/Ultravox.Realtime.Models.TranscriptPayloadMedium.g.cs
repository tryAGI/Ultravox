
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Medium of the transcript.
    /// </summary>
    public enum TranscriptPayloadMedium
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptPayloadMediumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptPayloadMedium value)
        {
            return value switch
            {
                TranscriptPayloadMedium.Text => "text",
                TranscriptPayloadMedium.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptPayloadMedium? ToEnum(string value)
        {
            return value switch
            {
                "text" => TranscriptPayloadMedium.Text,
                "voice" => TranscriptPayloadMedium.Voice,
                _ => null,
            };
        }
    }
}