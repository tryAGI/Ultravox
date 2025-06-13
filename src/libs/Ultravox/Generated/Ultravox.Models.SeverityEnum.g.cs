
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
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warning,
        /// <summary>
        /// 
        /// </summary>
        Error,
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
                SeverityEnum.Info => "info",
                SeverityEnum.Warning => "warning",
                SeverityEnum.Error => "error",
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
                "info" => SeverityEnum.Info,
                "warning" => SeverityEnum.Warning,
                "error" => SeverityEnum.Error,
                _ => null,
            };
        }
    }
}