
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedTelnyxConfig
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
        public string? AccountSid { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyPrefix")]
        public global::Ultravox.KeyPrefix? ApiKeyPrefix { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKeyPrefix")]
        public global::Ultravox.KeyPrefix? PublicKeyPrefix { get; set; }

        /// <summary>
        /// Your Telnyx Application SID. This must be configured with an Outbound Voice Profile that allows calls to your destination. See https://portal.telnyx.com/#/call-control/texml
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applicationSid")]
        public string? ApplicationSid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedTelnyxConfig" /> class.
        /// </summary>
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
        /// <param name="accountSid">
        /// Your Telnyx Account SID. See https://portal.telnyx.com/#/account/general
        /// </param>
        /// <param name="apiKey">
        /// Your Telnyx API Key. See https://portal.telnyx.com/#/api-keys<br/>
        /// Included only in requests
        /// </param>
        /// <param name="apiKeyPrefix">
        /// The prefix of your Telnyx API Key.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="publicKey">
        /// Your Telnyx Public Key. See https://portal.telnyx.com/#/api-keys/public-key<br/>
        /// Included only in requests
        /// </param>
        /// <param name="publicKeyPrefix">
        /// The prefix of your Telnyx Public Key.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="applicationSid">
        /// Your Telnyx Application SID. This must be configured with an Outbound Voice Profile that allows calls to your destination. See https://portal.telnyx.com/#/call-control/texml
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedTelnyxConfig(
            global::System.Collections.Generic.IList<global::System.Guid>? callCreationAllowedAgentIds,
            bool? callCreationAllowAllAgents,
            global::System.Collections.Generic.Dictionary<string, string>? requestContextMapping,
            string? accountSid,
            string? apiKey,
            global::Ultravox.KeyPrefix? apiKeyPrefix,
            string? publicKey,
            global::Ultravox.KeyPrefix? publicKeyPrefix,
            string? applicationSid)
        {
            this.CallCreationAllowedAgentIds = callCreationAllowedAgentIds;
            this.CallCreationAllowAllAgents = callCreationAllowAllAgents;
            this.RequestContextMapping = requestContextMapping;
            this.AccountSid = accountSid;
            this.ApiKey = apiKey;
            this.ApiKeyPrefix = apiKeyPrefix;
            this.PublicKey = publicKey;
            this.PublicKeyPrefix = publicKeyPrefix;
            this.ApplicationSid = applicationSid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedTelnyxConfig" /> class.
        /// </summary>
        public PatchedTelnyxConfig()
        {
        }
    }
}