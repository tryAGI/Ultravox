
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedAgent
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        public global::System.Guid? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callTemplate")]
        public global::Ultravox.UltravoxV1CallTemplate? CallTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAgent" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Included only in responses
        /// </param>
        /// <param name="name"></param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="callTemplate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedAgent(
            global::System.Guid? agentId,
            string? name,
            global::System.DateTime? created,
            global::Ultravox.UltravoxV1CallTemplate? callTemplate)
        {
            this.AgentId = agentId;
            this.Name = name;
            this.Created = created;
            this.CallTemplate = callTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAgent" /> class.
        /// </summary>
        public PatchedAgent()
        {
        }
    }
}