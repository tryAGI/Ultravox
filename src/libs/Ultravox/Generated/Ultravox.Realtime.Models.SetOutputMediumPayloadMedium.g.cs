
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Output medium: voice or text.
    /// </summary>
    public enum SetOutputMediumPayloadMedium
    {
        /// <summary>
        /// voice or text.
        /// </summary>
        Text,
        /// <summary>
        /// voice or text.
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SetOutputMediumPayloadMediumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetOutputMediumPayloadMedium value)
        {
            return value switch
            {
                SetOutputMediumPayloadMedium.Text => "text",
                SetOutputMediumPayloadMedium.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetOutputMediumPayloadMedium? ToEnum(string value)
        {
            return value switch
            {
                "text" => SetOutputMediumPayloadMedium.Text,
                "voice" => SetOutputMediumPayloadMedium.Voice,
                _ => null,
            };
        }
    }
}