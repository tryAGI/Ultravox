
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// * `manual` - manual<br/>
    /// * `subscription_create` - subscription_create<br/>
    /// * `subscription_cycle` - subscription_cycle<br/>
    /// * `subscription_threshold` - subscription_threshold<br/>
    /// * `subscription_update` - subscription_update
    /// </summary>
    public enum BillingReasonEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionCreate,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionCycle,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionThreshold,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillingReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillingReasonEnum value)
        {
            return value switch
            {
                BillingReasonEnum.Manual => "manual",
                BillingReasonEnum.SubscriptionCreate => "subscription_create",
                BillingReasonEnum.SubscriptionCycle => "subscription_cycle",
                BillingReasonEnum.SubscriptionThreshold => "subscription_threshold",
                BillingReasonEnum.SubscriptionUpdate => "subscription_update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillingReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "manual" => BillingReasonEnum.Manual,
                "subscription_create" => BillingReasonEnum.SubscriptionCreate,
                "subscription_cycle" => BillingReasonEnum.SubscriptionCycle,
                "subscription_threshold" => BillingReasonEnum.SubscriptionThreshold,
                "subscription_update" => BillingReasonEnum.SubscriptionUpdate,
                _ => null,
            };
        }
    }
}