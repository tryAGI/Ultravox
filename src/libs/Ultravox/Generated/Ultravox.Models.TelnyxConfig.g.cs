
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TelnyxConfig
    {
        /// <summary>
        /// Your Telnyx Account SID. See https://portal.telnyx.com/#/account/general
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountSid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountSid { get; set; }

        /// <summary>
        /// Your Telnyx API Key. See https://portal.telnyx.com/#/api-keys
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Your Telnyx Public Key. See https://portal.telnyx.com/#/api-keys/public-key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicKey { get; set; }

        /// <summary>
        /// Your Telnyx Application SID. This must be configured with an Outbound Voice Profile that allows calls to your destination. See https://portal.telnyx.com/#/call-control/texml
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applicationSid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApplicationSid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TelnyxConfig" /> class.
        /// </summary>
        /// <param name="accountSid">
        /// Your Telnyx Account SID. See https://portal.telnyx.com/#/account/general
        /// </param>
        /// <param name="apiKey">
        /// Your Telnyx API Key. See https://portal.telnyx.com/#/api-keys
        /// </param>
        /// <param name="publicKey">
        /// Your Telnyx Public Key. See https://portal.telnyx.com/#/api-keys/public-key
        /// </param>
        /// <param name="applicationSid">
        /// Your Telnyx Application SID. This must be configured with an Outbound Voice Profile that allows calls to your destination. See https://portal.telnyx.com/#/call-control/texml
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelnyxConfig(
            string accountSid,
            string apiKey,
            string publicKey,
            string applicationSid)
        {
            this.AccountSid = accountSid ?? throw new global::System.ArgumentNullException(nameof(accountSid));
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.PublicKey = publicKey ?? throw new global::System.ArgumentNullException(nameof(publicKey));
            this.ApplicationSid = applicationSid ?? throw new global::System.ArgumentNullException(nameof(applicationSid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelnyxConfig" /> class.
        /// </summary>
        public TelnyxConfig()
        {
        }
    }
}