
#nullable enable

namespace Ultravox
{
    /// <summary>
    ///
    /// </summary>
    public enum CallMediumRestrictionAllowedMedium
    {
        /// <summary>
        ///
        /// </summary>
        MessageMediumText,
        /// <summary>
        ///
        /// </summary>
        MessageMediumVoice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallMediumRestrictionAllowedMediumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallMediumRestrictionAllowedMedium value)
        {
            return value switch
            {
                CallMediumRestrictionAllowedMedium.MessageMediumText => "MESSAGE_MEDIUM_TEXT",
                CallMediumRestrictionAllowedMedium.MessageMediumVoice => "MESSAGE_MEDIUM_VOICE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallMediumRestrictionAllowedMedium? ToEnum(string value)
        {
            return value switch
            {
                "MESSAGE_MEDIUM_TEXT" => CallMediumRestrictionAllowedMedium.MessageMediumText,
                "MESSAGE_MEDIUM_VOICE" => CallMediumRestrictionAllowedMedium.MessageMediumVoice,
                _ => null,
            };
        }
    }
}