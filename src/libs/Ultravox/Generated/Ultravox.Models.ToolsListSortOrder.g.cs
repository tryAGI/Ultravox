
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Default Value: default
    /// </summary>
    public enum ToolsListSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Display,
        /// <summary>
        /// 
        /// </summary>
        Alphabetic,
        /// <summary>
        /// 
        /// </summary>
        ReverseAlphabetic,
        /// <summary>
        /// 
        /// </summary>
        Chronologic,
        /// <summary>
        /// 
        /// </summary>
        ReverseChronologic,
        /// <summary>
        /// 
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolsListSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolsListSortOrder value)
        {
            return value switch
            {
                ToolsListSortOrder.Display => "display",
                ToolsListSortOrder.Alphabetic => "alphabetic",
                ToolsListSortOrder.ReverseAlphabetic => "reverseAlphabetic",
                ToolsListSortOrder.Chronologic => "chronologic",
                ToolsListSortOrder.ReverseChronologic => "reverseChronologic",
                ToolsListSortOrder.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolsListSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "display" => ToolsListSortOrder.Display,
                "alphabetic" => ToolsListSortOrder.Alphabetic,
                "reverseAlphabetic" => ToolsListSortOrder.ReverseAlphabetic,
                "chronologic" => ToolsListSortOrder.Chronologic,
                "reverseChronologic" => ToolsListSortOrder.ReverseChronologic,
                "default" => ToolsListSortOrder.Default,
                _ => null,
            };
        }
    }
}