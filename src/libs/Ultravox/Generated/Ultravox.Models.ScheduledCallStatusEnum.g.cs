
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
        Error,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Future,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Success,
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
                ScheduledCallStatusEnum.Error => "ERROR",
                ScheduledCallStatusEnum.Expired => "EXPIRED",
                ScheduledCallStatusEnum.Future => "FUTURE",
                ScheduledCallStatusEnum.Pending => "PENDING",
                ScheduledCallStatusEnum.Success => "SUCCESS",
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
                "ERROR" => ScheduledCallStatusEnum.Error,
                "EXPIRED" => ScheduledCallStatusEnum.Expired,
                "FUTURE" => ScheduledCallStatusEnum.Future,
                "PENDING" => ScheduledCallStatusEnum.Pending,
                "SUCCESS" => ScheduledCallStatusEnum.Success,
                _ => null,
            };
        }
    }
}