
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Configuration for how incoming DTMF digits are handled during a call.<br/>
    ///  When dtmf_handling is absent from the enclosing medium, DTMF digits are<br/>
    ///  sent as a user text message containing just the digits with urgency<br/>
    ///  URGENCY_IMMEDIATE (the default behavior).<br/>
    ///  Note: consecutive DTMF digits are batched together with a short delay<br/>
    ///  before being dispatched, so a rapid sequence of key presses will be<br/>
    ///  delivered as a single message.
    /// </summary>
    public sealed partial class UltravoxV1CallMediumDtmfHandling
    {
        /// <summary>
        /// If true, DTMF digits are ignored entirely.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore")]
        public bool? Ignore { get; set; }

        /// <summary>
        /// Customizes how DTMF digits are sent as a user text message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userTextMessage")]
        public global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessage? UserTextMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumDtmfHandling" /> class.
        /// </summary>
        /// <param name="ignore">
        /// If true, DTMF digits are ignored entirely.
        /// </param>
        /// <param name="userTextMessage">
        /// Customizes how DTMF digits are sent as a user text message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CallMediumDtmfHandling(
            bool? ignore,
            global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessage? userTextMessage)
        {
            this.Ignore = ignore;
            this.UserTextMessage = userTextMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumDtmfHandling" /> class.
        /// </summary>
        public UltravoxV1CallMediumDtmfHandling()
        {
        }
    }
}