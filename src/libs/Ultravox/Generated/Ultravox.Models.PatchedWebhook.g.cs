
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedWebhook
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookId")]
        public global::System.Guid? WebhookId { get; set; }

        /// <summary>
        /// If set, this webhook will be limited to calls with this agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        public global::System.Guid? AgentId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<string>? Secrets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Ultravox.EventsEnum>? Events { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.StatusEnumJsonConverter))]
        public global::Ultravox.StatusEnum? Status { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastStatusChange")]
        public global::System.DateTime? LastStatusChange { get; set; }

        /// <summary>
        /// A list of recent failures for this webhook, if any.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recentFailures")]
        public global::System.Collections.Generic.IList<global::Ultravox.WebhookFailure>? RecentFailures { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedWebhook" /> class.
        /// </summary>
        /// <param name="webhookId">
        /// Included only in responses
        /// </param>
        /// <param name="agentId">
        /// If set, this webhook will be limited to calls with this agent.
        /// </param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="url"></param>
        /// <param name="secrets"></param>
        /// <param name="events"></param>
        /// <param name="status">
        /// Included only in responses
        /// </param>
        /// <param name="lastStatusChange">
        /// Included only in responses
        /// </param>
        /// <param name="recentFailures">
        /// A list of recent failures for this webhook, if any.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedWebhook(
            global::System.Guid? webhookId,
            global::System.Guid? agentId,
            global::System.DateTime? created,
            string? url,
            global::System.Collections.Generic.IList<string>? secrets,
            global::System.Collections.Generic.IList<global::Ultravox.EventsEnum>? events,
            global::Ultravox.StatusEnum? status,
            global::System.DateTime? lastStatusChange,
            global::System.Collections.Generic.IList<global::Ultravox.WebhookFailure>? recentFailures)
        {
            this.WebhookId = webhookId;
            this.AgentId = agentId;
            this.Created = created;
            this.Url = url;
            this.Secrets = secrets;
            this.Events = events;
            this.Status = status;
            this.LastStatusChange = lastStatusChange;
            this.RecentFailures = recentFailures;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedWebhook" /> class.
        /// </summary>
        public PatchedWebhook()
        {
        }
    }
}