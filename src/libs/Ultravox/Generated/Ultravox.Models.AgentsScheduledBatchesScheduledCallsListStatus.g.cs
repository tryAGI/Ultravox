
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
    public static class AgentsScheduledBatchesScheduledCallsListStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsScheduledBatchesScheduledCallsListStatus value)
        {
            return value switch
            {
                AgentsScheduledBatchesScheduledCallsListStatus.Error => "ERROR",
                AgentsScheduledBatchesScheduledCallsListStatus.Expired => "EXPIRED",
                AgentsScheduledBatchesScheduledCallsListStatus.Future => "FUTURE",
                AgentsScheduledBatchesScheduledCallsListStatus.Pending => "PENDING",
                AgentsScheduledBatchesScheduledCallsListStatus.Success => "SUCCESS",
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
                "ERROR" => AgentsScheduledBatchesScheduledCallsListStatus.Error,
                "EXPIRED" => AgentsScheduledBatchesScheduledCallsListStatus.Expired,
                "FUTURE" => AgentsScheduledBatchesScheduledCallsListStatus.Future,
                "PENDING" => AgentsScheduledBatchesScheduledCallsListStatus.Pending,
                "SUCCESS" => AgentsScheduledBatchesScheduledCallsListStatus.Success,
                _ => null,
            };
        }
    }
}