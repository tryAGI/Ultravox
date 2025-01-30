
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A Filter to apply to mime types.
    /// </summary>
    public sealed partial class UltravoxV1MimeTypeFilter
    {
        /// <summary>
        /// Mime types must be in this set to be kept.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::Ultravox.UltravoxV1MimeTypeSet? Include { get; set; }

        /// <summary>
        /// Mime types must not be in this set to be kept.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::Ultravox.UltravoxV1MimeTypeSet? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1MimeTypeFilter" /> class.
        /// </summary>
        /// <param name="include">
        /// Mime types must be in this set to be kept.
        /// </param>
        /// <param name="exclude">
        /// Mime types must not be in this set to be kept.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1MimeTypeFilter(
            global::Ultravox.UltravoxV1MimeTypeSet? include,
            global::Ultravox.UltravoxV1MimeTypeSet? exclude)
        {
            this.Include = include;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1MimeTypeFilter" /> class.
        /// </summary>
        public UltravoxV1MimeTypeFilter()
        {
        }
    }
}