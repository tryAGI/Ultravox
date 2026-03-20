
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum PingPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        Ping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PingPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PingPayloadType value)
        {
            return value switch
            {
                PingPayloadType.Ping => "ping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PingPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "ping" => PingPayloadType.Ping,
                _ => null,
            };
        }
    }
}