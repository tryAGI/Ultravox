
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserTextMessagePayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        UserTextMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserTextMessagePayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserTextMessagePayloadType value)
        {
            return value switch
            {
                UserTextMessagePayloadType.UserTextMessage => "user_text_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserTextMessagePayloadType? ToEnum(string value)
        {
            return value switch
            {
                "user_text_message" => UserTextMessagePayloadType.UserTextMessage,
                _ => null,
            };
        }
    }
}