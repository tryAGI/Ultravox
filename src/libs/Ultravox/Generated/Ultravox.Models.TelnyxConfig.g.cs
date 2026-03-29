
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TelnyxConfig
    {
        /// <summary>
        /// List of agents for whom calls may be directly created by this telephony provider to facilitate incoming calls. May not be set if callCreationAllowAllAgents is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callCreationAllowedAgentIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? CallCreationAllowedAgentIds { get; set; }

        /// <summary>
        /// If true, calls may be directly created by this telephony provider for all agents. If false, only agents listed in callCreationAllowedAgentIds are allowed.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callCreationAllowAllAgents")]
        public bool? CallCreationAllowAllAgents { get; set; }

        /// <summary>
        /// Maps (dot separated) request fields to (dot separated) context fields for incoming call creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestContextMapping")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequestContextMapping { get; set; }

        /// <summary>
        /// Your Telnyx Account SID. See https://portal.telnyx.com/#/account/general
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountSid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountSid { get; set; }

        /// <summary>
        /// Your Telnyx API Key. See https://portal.telnyx.com/#/api-keys<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// The prefix of your Telnyx API Key.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyPrefix")]
        public global::Ultravox.KeyPrefix ApiKeyPrefix { get; set; } = default!;

        /// <summary>
        /// Your Telnyx Public Key. See https://portal.telnyx.com/#/api-keys/public-key<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKey")]
        public string? PublicKey { get; set; }

        /// <summary>
        /// The prefix of your Telnyx Public Key.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKeyPrefix")]
        public global::Ultravox.KeyPrefix PublicKeyPrefix { get; set; } = default!;

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
        /// <param name="applicationSid">
        /// Your Telnyx Application SID. This must be configured with an Outbound Voice Profile that allows calls to your destination. See https://portal.telnyx.com/#/call-control/texml
        /// </param>
        /// <param name="callCreationAllowedAgentIds">
        /// List of agents for whom calls may be directly created by this telephony provider to facilitate incoming calls. May not be set if callCreationAllowAllAgents is true.
        /// </param>
        /// <param name="callCreationAllowAllAgents">
        /// If true, calls may be directly created by this telephony provider for all agents. If false, only agents listed in callCreationAllowedAgentIds are allowed.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestContextMapping">
        /// Maps (dot separated) request fields to (dot separated) context fields for incoming call creation.
        /// </param>
        /// <param name="apiKey">
        /// Your Telnyx API Key. See https://portal.telnyx.com/#/api-keys<br/>
        /// Included only in requests
        /// </param>
        /// <param name="publicKey">
        /// Your Telnyx Public Key. See https://portal.telnyx.com/#/api-keys/public-key<br/>
        /// Included only in requests
        /// </param>
        /// <param name="apiKeyPrefix">
        /// The prefix of your Telnyx API Key.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="publicKeyPrefix">
        /// The prefix of your Telnyx Public Key.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TelnyxConfig(
            string accountSid,
            string applicationSid,
            global::System.Collections.Generic.IList<global::System.Guid>? callCreationAllowedAgentIds,
            bool? callCreationAllowAllAgents,
            global::System.Collections.Generic.Dictionary<string, string>? requestContextMapping,
            string? apiKey,
            string? publicKey,
            global::Ultravox.KeyPrefix apiKeyPrefix = default!,
            global::Ultravox.KeyPrefix publicKeyPrefix = default!)
        {
            this.CallCreationAllowedAgentIds = callCreationAllowedAgentIds;
            this.CallCreationAllowAllAgents = callCreationAllowAllAgents;
            this.RequestContextMapping = requestContextMapping;
            this.AccountSid = accountSid ?? throw new global::System.ArgumentNullException(nameof(accountSid));
            this.ApiKey = apiKey;
            this.ApiKeyPrefix = apiKeyPrefix;
            this.PublicKey = publicKey;
            this.PublicKeyPrefix = publicKeyPrefix;
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