
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClientToolInvocationPayloadType
    {
        /// <summary>
        /// 
        /// </summary>
        ClientToolInvocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientToolInvocationPayloadTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientToolInvocationPayloadType value)
        {
            return value switch
            {
                ClientToolInvocationPayloadType.ClientToolInvocation => "client_tool_invocation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientToolInvocationPayloadType? ToEnum(string value)
        {
            return value switch
            {
                "client_tool_invocation" => ClientToolInvocationPayloadType.ClientToolInvocation,
                _ => null,
            };
        }
    }
}