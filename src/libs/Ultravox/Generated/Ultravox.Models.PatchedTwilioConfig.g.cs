
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedTwilioConfig
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
        /// Your Twilio Account SID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountSid")]
        public string? AccountSid { get; set; }

        /// <summary>
        /// Your Twilio Auth Token.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authToken")]
        public string? AuthToken { get; set; }

        /// <summary>
        /// The prefix of your Twilio Auth Token.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authTokenPrefix")]
        public global::Ultravox.KeyPrefix? AuthTokenPrefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedTwilioConfig" /> class.
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
        /// Your Twilio Account SID.
        /// </param>
        /// <param name="authToken">
        /// Your Twilio Auth Token.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="authTokenPrefix">
        /// The prefix of your Twilio Auth Token.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedTwilioConfig(
            global::System.Collections.Generic.IList<global::System.Guid>? callCreationAllowedAgentIds,
            bool? callCreationAllowAllAgents,
            global::System.Collections.Generic.Dictionary<string, string>? requestContextMapping,
            string? accountSid,
            string? authToken,
            global::Ultravox.KeyPrefix? authTokenPrefix)
        {
            this.CallCreationAllowedAgentIds = callCreationAllowedAgentIds;
            this.CallCreationAllowAllAgents = callCreationAllowAllAgents;
            this.RequestContextMapping = requestContextMapping;
            this.AccountSid = accountSid;
            this.AuthToken = authToken;
            this.AuthTokenPrefix = authTokenPrefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedTwilioConfig" /> class.
        /// </summary>
        public PatchedTwilioConfig()
        {
        }

    }
}