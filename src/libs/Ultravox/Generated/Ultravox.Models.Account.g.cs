
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Account
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingUrl")]
        public string BillingUrl { get; set; } = default!;

        /// <summary>
        /// How much free time has been used by previous (or ongoing) calls.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("freeTimeUsed")]
        public string FreeTimeUsed { get; set; } = default!;

        /// <summary>
        /// How much free call time this account has remaining. (This could increase if an existing call ends without using its maximum duration or an unjoined call times out.)<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("freeTimeRemaining")]
        public string FreeTimeRemaining { get; set; } = default!;

        /// <summary>
        /// Whether the account has an active subscription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasActiveSubscription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasActiveSubscription { get; set; }

        /// <summary>
        /// The current subscription tier for this account.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionTier")]
        public string? SubscriptionTier { get; set; }

        /// <summary>
        /// How often the subscription is billed for this account.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionCadence")]
        public string? SubscriptionCadence { get; set; }

        /// <summary>
        /// The expiration date of the current subscription for this account, if any. This is the point at which access will end unless credit remains.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionExpiration")]
        public global::System.DateTime? SubscriptionExpiration { get; set; }

        /// <summary>
        /// The point in the future where this account's subscription is scheduled to change.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionScheduledUpdate")]
        public global::System.DateTime? SubscriptionScheduledUpdate { get; set; }

        /// <summary>
        /// When this account's subscription renews, if applicable.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionRenewal")]
        public global::System.DateTime? SubscriptionRenewal { get; set; }

        /// <summary>
        /// The number of active calls for this account.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeCalls")]
        public int ActiveCalls { get; set; } = default!;

        /// <summary>
        /// The maximum number of concurrent calls allowed for this account.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedConcurrentCalls")]
        public int? AllowedConcurrentCalls { get; set; }

        /// <summary>
        /// The maximum number of custom voices allowed for this account.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedVoices")]
        public int? AllowedVoices { get; set; }

        /// <summary>
        /// The maximum number of corpora allowed for this account.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedCorpora")]
        public int? AllowedCorpora { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        /// <param name="name">
        /// Included only in responses
        /// </param>
        /// <param name="billingUrl">
        /// Included only in responses
        /// </param>
        /// <param name="freeTimeUsed">
        /// How much free time has been used by previous (or ongoing) calls.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="freeTimeRemaining">
        /// How much free call time this account has remaining. (This could increase if an existing call ends without using its maximum duration or an unjoined call times out.)<br/>
        /// Included only in responses
        /// </param>
        /// <param name="hasActiveSubscription">
        /// Whether the account has an active subscription.
        /// </param>
        /// <param name="subscriptionTier">
        /// The current subscription tier for this account.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="subscriptionCadence">
        /// How often the subscription is billed for this account.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="subscriptionExpiration">
        /// The expiration date of the current subscription for this account, if any. This is the point at which access will end unless credit remains.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="subscriptionScheduledUpdate">
        /// The point in the future where this account's subscription is scheduled to change.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="subscriptionRenewal">
        /// When this account's subscription renews, if applicable.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="activeCalls">
        /// The number of active calls for this account.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="allowedConcurrentCalls">
        /// The maximum number of concurrent calls allowed for this account.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="allowedVoices">
        /// The maximum number of custom voices allowed for this account.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="allowedCorpora">
        /// The maximum number of corpora allowed for this account.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Account(
            bool hasActiveSubscription,
            string? subscriptionTier,
            string? subscriptionCadence,
            global::System.DateTime? subscriptionExpiration,
            global::System.DateTime? subscriptionScheduledUpdate,
            global::System.DateTime? subscriptionRenewal,
            int? allowedConcurrentCalls,
            int? allowedVoices,
            int? allowedCorpora,
            string name = default!,
            string billingUrl = default!,
            string freeTimeUsed = default!,
            string freeTimeRemaining = default!,
            int activeCalls = default!)
        {
            this.HasActiveSubscription = hasActiveSubscription;
            this.Name = name;
            this.BillingUrl = billingUrl;
            this.FreeTimeUsed = freeTimeUsed;
            this.FreeTimeRemaining = freeTimeRemaining;
            this.SubscriptionTier = subscriptionTier;
            this.SubscriptionCadence = subscriptionCadence;
            this.SubscriptionExpiration = subscriptionExpiration;
            this.SubscriptionScheduledUpdate = subscriptionScheduledUpdate;
            this.SubscriptionRenewal = subscriptionRenewal;
            this.ActiveCalls = activeCalls;
            this.AllowedConcurrentCalls = allowedConcurrentCalls;
            this.AllowedVoices = allowedVoices;
            this.AllowedCorpora = allowedCorpora;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        public Account()
        {
        }
    }
}