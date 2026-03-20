
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// How urgently the agent should respond.
    /// </summary>
    public enum UserTextMessagePayloadUrgency
    {
        /// <summary>
        /// 
        /// </summary>
        Immediate,
        /// <summary>
        /// 
        /// </summary>
        Soon,
        /// <summary>
        /// 
        /// </summary>
        Later,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserTextMessagePayloadUrgencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserTextMessagePayloadUrgency value)
        {
            return value switch
            {
                UserTextMessagePayloadUrgency.Immediate => "immediate",
                UserTextMessagePayloadUrgency.Soon => "soon",
                UserTextMessagePayloadUrgency.Later => "later",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserTextMessagePayloadUrgency? ToEnum(string value)
        {
            return value switch
            {
                "immediate" => UserTextMessagePayloadUrgency.Immediate,
                "soon" => UserTextMessagePayloadUrgency.Soon,
                "later" => UserTextMessagePayloadUrgency.Later,
                _ => null,
            };
        }
    }
}