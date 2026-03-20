
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum DebugPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        Debug,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DebugPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DebugPayloadType value)
        {
            return value switch
            {
                DebugPayloadType.Debug => "debug",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DebugPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "debug" => DebugPayloadType.Debug,
                _ => null,
            };
        }
    }
}