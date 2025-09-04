
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Agent
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        public global::System.Guid AgentId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedRevisionId")]
        public global::System.Guid? PublishedRevisionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime Created { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callTemplate")]
        public global::Ultravox.UltravoxV1CallTemplate? CallTemplate { get; set; }

        /// <summary>
        /// Statistics about the agent's usage<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("statistics")]
        public global::Ultravox.AgentStatistics Statistics { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Included only in responses
        /// </param>
        /// <param name="publishedRevisionId">
        /// Included only in responses
        /// </param>
        /// <param name="name"></param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="callTemplate"></param>
        /// <param name="statistics">
        /// Statistics about the agent's usage<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Agent(
            global::System.Guid? publishedRevisionId,
            string? name,
            global::Ultravox.UltravoxV1CallTemplate? callTemplate,
            global::System.Guid agentId = default!,
            global::System.DateTime created = default!,
            global::Ultravox.AgentStatistics statistics = default!)
        {
            this.AgentId = agentId;
            this.PublishedRevisionId = publishedRevisionId;
            this.Name = name;
            this.Created = created;
            this.CallTemplate = callTemplate;
            this.Statistics = statistics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        public Agent()
        {
        }
    }
}