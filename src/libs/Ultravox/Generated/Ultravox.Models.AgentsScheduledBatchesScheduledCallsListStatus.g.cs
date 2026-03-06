
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
        Future,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Error,
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
                AgentsScheduledBatchesScheduledCallsListStatus.Future => "FUTURE",
                AgentsScheduledBatchesScheduledCallsListStatus.Pending => "PENDING",
                AgentsScheduledBatchesScheduledCallsListStatus.Success => "SUCCESS",
                AgentsScheduledBatchesScheduledCallsListStatus.Expired => "EXPIRED",
                AgentsScheduledBatchesScheduledCallsListStatus.Error => "ERROR",
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
                "FUTURE" => AgentsScheduledBatchesScheduledCallsListStatus.Future,
                "PENDING" => AgentsScheduledBatchesScheduledCallsListStatus.Pending,
                "SUCCESS" => AgentsScheduledBatchesScheduledCallsListStatus.Success,
                "EXPIRED" => AgentsScheduledBatchesScheduledCallsListStatus.Expired,
                "ERROR" => AgentsScheduledBatchesScheduledCallsListStatus.Error,
                _ => null,
            };
        }
    }
}