
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum StatePayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        State,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatePayloadType value)
        {
            return value switch
            {
                StatePayloadType.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "state" => StatePayloadType.State,
                _ => null,
            };
        }
    }
}