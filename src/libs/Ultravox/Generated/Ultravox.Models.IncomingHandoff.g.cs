
#nullable enable

namespace Ultravox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IncomingHandoff
    {
        /// <summary>
        /// The agent the handoff belongs to.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::Ultravox.AgentBasic Agent { get; set; } = default!;

        /// <summary>
        /// The name of the tool the agent hands off with.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// When the agent hands off.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IncomingHandoff" /> class.
        /// </summary>
        /// <param name="agent">
        /// The agent the handoff belongs to.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// The name of the tool the agent hands off with.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// When the agent hands off.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IncomingHandoff(
            global::Ultravox.AgentBasic agent = default!,
            string name = default!,
            string description = default!)
        {
            this.Agent = agent;
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IncomingHandoff" /> class.
        /// </summary>
        public IncomingHandoff()
        {
        }

    }
}