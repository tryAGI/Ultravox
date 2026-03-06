
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Default Value: info
    /// </summary>
    public enum CallsEventsListMinimumSeverity
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
    public static class CallsEventsListMinimumSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallsEventsListMinimumSeverity value)
        {
            return value switch
            {
                CallsEventsListMinimumSeverity.Debug => "debug",
                CallsEventsListMinimumSeverity.Info => "info",
                CallsEventsListMinimumSeverity.Warning => "warning",
                CallsEventsListMinimumSeverity.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallsEventsListMinimumSeverity? ToEnum(string value)
        {
            return value switch
            {
                "debug" => CallsEventsListMinimumSeverity.Debug,
                "info" => CallsEventsListMinimumSeverity.Info,
                "warning" => CallsEventsListMinimumSeverity.Warning,
                "error" => CallsEventsListMinimumSeverity.Error,
                _ => null,
            };
        }
    }
}