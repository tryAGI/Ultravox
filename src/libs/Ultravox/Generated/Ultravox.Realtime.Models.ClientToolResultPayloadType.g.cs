
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClientToolResultPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ClientToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientToolResultPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientToolResultPayloadType value)
        {
            return value switch
            {
                ClientToolResultPayloadType.ClientToolResult => "client_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientToolResultPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "client_tool_result" => ClientToolResultPayloadType.ClientToolResult,
                _ => null,
            };
        }
    }
}