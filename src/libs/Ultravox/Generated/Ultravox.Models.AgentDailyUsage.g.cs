
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentDailyUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime Date { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billedMinutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double BilledMinutes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Calls { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDailyUsage" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="billedMinutes"></param>
        /// <param name="calls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentDailyUsage(
            global::System.DateTime date,
            double billedMinutes,
            int calls)
        {
            this.Date = date;
            this.BilledMinutes = billedMinutes;
            this.Calls = calls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentDailyUsage" /> class.
        /// </summary>
        public AgentDailyUsage()
        {
        }
    }
}