
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public enum SeverityEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Debug,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SeverityEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SeverityEnum value)
        {
            return value switch
            {
                SeverityEnum.Debug => "debug",
                SeverityEnum.Error => "error",
                SeverityEnum.Info => "info",
                SeverityEnum.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SeverityEnum? ToEnum(string value)
        {
            return value switch
            {
                "debug" => SeverityEnum.Debug,
                "error" => SeverityEnum.Error,
                "info" => SeverityEnum.Info,
                "warning" => SeverityEnum.Warning,
                _ => null,
            };
        }
    }
}