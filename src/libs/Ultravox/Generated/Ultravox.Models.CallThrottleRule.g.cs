
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallThrottleRule
    {
        /// <summary>
        /// Maximum number of calls allowed in the time window (max 100).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCalls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxCalls { get; set; }

        /// <summary>
        /// Duration of the sliding time window in seconds (max 86,400).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windowSeconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WindowSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallThrottleRule" /> class.
        /// </summary>
        /// <param name="maxCalls">
        /// Maximum number of calls allowed in the time window (max 100).
        /// </param>
        /// <param name="windowSeconds">
        /// Duration of the sliding time window in seconds (max 86,400).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallThrottleRule(
            int maxCalls,
            int windowSeconds)
        {
            this.MaxCalls = maxCalls;
            this.WindowSeconds = windowSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallThrottleRule" /> class.
        /// </summary>
        public CallThrottleRule()
        {
        }
    }
}