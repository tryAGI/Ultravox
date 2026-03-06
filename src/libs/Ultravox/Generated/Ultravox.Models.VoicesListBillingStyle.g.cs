
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
        VoiceBillingStyleIncluded,
        /// <summary>
        /// 
        /// </summary>
        VoiceBillingStyleExternal,
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
                VoicesListBillingStyle.VoiceBillingStyleIncluded => "VOICE_BILLING_STYLE_INCLUDED",
                VoicesListBillingStyle.VoiceBillingStyleExternal => "VOICE_BILLING_STYLE_EXTERNAL",
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
                "VOICE_BILLING_STYLE_INCLUDED" => VoicesListBillingStyle.VoiceBillingStyleIncluded,
                "VOICE_BILLING_STYLE_EXTERNAL" => VoicesListBillingStyle.VoiceBillingStyleExternal,
                _ => null,
            };
        }
    }
}