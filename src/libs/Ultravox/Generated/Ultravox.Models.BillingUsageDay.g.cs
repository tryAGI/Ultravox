
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BillingUsageDay
    {
        /// <summary>
        /// The date (UTC) of the usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime Date { get; set; } = default!;

        /// <summary>
        /// Total minutes billed on this date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double Minutes { get; set; } = default!;

        /// <summary>
        /// Total SIP minutes billed on this date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sipMinutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double SipMinutes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageDay" /> class.
        /// </summary>
        /// <param name="date">
        /// The date (UTC) of the usage.
        /// </param>
        /// <param name="minutes">
        /// Total minutes billed on this date.
        /// </param>
        /// <param name="sipMinutes">
        /// Total SIP minutes billed on this date.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BillingUsageDay(
            global::System.DateTime date,
            double minutes,
            double sipMinutes)
        {
            this.Date = date;
            this.Minutes = minutes;
            this.SipMinutes = sipMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingUsageDay" /> class.
        /// </summary>
        public BillingUsageDay()
        {
        }
    }
}