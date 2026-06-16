
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Details for rejecting a SIP call.
    /// </summary>
    public sealed partial class UltravoxV1SipRejection
    {
        /// <summary>
        /// The SIP response code to return to the caller. Must be a valid<br/>
        ///  SIP rejection code (between 400 and 699 inclusive). Defaults to 603 (Decline).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sipRejectCode")]
        public int? SipRejectCode { get; set; }

        /// <summary>
        /// An optional brief explanation of the rejection for logging.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SipRejection" /> class.
        /// </summary>
        /// <param name="sipRejectCode">
        /// The SIP response code to return to the caller. Must be a valid<br/>
        ///  SIP rejection code (between 400 and 699 inclusive). Defaults to 603 (Decline).
        /// </param>
        /// <param name="message">
        /// An optional brief explanation of the rejection for logging.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1SipRejection(
            int? sipRejectCode,
            string? message)
        {
            this.SipRejectCode = sipRejectCode;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SipRejection" /> class.
        /// </summary>
        public UltravoxV1SipRejection()
        {
        }

    }
}