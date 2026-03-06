
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolsListOwnership
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
    public static class ToolsListOwnershipExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsListOwnership value)
        {
            return value switch
            {
                ToolsListOwnership.Private => "private",
                ToolsListOwnership.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsListOwnership? ToEnum(string value)
        {
            return value switch
            {
                "private" => ToolsListOwnership.Private,
                "public" => ToolsListOwnership.Public,
                _ => null,
            };
        }
    }
}