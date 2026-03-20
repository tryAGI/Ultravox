
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Speaker role.
    /// </summary>
    public enum TranscriptPayloadRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptPayloadRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptPayloadRole value)
        {
            return value switch
            {
                TranscriptPayloadRole.User => "user",
                TranscriptPayloadRole.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptPayloadRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => TranscriptPayloadRole.User,
                "agent" => TranscriptPayloadRole.Agent,
                _ => null,
            };
        }
    }
}