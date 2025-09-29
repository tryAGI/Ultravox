
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TelnyxConfigOutput
    {
        /// <summary>
        /// Your Telnyx Account SID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountSid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountSid { get; set; }

        /// <summary>
        /// The prefix of your Telnyx API Key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyPrefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ultravox.KeyPrefix ApiKeyPrefix { get; set; }

        /// <summary>
        /// The prefix of your Telnyx Public Key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKeyPrefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ultravox.KeyPrefix PublicKeyPrefix { get; set; }

        /// <summary>
        /// Your Telnyx Application SID.
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
        /// Initializes a new instance of the <see cref="TelnyxConfigOutput" /> class.
        /// </summary>
        /// <param name="accountSid">
        /// Your Telnyx Account SID.
        /// </param>
        /// <param name="apiKeyPrefix">
        /// The prefix of your Telnyx API Key.
        /// </param>
        /// <param name="publicKeyPrefix">
        /// The prefix of your Telnyx Public Key.
        /// </param>
        /// <param name="applicationSid">
        /// Your Telnyx Application SID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelnyxConfigOutput(
            string accountSid,
            global::Ultravox.KeyPrefix apiKeyPrefix,
            global::Ultravox.KeyPrefix publicKeyPrefix,
            string applicationSid)
        {
            this.AccountSid = accountSid ?? throw new global::System.ArgumentNullException(nameof(accountSid));
            this.ApiKeyPrefix = apiKeyPrefix ?? throw new global::System.ArgumentNullException(nameof(apiKeyPrefix));
            this.PublicKeyPrefix = publicKeyPrefix ?? throw new global::System.ArgumentNullException(nameof(publicKeyPrefix));
            this.ApplicationSid = applicationSid ?? throw new global::System.ArgumentNullException(nameof(applicationSid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelnyxConfigOutput" /> class.
        /// </summary>
        public TelnyxConfigOutput()
        {
        }
    }
}