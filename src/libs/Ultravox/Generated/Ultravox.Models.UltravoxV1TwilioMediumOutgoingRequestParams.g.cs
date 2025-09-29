
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Parameters for a Twilio call creation request.
    /// </summary>
    public sealed partial class UltravoxV1TwilioMediumOutgoingRequestParams
    {
        /// <summary>
        /// The phone number, in E.164 format (e.g. +14155552671), (or sip address) to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// The phone number or client identifier to use as the caller id. If `to` is a phone<br/>
        ///  number, `from` must be a phone number owned by your Twilio account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// Additional parameters to include in the Twilio call creation request.<br/>
        ///  See https://www.twilio.com/docs/voice/api/call-resource#request-body-parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalParams")]
        public object? AdditionalParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TwilioMediumOutgoingRequestParams" /> class.
        /// </summary>
        /// <param name="to">
        /// The phone number, in E.164 format (e.g. +14155552671), (or sip address) to call.
        /// </param>
        /// <param name="from">
        /// The phone number or client identifier to use as the caller id. If `to` is a phone<br/>
        ///  number, `from` must be a phone number owned by your Twilio account.
        /// </param>
        /// <param name="additionalParams">
        /// Additional parameters to include in the Twilio call creation request.<br/>
        ///  See https://www.twilio.com/docs/voice/api/call-resource#request-body-parameters
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1TwilioMediumOutgoingRequestParams(
            string? to,
            string? from,
            object? additionalParams)
        {
            this.To = to;
            this.From = from;
            this.AdditionalParams = additionalParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TwilioMediumOutgoingRequestParams" /> class.
        /// </summary>
        public UltravoxV1TwilioMediumOutgoingRequestParams()
        {
        }
    }
}