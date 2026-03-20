
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum PongPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        Pong,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PongPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PongPayloadType value)
        {
            return value switch
            {
                PongPayloadType.Pong => "pong",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PongPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "pong" => PongPayloadType.Pong,
                _ => null,
            };
        }
    }
}