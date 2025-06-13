
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
                CallsEventsListMinimumSeverity.Error => "error",
                CallsEventsListMinimumSeverity.Info => "info",
                CallsEventsListMinimumSeverity.Warning => "warning",
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
                "error" => CallsEventsListMinimumSeverity.Error,
                "info" => CallsEventsListMinimumSeverity.Info,
                "warning" => CallsEventsListMinimumSeverity.Warning,
                _ => null,
            };
        }
    }
}