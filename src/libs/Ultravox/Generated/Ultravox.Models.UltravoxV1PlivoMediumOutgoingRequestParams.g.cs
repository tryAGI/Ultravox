
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Parameters for a Plivo call creation request.
    /// </summary>
    public sealed partial class UltravoxV1PlivoMediumOutgoingRequestParams
    {
        /// <summary>
        /// The phone number(s) or sip URI(s) to call, separated by `&lt;` if multiple.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// The phone number initiating the call, in E.164 format (e.g. +14155552671).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// Additional parameters to include in the Plivo call creation request.<br/>
        ///  See https://www.plivo.com/docs/voice/api/call/make-a-call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalParams")]
        public object? AdditionalParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1PlivoMediumOutgoingRequestParams" /> class.
        /// </summary>
        /// <param name="to">
        /// The phone number(s) or sip URI(s) to call, separated by `&lt;` if multiple.
        /// </param>
        /// <param name="from">
        /// The phone number initiating the call, in E.164 format (e.g. +14155552671).
        /// </param>
        /// <param name="additionalParams">
        /// Additional parameters to include in the Plivo call creation request.<br/>
        ///  See https://www.plivo.com/docs/voice/api/call/make-a-call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1PlivoMediumOutgoingRequestParams(
            string? to,
            string? from,
            object? additionalParams)
        {
            this.To = to;
            this.From = from;
            this.AdditionalParams = additionalParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1PlivoMediumOutgoingRequestParams" /> class.
        /// </summary>
        public UltravoxV1PlivoMediumOutgoingRequestParams()
        {
        }
    }
}