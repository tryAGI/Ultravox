
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Account(
            bool hasActiveSubscription,
            string name = default!,
            string billingUrl = default!,
            string freeTimeUsed = default!,
            string freeTimeRemaining = default!)
        {
            this.HasActiveSubscription = hasActiveSubscription;
            this.Name = name;
            this.BillingUrl = billingUrl;
            this.FreeTimeUsed = freeTimeUsed;
            this.FreeTimeRemaining = freeTimeRemaining;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        public Account()
        {
        }
    }
}