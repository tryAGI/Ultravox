
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A source of documents for building a corpus. A source defines where documents<br/>
    ///  are pulled from.
    /// </summary>
    public sealed partial class UltravoxV1CorpusSource
    {
        /// <summary>
        /// The id of this source's corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpusId")]
        public string? CorpusId { get; set; }

        /// <summary>
        /// The unique ID of this source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceId")]
        public string? SourceId { get; set; }

        /// <summary>
        /// When this source was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// The name of this source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of this source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The current stats for this source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::Ultravox.UltravoxV1SourceStats? Stats { get; set; }

        /// <summary>
        /// How to load documents for this source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loadSpec")]
        public global::Ultravox.UltravoxV1LoadSpec? LoadSpec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CorpusSource" /> class.
        /// </summary>
        /// <param name="corpusId">
        /// The id of this source's corpus.
        /// </param>
        /// <param name="sourceId">
        /// The unique ID of this source.
        /// </param>
        /// <param name="created">
        /// When this source was created.
        /// </param>
        /// <param name="name">
        /// The name of this source.
        /// </param>
        /// <param name="description">
        /// A description of this source.
        /// </param>
        /// <param name="stats">
        /// The current stats for this source.
        /// </param>
        /// <param name="loadSpec">
        /// How to load documents for this source.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CorpusSource(
            string? corpusId,
            string? sourceId,
            global::System.DateTime? created,
            string? name,
            string? description,
            global::Ultravox.UltravoxV1SourceStats? stats,
            global::Ultravox.UltravoxV1LoadSpec? loadSpec)
        {
            this.CorpusId = corpusId;
            this.SourceId = sourceId;
            this.Created = created;
            this.Name = name;
            this.Description = description;
            this.Stats = stats;
            this.LoadSpec = loadSpec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CorpusSource" /> class.
        /// </summary>
        public UltravoxV1CorpusSource()
        {
        }
    }
}