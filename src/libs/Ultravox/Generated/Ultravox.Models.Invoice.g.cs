
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Invoice
    {
        /// <summary>
        /// When the invoice became effective.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoiceDate")]
        public global::System.DateTime InvoiceDate { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.BillingReasonEnumJsonConverter))]
        public global::Ultravox.BillingReasonEnum BillingReason { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoiceNumber")]
        public string InvoiceNumber { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoiceStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.InvoiceStatusEnumJsonConverter))]
        public global::Ultravox.InvoiceStatusEnum InvoiceStatus { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoiceUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvoiceUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        /// <param name="invoiceDate">
        /// When the invoice became effective.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="amount">
        /// Included only in responses
        /// </param>
        /// <param name="billingReason">
        /// Included only in responses
        /// </param>
        /// <param name="invoiceNumber">
        /// Included only in responses
        /// </param>
        /// <param name="invoiceStatus">
        /// Included only in responses
        /// </param>
        /// <param name="invoiceUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Invoice(
            string invoiceUrl,
            global::System.DateTime invoiceDate = default!,
            int amount = default!,
            global::Ultravox.BillingReasonEnum billingReason = default!,
            string invoiceNumber = default!,
            global::Ultravox.InvoiceStatusEnum invoiceStatus = default!)
        {
            this.InvoiceUrl = invoiceUrl ?? throw new global::System.ArgumentNullException(nameof(invoiceUrl));
            this.InvoiceDate = invoiceDate;
            this.Amount = amount;
            this.BillingReason = billingReason;
            this.InvoiceNumber = invoiceNumber;
            this.InvoiceStatus = invoiceStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" /> class.
        /// </summary>
        public Invoice()
        {
        }
    }
}