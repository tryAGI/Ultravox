
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ForcedAgentMessagePayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ForcedAgentMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ForcedAgentMessagePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ForcedAgentMessagePayloadType value)
        {
            return value switch
            {
                ForcedAgentMessagePayloadType.ForcedAgentMessage => "forced_agent_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ForcedAgentMessagePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "forced_agent_message" => ForcedAgentMessagePayloadType.ForcedAgentMessage,
                _ => null,
            };
        }
    }
}