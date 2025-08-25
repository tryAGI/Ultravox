
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScheduledCall
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.ScheduledCallStatusEnumJsonConverter))]
        public global::Ultravox.ScheduledCallStatusEnum Status { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("batchId")]
        public global::System.Guid BatchId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callId")]
        public global::System.Guid? CallId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The call medium to use for the call. In particular, allows for specifying per-call recipients for outgoing SIP media.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium")]
        public global::Ultravox.UltravoxV1CallMedium? Medium { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The context used to render the agent's template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateContext")]
        public object? TemplateContext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimentalSettings")]
        public object? ExperimentalSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledCall" /> class.
        /// </summary>
        /// <param name="status">
        /// Included only in responses
        /// </param>
        /// <param name="batchId">
        /// Included only in responses
        /// </param>
        /// <param name="callId">
        /// Included only in responses
        /// </param>
        /// <param name="error">
        /// Included only in responses
        /// </param>
        /// <param name="medium">
        /// The call medium to use for the call. In particular, allows for specifying per-call recipients for outgoing SIP media.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="templateContext">
        /// The context used to render the agent's template.
        /// </param>
        /// <param name="experimentalSettings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScheduledCall(
            global::System.Guid? callId,
            string? error,
            global::Ultravox.UltravoxV1CallMedium? medium,
            object? metadata,
            object? templateContext,
            object? experimentalSettings,
            global::Ultravox.ScheduledCallStatusEnum status = default!,
            global::System.Guid batchId = default!)
        {
            this.Status = status;
            this.BatchId = batchId;
            this.CallId = callId;
            this.Error = error;
            this.Medium = medium;
            this.Metadata = metadata;
            this.TemplateContext = templateContext;
            this.ExperimentalSettings = experimentalSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledCall" /> class.
        /// </summary>
        public ScheduledCall()
        {
        }
    }
}