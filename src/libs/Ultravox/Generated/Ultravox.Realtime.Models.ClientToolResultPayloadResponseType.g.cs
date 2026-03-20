
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Response type.
    /// </summary>
    public enum ClientToolResultPayloadResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolResponse,
        /// <summary>
        /// 
        /// </summary>
        HangUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientToolResultPayloadResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientToolResultPayloadResponseType value)
        {
            return value switch
            {
                ClientToolResultPayloadResponseType.ToolResponse => "tool-response",
                ClientToolResultPayloadResponseType.HangUp => "hang-up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientToolResultPayloadResponseType? ToEnum(string value)
        {
            return value switch
            {
                "tool-response" => ClientToolResultPayloadResponseType.ToolResponse,
                "hang-up" => ClientToolResultPayloadResponseType.HangUp,
                _ => null,
            };
        }
    }
}