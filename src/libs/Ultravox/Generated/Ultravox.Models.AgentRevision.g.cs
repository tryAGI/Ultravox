
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentRevision
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("revisionId")]
        public global::System.Guid RevisionId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime Created { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPublished")]
        public bool IsPublished { get; set; } = default!;

        /// <summary>
        /// A CallTemplate that can be used to create Ultravox calls with shared properties.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callTemplate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ultravox.UltravoxV1CallTemplate CallTemplate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRevision" /> class.
        /// </summary>
        /// <param name="revisionId">
        /// Included only in responses
        /// </param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="isPublished">
        /// Included only in responses
        /// </param>
        /// <param name="callTemplate">
        /// A CallTemplate that can be used to create Ultravox calls with shared properties.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRevision(
            global::Ultravox.UltravoxV1CallTemplate callTemplate,
            global::System.Guid revisionId = default!,
            global::System.DateTime created = default!,
            bool isPublished = default!)
        {
            this.CallTemplate = callTemplate ?? throw new global::System.ArgumentNullException(nameof(callTemplate));
            this.RevisionId = revisionId;
            this.Created = created;
            this.IsPublished = isPublished;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRevision" /> class.
        /// </summary>
        public AgentRevision()
        {
        }
    }
}