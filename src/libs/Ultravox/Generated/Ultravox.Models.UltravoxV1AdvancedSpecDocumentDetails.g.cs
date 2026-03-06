
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Details about a single document. The document will be treated as<br/>
    ///  a single chunk and only the provided example queries will be embedded.<br/>
    ///  On query, matching vectors return the full document content.
    /// </summary>
    public sealed partial class UltravoxV1AdvancedSpecDocumentDetails
    {
        /// <summary>
        /// The unique ID of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentId")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// Example queries for this document. These queries will be embedded<br/>
        ///  instead of the document content.<br/>
        ///  Up to 10 queries may be provided for a document. Each query must be<br/>
        ///  non-empty after stripping whitespace, and at most 400 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exampleQueries")]
        public global::System.Collections.Generic.IList<string>? ExampleQueries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1AdvancedSpecDocumentDetails" /> class.
        /// </summary>
        /// <param name="documentId">
        /// The unique ID of the document.
        /// </param>
        /// <param name="exampleQueries">
        /// Example queries for this document. These queries will be embedded<br/>
        ///  instead of the document content.<br/>
        ///  Up to 10 queries may be provided for a document. Each query must be<br/>
        ///  non-empty after stripping whitespace, and at most 400 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1AdvancedSpecDocumentDetails(
            string? documentId,
            global::System.Collections.Generic.IList<string>? exampleQueries)
        {
            this.DocumentId = documentId;
            this.ExampleQueries = exampleQueries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1AdvancedSpecDocumentDetails" /> class.
        /// </summary>
        public UltravoxV1AdvancedSpecDocumentDetails()
        {
        }
    }
}