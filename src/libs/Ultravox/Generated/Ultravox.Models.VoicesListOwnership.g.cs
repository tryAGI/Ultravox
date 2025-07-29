
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoicesListOwnership
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicesListOwnershipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicesListOwnership value)
        {
            return value switch
            {
                VoicesListOwnership.Private => "private",
                VoicesListOwnership.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicesListOwnership? ToEnum(string value)
        {
            return value switch
            {
                "private" => VoicesListOwnership.Private,
                "public" => VoicesListOwnership.Public,
                _ => null,
            };
        }
    }
}