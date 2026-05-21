
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentStatistics
    {
        /// <summary>
        /// Default Value: 0<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        public int Calls { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStatistics" /> class.
        /// </summary>
        /// <param name="calls">
        /// Default Value: 0<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentStatistics(
            int calls = default!)
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