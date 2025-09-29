
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledCallBatch
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("batchId")]
        public global::System.Guid BatchId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime Created { get; set; } = default!;

        /// <summary>
        /// The start of the time window during which calls can be made.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windowStart")]
        public global::System.DateTime? WindowStart { get; set; }

        /// <summary>
        /// The end of the time window during which calls can be made.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windowEnd")]
        public global::System.DateTime? WindowEnd { get; set; }

        /// <summary>
        /// The URL to which a request will be made (synchronously) when a call in the batch is created, excluding those with an outgoing medium. Required if any call has a non-outgoing medium and not allowed otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// The signing secret for requests made to the webhookUrl. This is used to verify that the request came from Ultravox. If unset, an appropriate secret will be chosen for you (but you'll still need to make your endpoint aware of it to verify requests).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookSecret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paused")]
        public bool? Paused { get; set; }

        /// <summary>
        /// The total number of calls in this batch.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// The number of calls in this batch that have been completed (created or error).<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedCount")]
        public int CompletedCount { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedAt")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        public global::System.Collections.Generic.IList<global::Ultravox.ScheduledCall>? Calls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledCallBatch" /> class.
        /// </summary>
        /// <param name="batchId">
        /// Included only in responses
        /// </param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="windowStart">
        /// The start of the time window during which calls can be made.
        /// </param>
        /// <param name="windowEnd">
        /// The end of the time window during which calls can be made.
        /// </param>
        /// <param name="webhookUrl">
        /// The URL to which a request will be made (synchronously) when a call in the batch is created, excluding those with an outgoing medium. Required if any call has a non-outgoing medium and not allowed otherwise.
        /// </param>
        /// <param name="webhookSecret">
        /// The signing secret for requests made to the webhookUrl. This is used to verify that the request came from Ultravox. If unset, an appropriate secret will be chosen for you (but you'll still need to make your endpoint aware of it to verify requests).
        /// </param>
        /// <param name="paused"></param>
        /// <param name="totalCount">
        /// The total number of calls in this batch.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="completedCount">
        /// The number of calls in this batch that have been completed (created or error).<br/>
        /// Included only in responses
        /// </param>
        /// <param name="endedAt">
        /// Included only in responses
        /// </param>
        /// <param name="calls">
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduledCallBatch(
            global::System.DateTime? windowStart,
            global::System.DateTime? windowEnd,
            string? webhookUrl,
            string? webhookSecret,
            bool? paused,
            global::System.DateTime? endedAt,
            global::System.Collections.Generic.IList<global::Ultravox.ScheduledCall>? calls,
            global::System.Guid batchId = default!,
            global::System.DateTime created = default!,
            int totalCount = default!,
            int completedCount = default!)
        {
            this.BatchId = batchId;
            this.Created = created;
            this.WindowStart = windowStart;
            this.WindowEnd = windowEnd;
            this.WebhookUrl = webhookUrl;
            this.WebhookSecret = webhookSecret;
            this.Paused = paused;
            this.TotalCount = totalCount;
            this.CompletedCount = completedCount;
            this.EndedAt = endedAt;
            this.Calls = calls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledCallBatch" /> class.
        /// </summary>
        public ScheduledCallBatch()
        {
        }
    }
}