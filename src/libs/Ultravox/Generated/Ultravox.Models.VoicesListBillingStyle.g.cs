
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoicesListBillingStyle
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
    public static class VoicesListBillingStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicesListBillingStyle value)
        {
            return value switch
            {
                VoicesListBillingStyle.VOICEBILLINGSTYLEINCLUDED => "VOICE_BILLING_STYLE_INCLUDED",
                VoicesListBillingStyle.VOICEBILLINGSTYLEEXTERNAL => "VOICE_BILLING_STYLE_EXTERNAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicesListBillingStyle? ToEnum(string value)
        {
            return value switch
            {
                "VOICE_BILLING_STYLE_INCLUDED" => VoicesListBillingStyle.VOICEBILLINGSTYLEINCLUDED,
                "VOICE_BILLING_STYLE_EXTERNAL" => VoicesListBillingStyle.VOICEBILLINGSTYLEEXTERNAL,
                _ => null,
            };
        }
    }
}