
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// * BILLING_STATUS_PENDING* - The call hasn't been billed yet, but will be in the future. This is the case for ongoing calls for example. (Note: Calls created before May 28, 2025 may have this status even if they were billed.)<br/>
    /// * BILLING_STATUS_FREE_CONSOLE* - The call was free because it was initiated on https://app.ultravox.ai.<br/>
    /// * BILLING_STATUS_FREE_ZERO_EFFECTIVE_DURATION* - The call was free because its effective duration was zero. (Note: There may still be a non-zero sip bill in this case.)<br/>
    /// * BILLING_STATUS_FREE_MINUTES* - The call was unbilled but counted against the account's free minutes. (Note: There may still be a non-zero sip bill in this case.)<br/>
    /// * BILLING_STATUS_FREE_SYSTEM_ERROR* - The call was free because it ended due to a system error.<br/>
    /// * BILLING_STATUS_FREE_OTHER* - The call is in an undocumented free billing state.<br/>
    /// * BILLING_STATUS_BILLED* - The call was billed. See billedDuration for the billed duration.<br/>
    /// * BILLING_STATUS_REFUNDED* - The call was billed but was later refunded.<br/>
    /// * BILLING_STATUS_UNSPECIFIED* - The call is in an unexpected billing state. Please contact support.
    /// </summary>
    public enum BillingStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        BillingStatusBilled,
        /// <summary>
        /// //app.ultravox.ai.
        /// </summary>
        BillingStatusFreeConsole,
        /// <summary>
        /// There may still be a non-zero sip bill in this case.)
        /// </summary>
        BillingStatusFreeMinutes,
        /// <summary>
        /// 
        /// </summary>
        BillingStatusFreeOther,
        /// <summary>
        /// 
        /// </summary>
        BillingStatusFreeSystemError,
        /// <summary>
        /// There may still be a non-zero sip bill in this case.)
        /// </summary>
        BillingStatusFreeZeroEffectiveDuration,
        /// <summary>
        /// Calls created before May 28, 2025 may have this status even if they were billed.)
        /// </summary>
        BillingStatusPending,
        /// <summary>
        /// 
        /// </summary>
        BillingStatusRefunded,
        /// <summary>
        /// 
        /// </summary>
        BillingStatusUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingStatusEnum value)
        {
            return value switch
            {
                BillingStatusEnum.BillingStatusBilled => "BILLING_STATUS_BILLED",
                BillingStatusEnum.BillingStatusFreeConsole => "BILLING_STATUS_FREE_CONSOLE",
                BillingStatusEnum.BillingStatusFreeMinutes => "BILLING_STATUS_FREE_MINUTES",
                BillingStatusEnum.BillingStatusFreeOther => "BILLING_STATUS_FREE_OTHER",
                BillingStatusEnum.BillingStatusFreeSystemError => "BILLING_STATUS_FREE_SYSTEM_ERROR",
                BillingStatusEnum.BillingStatusFreeZeroEffectiveDuration => "BILLING_STATUS_FREE_ZERO_EFFECTIVE_DURATION",
                BillingStatusEnum.BillingStatusPending => "BILLING_STATUS_PENDING",
                BillingStatusEnum.BillingStatusRefunded => "BILLING_STATUS_REFUNDED",
                BillingStatusEnum.BillingStatusUnspecified => "BILLING_STATUS_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "BILLING_STATUS_BILLED" => BillingStatusEnum.BillingStatusBilled,
                "BILLING_STATUS_FREE_CONSOLE" => BillingStatusEnum.BillingStatusFreeConsole,
                "BILLING_STATUS_FREE_MINUTES" => BillingStatusEnum.BillingStatusFreeMinutes,
                "BILLING_STATUS_FREE_OTHER" => BillingStatusEnum.BillingStatusFreeOther,
                "BILLING_STATUS_FREE_SYSTEM_ERROR" => BillingStatusEnum.BillingStatusFreeSystemError,
                "BILLING_STATUS_FREE_ZERO_EFFECTIVE_DURATION" => BillingStatusEnum.BillingStatusFreeZeroEffectiveDuration,
                "BILLING_STATUS_PENDING" => BillingStatusEnum.BillingStatusPending,
                "BILLING_STATUS_REFUNDED" => BillingStatusEnum.BillingStatusRefunded,
                "BILLING_STATUS_UNSPECIFIED" => BillingStatusEnum.BillingStatusUnspecified,
                _ => null,
            };
        }
    }
}