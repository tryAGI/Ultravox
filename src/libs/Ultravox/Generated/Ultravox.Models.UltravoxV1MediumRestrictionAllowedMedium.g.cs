
#nullable enable

namespace Ultravox
{
    /// <summary>
    ///
    /// </summary>
    public enum UltravoxV1MediumRestrictionAllowedMedium
    {
        /// <summary>
        ///
        /// </summary>
        MessageMediumText,
        /// <summary>
        ///
        /// </summary>
        MessageMediumUnspecified,
        /// <summary>
        ///
        /// </summary>
        MessageMediumVoice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1MediumRestrictionAllowedMediumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1MediumRestrictionAllowedMedium value)
        {
            return value switch
            {
                UltravoxV1MediumRestrictionAllowedMedium.MessageMediumText => "MESSAGE_MEDIUM_TEXT",
                UltravoxV1MediumRestrictionAllowedMedium.MessageMediumUnspecified => "MESSAGE_MEDIUM_UNSPECIFIED",
                UltravoxV1MediumRestrictionAllowedMedium.MessageMediumVoice => "MESSAGE_MEDIUM_VOICE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1MediumRestrictionAllowedMedium? ToEnum(string value)
        {
            return value switch
            {
                "MESSAGE_MEDIUM_TEXT" => UltravoxV1MediumRestrictionAllowedMedium.MessageMediumText,
                "MESSAGE_MEDIUM_UNSPECIFIED" => UltravoxV1MediumRestrictionAllowedMedium.MessageMediumUnspecified,
                "MESSAGE_MEDIUM_VOICE" => UltravoxV1MediumRestrictionAllowedMedium.MessageMediumVoice,
                _ => null,
            };
        }
    }
}