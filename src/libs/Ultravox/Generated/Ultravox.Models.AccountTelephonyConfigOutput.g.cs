
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountTelephonyConfigOutput
    {
        /// <summary>
        /// Your Twilio configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twilio")]
        public global::Ultravox.TwilioConfigOutput? Twilio { get; set; }

        /// <summary>
        /// Your Telnyx configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telnyx")]
        public global::Ultravox.TelnyxConfigOutput? Telnyx { get; set; }

        /// <summary>
        /// Your Plivo configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plivo")]
        public global::Ultravox.PlivoConfigOutput? Plivo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTelephonyConfigOutput" /> class.
        /// </summary>
        /// <param name="twilio">
        /// Your Twilio configuration.
        /// </param>
        /// <param name="telnyx">
        /// Your Telnyx configuration.
        /// </param>
        /// <param name="plivo">
        /// Your Plivo configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountTelephonyConfigOutput(
            global::Ultravox.TwilioConfigOutput? twilio,
            global::Ultravox.TelnyxConfigOutput? telnyx,
            global::Ultravox.PlivoConfigOutput? plivo)
        {
            this.Twilio = twilio;
            this.Telnyx = telnyx;
            this.Plivo = plivo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTelephonyConfigOutput" /> class.
        /// </summary>
        public AccountTelephonyConfigOutput()
        {
        }
    }
}