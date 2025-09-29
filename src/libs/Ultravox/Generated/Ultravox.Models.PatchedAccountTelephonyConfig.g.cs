
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedAccountTelephonyConfig
    {
        /// <summary>
        /// Your Twilio configuration. See https://console.twilio.com/
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twilio")]
        public global::Ultravox.TwilioConfig? Twilio { get; set; }

        /// <summary>
        /// Your Telnyx configuration. See https://portal.telnyx.com/
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telnyx")]
        public global::Ultravox.TelnyxConfig? Telnyx { get; set; }

        /// <summary>
        /// Your Plivo configuration. See https://console.plivo.com/dashboard/
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plivo")]
        public global::Ultravox.PlivoConfig? Plivo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAccountTelephonyConfig" /> class.
        /// </summary>
        /// <param name="twilio">
        /// Your Twilio configuration. See https://console.twilio.com/
        /// </param>
        /// <param name="telnyx">
        /// Your Telnyx configuration. See https://portal.telnyx.com/
        /// </param>
        /// <param name="plivo">
        /// Your Plivo configuration. See https://console.plivo.com/dashboard/
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedAccountTelephonyConfig(
            global::Ultravox.TwilioConfig? twilio,
            global::Ultravox.TelnyxConfig? telnyx,
            global::Ultravox.PlivoConfig? plivo)
        {
            this.Twilio = twilio;
            this.Telnyx = telnyx;
            this.Plivo = plivo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAccountTelephonyConfig" /> class.
        /// </summary>
        public PatchedAccountTelephonyConfig()
        {
        }
    }
}