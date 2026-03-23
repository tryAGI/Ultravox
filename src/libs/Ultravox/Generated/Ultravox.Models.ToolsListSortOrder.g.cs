
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
        Alphabetic,
        /// <summary>
        /// 
        /// </summary>
        Chronologic,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Display,
        /// <summary>
        /// 
        /// </summary>
        ReverseAlphabetic,
        /// <summary>
        /// 
        /// </summary>
        ReverseChronologic,
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
                ToolsListSortOrder.Alphabetic => "alphabetic",
                ToolsListSortOrder.Chronologic => "chronologic",
                ToolsListSortOrder.Default => "default",
                ToolsListSortOrder.Display => "display",
                ToolsListSortOrder.ReverseAlphabetic => "reverseAlphabetic",
                ToolsListSortOrder.ReverseChronologic => "reverseChronologic",
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
                "alphabetic" => ToolsListSortOrder.Alphabetic,
                "chronologic" => ToolsListSortOrder.Chronologic,
                "default" => ToolsListSortOrder.Default,
                "display" => ToolsListSortOrder.Display,
                "reverseAlphabetic" => ToolsListSortOrder.ReverseAlphabetic,
                "reverseChronologic" => ToolsListSortOrder.ReverseChronologic,
                _ => null,
            };
        }
    }
}