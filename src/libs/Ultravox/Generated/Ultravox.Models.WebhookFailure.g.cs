
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookFailure
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Failure { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookFailure" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="failure"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookFailure(
            global::System.DateTime timestamp,
            string failure)
        {
            this.Timestamp = timestamp;
            this.Failure = failure ?? throw new global::System.ArgumentNullException(nameof(failure));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookFailure" /> class.
        /// </summary>
        public WebhookFailure()
        {
        }
    }
}