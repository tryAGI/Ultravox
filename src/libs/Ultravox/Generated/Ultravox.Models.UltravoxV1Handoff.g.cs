
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A handoff from one agent to another. This is an edge in a graph of agents. The graph<br/>
    ///  for any particular call is frozen when the call is created - changing or removing handoff<br/>
    ///  targets will not impact live calls.
    /// </summary>
    public sealed partial class UltravoxV1Handoff
    {
        /// <summary>
        /// The name of the tool the model uses to hand off. It must be unique among the<br/>
        ///  agent's tools and handoffs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// When the model should hand off, presented to the model as the tool's description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The agent to hand off to. It must belong to the same account and be published.<br/>
        ///  It may be this agent, for example to replace a long conversation with a summary.<br/>
        ///  A call continues with the revision the target agent had published when the call<br/>
        ///  started, even if the target is published again (or deleted) during the call.<br/>
        ///  The call keeps its model, so the target's model is ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Required. The conversation history the target agent starts with. Use retain to<br/>
        ///  keep the whole conversation, though a short summary is often better: templated<br/>
        ///  messages may use variables, filled the same way as the target's templates. Each<br/>
        ///  templated message must set a role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationHistory")]
        public global::Ultravox.UltravoxV1ReplacementConversationHistory? ConversationHistory { get; set; }

        /// <summary>
        /// The text of the tool result message created when the model hands off. It's the<br/>
        ///  last message in the list processed by conversationHistory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolResultText")]
        public string? ToolResultText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1Handoff" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the tool the model uses to hand off. It must be unique among the<br/>
        ///  agent's tools and handoffs.
        /// </param>
        /// <param name="description">
        /// When the model should hand off, presented to the model as the tool's description.
        /// </param>
        /// <param name="agentId">
        /// The agent to hand off to. It must belong to the same account and be published.<br/>
        ///  It may be this agent, for example to replace a long conversation with a summary.<br/>
        ///  A call continues with the revision the target agent had published when the call<br/>
        ///  started, even if the target is published again (or deleted) during the call.<br/>
        ///  The call keeps its model, so the target's model is ignored.
        /// </param>
        /// <param name="conversationHistory">
        /// Required. The conversation history the target agent starts with. Use retain to<br/>
        ///  keep the whole conversation, though a short summary is often better: templated<br/>
        ///  messages may use variables, filled the same way as the target's templates. Each<br/>
        ///  templated message must set a role.
        /// </param>
        /// <param name="toolResultText">
        /// The text of the tool result message created when the model hands off. It's the<br/>
        ///  last message in the list processed by conversationHistory.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1Handoff(
            string? name,
            string? description,
            string? agentId,
            global::Ultravox.UltravoxV1ReplacementConversationHistory? conversationHistory,
            string? toolResultText)
        {
            this.Name = name;
            this.Description = description;
            this.AgentId = agentId;
            this.ConversationHistory = conversationHistory;
            this.ToolResultText = toolResultText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1Handoff" /> class.
        /// </summary>
        public UltravoxV1Handoff()
        {
        }

    }
}