
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Statistics about the agent's usage<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class AgentStatistics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        public int? Calls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatistics" /> class.
        /// </summary>
        /// <param name="calls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentStatistics(
            int? calls)
        {
            this.Calls = calls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatistics" /> class.
        /// </summary>
        public AgentStatistics()
        {
        }
    }
}