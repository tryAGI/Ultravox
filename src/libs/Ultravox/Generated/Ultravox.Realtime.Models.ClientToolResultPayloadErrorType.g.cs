
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Error type if the tool failed.
    /// </summary>
    public enum ClientToolResultPayloadErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        Undefined,
        /// <summary>
        /// 
        /// </summary>
        ImplementationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientToolResultPayloadErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientToolResultPayloadErrorType value)
        {
            return value switch
            {
                ClientToolResultPayloadErrorType.Undefined => "undefined",
                ClientToolResultPayloadErrorType.ImplementationError => "implementation-error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientToolResultPayloadErrorType? ToEnum(string value)
        {
            return value switch
            {
                "undefined" => ClientToolResultPayloadErrorType.Undefined,
                "implementation-error" => ClientToolResultPayloadErrorType.ImplementationError,
                _ => null,
            };
        }
    }
}