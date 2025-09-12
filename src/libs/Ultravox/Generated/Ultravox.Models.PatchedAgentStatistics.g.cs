
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Statistics about the agent's usage<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class PatchedAgentStatistics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        public int? Calls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalBilledMinutes")]
        public int? TotalBilledMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAgentStatistics" /> class.
        /// </summary>
        /// <param name="calls"></param>
        /// <param name="totalBilledMinutes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedAgentStatistics(
            int? calls,
            int? totalBilledMinutes)
        {
            this.Calls = calls;
            this.TotalBilledMinutes = totalBilledMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAgentStatistics" /> class.
        /// </summary>
        public PatchedAgentStatistics()
        {
        }
    }
}