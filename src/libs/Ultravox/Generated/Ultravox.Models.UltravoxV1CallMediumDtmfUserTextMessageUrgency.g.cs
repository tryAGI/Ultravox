
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Urgency of the message. Defaults to URGENCY_IMMEDIATE.
    /// </summary>
    public enum UltravoxV1CallMediumDtmfUserTextMessageUrgency
    {
        /// <summary>
        /// 
        /// </summary>
        UrgencyUnspecified,
        /// <summary>
        /// 
        /// </summary>
        UrgencyImmediate,
        /// <summary>
        /// 
        /// </summary>
        UrgencySoon,
        /// <summary>
        /// 
        /// </summary>
        UrgencyLater,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1CallMediumDtmfUserTextMessageUrgencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1CallMediumDtmfUserTextMessageUrgency value)
        {
            return value switch
            {
                UltravoxV1CallMediumDtmfUserTextMessageUrgency.UrgencyUnspecified => "URGENCY_UNSPECIFIED",
                UltravoxV1CallMediumDtmfUserTextMessageUrgency.UrgencyImmediate => "URGENCY_IMMEDIATE",
                UltravoxV1CallMediumDtmfUserTextMessageUrgency.UrgencySoon => "URGENCY_SOON",
                UltravoxV1CallMediumDtmfUserTextMessageUrgency.UrgencyLater => "URGENCY_LATER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1CallMediumDtmfUserTextMessageUrgency? ToEnum(string value)
        {
            return value switch
            {
                "URGENCY_UNSPECIFIED" => UltravoxV1CallMediumDtmfUserTextMessageUrgency.UrgencyUnspecified,
                "URGENCY_IMMEDIATE" => UltravoxV1CallMediumDtmfUserTextMessageUrgency.UrgencyImmediate,
                "URGENCY_SOON" => UltravoxV1CallMediumDtmfUserTextMessageUrgency.UrgencySoon,
                "URGENCY_LATER" => UltravoxV1CallMediumDtmfUserTextMessageUrgency.UrgencyLater,
                _ => null,
            };
        }
    }
}