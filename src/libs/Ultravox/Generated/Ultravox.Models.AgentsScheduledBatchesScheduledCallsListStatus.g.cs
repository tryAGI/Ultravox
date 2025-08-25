
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsScheduledBatchesScheduledCallsListStatus
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
    public static class AgentsScheduledBatchesScheduledCallsListStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsScheduledBatchesScheduledCallsListStatus value)
        {
            return value switch
            {
                AgentsScheduledBatchesScheduledCallsListStatus.FUTURE => "FUTURE",
                AgentsScheduledBatchesScheduledCallsListStatus.PENDING => "PENDING",
                AgentsScheduledBatchesScheduledCallsListStatus.SUCCESS => "SUCCESS",
                AgentsScheduledBatchesScheduledCallsListStatus.EXPIRED => "EXPIRED",
                AgentsScheduledBatchesScheduledCallsListStatus.ERROR => "ERROR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsScheduledBatchesScheduledCallsListStatus? ToEnum(string value)
        {
            return value switch
            {
                "FUTURE" => AgentsScheduledBatchesScheduledCallsListStatus.FUTURE,
                "PENDING" => AgentsScheduledBatchesScheduledCallsListStatus.PENDING,
                "SUCCESS" => AgentsScheduledBatchesScheduledCallsListStatus.SUCCESS,
                "EXPIRED" => AgentsScheduledBatchesScheduledCallsListStatus.EXPIRED,
                "ERROR" => AgentsScheduledBatchesScheduledCallsListStatus.ERROR,
                _ => null,
            };
        }
    }
}