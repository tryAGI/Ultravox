
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum HangUpPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        HangUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HangUpPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HangUpPayloadType value)
        {
            return value switch
            {
                HangUpPayloadType.HangUp => "hang_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HangUpPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "hang_up" => HangUpPayloadType.HangUp,
                _ => null,
            };
        }
    }
}