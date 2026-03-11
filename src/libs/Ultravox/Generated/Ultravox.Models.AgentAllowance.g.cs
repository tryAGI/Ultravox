
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentAllowance
    {
        /// <summary>
        /// The ID of the agent to allow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid AgentId { get; set; } = default!;

        /// <summary>
        /// A pattern to apply to the to user part of the URI of any incoming sip INVITE that determines how this agent can be reached. Defaults to ^agent_&lt;agent_id&gt;$ if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toUserPattern")]
        public string? ToUserPattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAllowance" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent to allow.
        /// </param>
        /// <param name="toUserPattern">
        /// A pattern to apply to the to user part of the URI of any incoming sip INVITE that determines how this agent can be reached. Defaults to ^agent_&lt;agent_id&gt;$ if not specified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentAllowance(
            global::System.Guid agentId,
            string? toUserPattern)
        {
            this.AgentId = agentId;
            this.ToUserPattern = toUserPattern;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentAllowance" /> class.
        /// </summary>
        public AgentAllowance()
        {
        }
    }
}