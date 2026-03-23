
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
        Agent,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                TranscriptPayloadRole.Agent => "agent",
                TranscriptPayloadRole.User => "user",
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
                "agent" => TranscriptPayloadRole.Agent,
                "user" => TranscriptPayloadRole.User,
                _ => null,
            };
        }
    }
}