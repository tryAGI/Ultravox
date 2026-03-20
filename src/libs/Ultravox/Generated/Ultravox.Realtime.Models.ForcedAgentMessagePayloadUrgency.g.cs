
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// How urgently the agent should respond.
    /// </summary>
    public enum ForcedAgentMessagePayloadUrgency
    {
        /// <summary>
        /// 
        /// </summary>
        Immediate,
        /// <summary>
        /// 
        /// </summary>
        Soon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ForcedAgentMessagePayloadUrgencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ForcedAgentMessagePayloadUrgency value)
        {
            return value switch
            {
                ForcedAgentMessagePayloadUrgency.Immediate => "immediate",
                ForcedAgentMessagePayloadUrgency.Soon => "soon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ForcedAgentMessagePayloadUrgency? ToEnum(string value)
        {
            return value switch
            {
                "immediate" => ForcedAgentMessagePayloadUrgency.Immediate,
                "soon" => ForcedAgentMessagePayloadUrgency.Soon,
                _ => null,
            };
        }
    }
}