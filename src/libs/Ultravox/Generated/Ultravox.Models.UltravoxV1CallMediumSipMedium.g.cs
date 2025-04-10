
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Details for a SIP call. Exactly one of incoming or outgoing must be set.
    /// </summary>
    public sealed partial class UltravoxV1CallMediumSipMedium
    {
        /// <summary>
        /// Details for an incoming SIP call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incoming")]
        public object? Incoming { get; set; }

        /// <summary>
        /// Details for an outgoing SIP call. Ultravox will initiate this call (and there will be no joinUrl).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outgoing")]
        public global::Ultravox.UltravoxV1SipMediumSipOutgoing? Outgoing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumSipMedium" /> class.
        /// </summary>
        /// <param name="incoming">
        /// Details for an incoming SIP call.
        /// </param>
        /// <param name="outgoing">
        /// Details for an outgoing SIP call. Ultravox will initiate this call (and there will be no joinUrl).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CallMediumSipMedium(
            object? incoming,
            global::Ultravox.UltravoxV1SipMediumSipOutgoing? outgoing)
        {
            this.Incoming = incoming;
            this.Outgoing = outgoing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumSipMedium" /> class.
        /// </summary>
        public UltravoxV1CallMediumSipMedium()
        {
        }
    }
}