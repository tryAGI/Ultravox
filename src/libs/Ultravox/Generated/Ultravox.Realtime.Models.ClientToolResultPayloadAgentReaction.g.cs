
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// How the agent should react.
    /// </summary>
    public enum ClientToolResultPayloadAgentReaction
    {
        /// <summary>
        /// 
        /// </summary>
        Speaks,
        /// <summary>
        /// 
        /// </summary>
        Listens,
        /// <summary>
        /// 
        /// </summary>
        SpeaksOnce,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientToolResultPayloadAgentReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientToolResultPayloadAgentReaction value)
        {
            return value switch
            {
                ClientToolResultPayloadAgentReaction.Speaks => "speaks",
                ClientToolResultPayloadAgentReaction.Listens => "listens",
                ClientToolResultPayloadAgentReaction.SpeaksOnce => "speaks-once",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientToolResultPayloadAgentReaction? ToEnum(string value)
        {
            return value switch
            {
                "speaks" => ClientToolResultPayloadAgentReaction.Speaks,
                "listens" => ClientToolResultPayloadAgentReaction.Listens,
                "speaks-once" => ClientToolResultPayloadAgentReaction.SpeaksOnce,
                _ => null,
            };
        }
    }
}