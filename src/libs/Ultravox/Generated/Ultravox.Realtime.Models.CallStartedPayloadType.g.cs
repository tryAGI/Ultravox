
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum CallStartedPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        CallStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallStartedPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallStartedPayloadType value)
        {
            return value switch
            {
                CallStartedPayloadType.CallStarted => "call_started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallStartedPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "call_started" => CallStartedPayloadType.CallStarted,
                _ => null,
            };
        }
    }
}