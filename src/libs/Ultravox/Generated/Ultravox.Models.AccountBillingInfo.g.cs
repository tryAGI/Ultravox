
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountBillingInfo
    {
        /// <summary>
        /// Obfuscated current payment method.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paymentMethod")]
        public string? PaymentMethod { get; set; }

        /// <summary>
        /// Email address for billing notifications.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingEmail")]
        public string? BillingEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBillingInfo" /> class.
        /// </summary>
        /// <param name="paymentMethod">
        /// Obfuscated current payment method.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="billingEmail">
        /// Email address for billing notifications.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountBillingInfo(
            string? paymentMethod,
            string? billingEmail)
        {
            this.PaymentMethod = paymentMethod;
            this.BillingEmail = billingEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBillingInfo" /> class.
        /// </summary>
        public AccountBillingInfo()
        {
        }
    }
}