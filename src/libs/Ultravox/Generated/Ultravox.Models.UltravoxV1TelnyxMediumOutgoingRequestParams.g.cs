
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Parameters for a Telnyx call creation request.
    /// </summary>
    public sealed partial class UltravoxV1TelnyxMediumOutgoingRequestParams
    {
        /// <summary>
        /// The phone number to call in E.164 format (e.g. +14155552671).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// The phone number initiating the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// Additional parameters to include in the Telnyx call creation request.<br/>
        ///  See https://developers.telnyx.com/api/call-scripting/initiate-texml-call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalParams")]
        public object? AdditionalParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TelnyxMediumOutgoingRequestParams" /> class.
        /// </summary>
        /// <param name="to">
        /// The phone number to call in E.164 format (e.g. +14155552671).
        /// </param>
        /// <param name="from">
        /// The phone number initiating the call.
        /// </param>
        /// <param name="additionalParams">
        /// Additional parameters to include in the Telnyx call creation request.<br/>
        ///  See https://developers.telnyx.com/api/call-scripting/initiate-texml-call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1TelnyxMediumOutgoingRequestParams(
            string? to,
            string? from,
            object? additionalParams)
        {
            this.To = to;
            this.From = from;
            this.AdditionalParams = additionalParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TelnyxMediumOutgoingRequestParams" /> class.
        /// </summary>
        public UltravoxV1TelnyxMediumOutgoingRequestParams()
        {
        }
    }
}