
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// * `normal` - NORMAL<br/>
    /// * `unhealthy` - UNHEALTHY
    /// </summary>
    public enum StatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Normal,
        /// <summary>
        /// 
        /// </summary>
        Unhealthy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatusEnum value)
        {
            return value switch
            {
                StatusEnum.Normal => "normal",
                StatusEnum.Unhealthy => "unhealthy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "normal" => StatusEnum.Normal,
                "unhealthy" => StatusEnum.Unhealthy,
                _ => null,
            };
        }
    }
}