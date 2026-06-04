
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SipConfig
    {
        /// <summary>
        /// The list of IPv4 CIDR ranges from which incoming SIP calls will be accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedCidrRanges")]
        public global::System.Collections.Generic.IList<string>? AllowedCidrRanges { get; set; }

        /// <summary>
        /// If true, adds an implicit allowance for requests matching agent_&lt;agent_id&gt;@&lt;anydomain&gt; for any of your agents.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowAllAgents")]
        public bool? AllowAllAgents { get; set; }

        /// <summary>
        /// Calls must match a pattern for one of these agents (or the global agent pattern if allowAllAgents is true) to be accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedAgents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ultravox.AgentAllowance> AllowedAgents { get; set; }

        /// <summary>
        /// If set, this webhook is consulted for any incoming SIP call that does not match an agent allowance (including the allowAllAgents allowance if set). The endpoint must respond promptly with a 200 status and a JSON body with exactly one of startAgentCall, startCall, or reject. The first two use the request body for the associated call creation endpoints plus agentId in the former case, while reject may include `sipRejectCode` (default 603) to pass along to the caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackHandler")]
        public global::Ultravox.FallbackHandler? FallbackHandler { get; set; }

        /// <summary>
        /// The domain used for SIP invites for your account.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string Domain { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SipConfig" /> class.
        /// </summary>
        /// <param name="allowedAgents">
        /// Calls must match a pattern for one of these agents (or the global agent pattern if allowAllAgents is true) to be accepted.
        /// </param>
        /// <param name="allowedCidrRanges">
        /// The list of IPv4 CIDR ranges from which incoming SIP calls will be accepted.
        /// </param>
        /// <param name="allowAllAgents">
        /// If true, adds an implicit allowance for requests matching agent_&lt;agent_id&gt;@&lt;anydomain&gt; for any of your agents.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="fallbackHandler">
        /// If set, this webhook is consulted for any incoming SIP call that does not match an agent allowance (including the allowAllAgents allowance if set). The endpoint must respond promptly with a 200 status and a JSON body with exactly one of startAgentCall, startCall, or reject. The first two use the request body for the associated call creation endpoints plus agentId in the former case, while reject may include `sipRejectCode` (default 603) to pass along to the caller.
        /// </param>
        /// <param name="domain">
        /// The domain used for SIP invites for your account.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SipConfig(
            global::System.Collections.Generic.IList<global::Ultravox.AgentAllowance> allowedAgents,
            global::System.Collections.Generic.IList<string>? allowedCidrRanges,
            bool? allowAllAgents,
            global::Ultravox.FallbackHandler? fallbackHandler,
            string domain = default!)
        {
            this.AllowedCidrRanges = allowedCidrRanges;
            this.AllowAllAgents = allowAllAgents;
            this.AllowedAgents = allowedAgents ?? throw new global::System.ArgumentNullException(nameof(allowedAgents));
            this.FallbackHandler = fallbackHandler;
            this.Domain = domain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SipConfig" /> class.
        /// </summary>
        public SipConfig()
        {
        }

    }
}