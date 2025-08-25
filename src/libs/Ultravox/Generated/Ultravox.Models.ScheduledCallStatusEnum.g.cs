
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduledCallStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        FUTURE,
        /// <summary>
        /// 
        /// </summary>
        PENDING,
        /// <summary>
        /// 
        /// </summary>
        SUCCESS,
        /// <summary>
        /// 
        /// </summary>
        EXPIRED,
        /// <summary>
        /// 
        /// </summary>
        ERROR,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledCallStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledCallStatusEnum value)
        {
            return value switch
            {
                ScheduledCallStatusEnum.FUTURE => "FUTURE",
                ScheduledCallStatusEnum.PENDING => "PENDING",
                ScheduledCallStatusEnum.SUCCESS => "SUCCESS",
                ScheduledCallStatusEnum.EXPIRED => "EXPIRED",
                ScheduledCallStatusEnum.ERROR => "ERROR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledCallStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "FUTURE" => ScheduledCallStatusEnum.FUTURE,
                "PENDING" => ScheduledCallStatusEnum.PENDING,
                "SUCCESS" => ScheduledCallStatusEnum.SUCCESS,
                "EXPIRED" => ScheduledCallStatusEnum.EXPIRED,
                "ERROR" => ScheduledCallStatusEnum.ERROR,
                _ => null,
            };
        }
    }
}