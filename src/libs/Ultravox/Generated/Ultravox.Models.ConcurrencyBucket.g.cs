
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConcurrencyBucket
    {
        /// <summary>
        /// Start of the time bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Peak total active calls in this bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTotalCalls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTotalCalls { get; set; }

        /// <summary>
        /// Peak joined calls in this bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxJoinedCalls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxJoinedCalls { get; set; }

        /// <summary>
        /// Average total active calls in this bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgTotalCalls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgTotalCalls { get; set; }

        /// <summary>
        /// Average joined calls in this bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgJoinedCalls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AvgJoinedCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyBucket" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Start of the time bucket
        /// </param>
        /// <param name="maxTotalCalls">
        /// Peak total active calls in this bucket
        /// </param>
        /// <param name="maxJoinedCalls">
        /// Peak joined calls in this bucket
        /// </param>
        /// <param name="avgTotalCalls">
        /// Average total active calls in this bucket
        /// </param>
        /// <param name="avgJoinedCalls">
        /// Average joined calls in this bucket
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConcurrencyBucket(
            global::System.DateTime timestamp,
            int maxTotalCalls,
            int maxJoinedCalls,
            double avgTotalCalls,
            double avgJoinedCalls)
        {
            this.Timestamp = timestamp;
            this.MaxTotalCalls = maxTotalCalls;
            this.MaxJoinedCalls = maxJoinedCalls;
            this.AvgTotalCalls = avgTotalCalls;
            this.AvgJoinedCalls = avgJoinedCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyBucket" /> class.
        /// </summary>
        public ConcurrencyBucket()
        {
        }

    }
}