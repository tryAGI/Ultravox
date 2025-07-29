
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public enum BillingStyleEnum
    {
        /// <summary>
        /// 
        /// </summary>
        VOICEBILLINGSTYLEINCLUDED,
        /// <summary>
        /// 
        /// </summary>
        VOICEBILLINGSTYLEEXTERNAL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingStyleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingStyleEnum value)
        {
            return value switch
            {
                BillingStyleEnum.VOICEBILLINGSTYLEINCLUDED => "VOICE_BILLING_STYLE_INCLUDED",
                BillingStyleEnum.VOICEBILLINGSTYLEEXTERNAL => "VOICE_BILLING_STYLE_EXTERNAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingStyleEnum? ToEnum(string value)
        {
            return value switch
            {
                "VOICE_BILLING_STYLE_INCLUDED" => BillingStyleEnum.VOICEBILLINGSTYLEINCLUDED,
                "VOICE_BILLING_STYLE_EXTERNAL" => BillingStyleEnum.VOICEBILLINGSTYLEEXTERNAL,
                _ => null,
            };
        }
    }
}