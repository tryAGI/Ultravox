
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlivoConfig
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
        /// Your Plivo Auth ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthId { get; set; }

        /// <summary>
        /// Your Plivo Auth Token.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authToken")]
        public string? AuthToken { get; set; }

        /// <summary>
        /// The prefix of your Plivo Auth Token.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("authTokenPrefix")]
        public global::Ultravox.KeyPrefix AuthTokenPrefix { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlivoConfig" /> class.
        /// </summary>
        /// <param name="authId">
        /// Your Plivo Auth ID.
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
        /// <param name="authToken">
        /// Your Plivo Auth Token.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="authTokenPrefix">
        /// The prefix of your Plivo Auth Token.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlivoConfig(
            string authId,
            global::System.Collections.Generic.IList<global::System.Guid>? callCreationAllowedAgentIds,
            bool? callCreationAllowAllAgents,
            global::System.Collections.Generic.Dictionary<string, string>? requestContextMapping,
            string? authToken,
            global::Ultravox.KeyPrefix authTokenPrefix = default!)
        {
            this.CallCreationAllowedAgentIds = callCreationAllowedAgentIds;
            this.CallCreationAllowAllAgents = callCreationAllowAllAgents;
            this.RequestContextMapping = requestContextMapping;
            this.AuthId = authId ?? throw new global::System.ArgumentNullException(nameof(authId));
            this.AuthToken = authToken;
            this.AuthTokenPrefix = authTokenPrefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlivoConfig" /> class.
        /// </summary>
        public PlivoConfig()
        {
        }

        /// <summary>
        /// Creates a new <see cref="PlivoConfig"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static PlivoConfig FromAuthId(string authId)
        {
            return new PlivoConfig
            {
                AuthId = authId,
            };
        }

    }
}