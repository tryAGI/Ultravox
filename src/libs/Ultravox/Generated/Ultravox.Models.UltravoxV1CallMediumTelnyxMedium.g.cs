
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Details for a Telnyx call.
    /// </summary>
    public sealed partial class UltravoxV1CallMediumTelnyxMedium
    {
        /// <summary>
        /// If set, Ultravox will directly create a call with Telnyx. Telnyx must be configured<br/>
        ///  for the requesting account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outgoing")]
        public global::Ultravox.UltravoxV1TelnyxMediumOutgoingRequestParams? Outgoing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumTelnyxMedium" /> class.
        /// </summary>
        /// <param name="outgoing">
        /// If set, Ultravox will directly create a call with Telnyx. Telnyx must be configured<br/>
        ///  for the requesting account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CallMediumTelnyxMedium(
            global::Ultravox.UltravoxV1TelnyxMediumOutgoingRequestParams? outgoing)
        {
            this.Outgoing = outgoing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumTelnyxMedium" /> class.
        /// </summary>
        public UltravoxV1CallMediumTelnyxMedium()
        {
        }
    }
}