
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// The specification of how to acquire documents for an advanced documents source.
    /// </summary>
    public sealed partial class UltravoxV1AdvancedSpec
    {
        /// <summary>
        /// The list of documents to include in this source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails>? Documents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1AdvancedSpec" /> class.
        /// </summary>
        /// <param name="documents">
        /// The list of documents to include in this source.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1AdvancedSpec(
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails>? documents)
        {
            this.Documents = documents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1AdvancedSpec" /> class.
        /// </summary>
        public UltravoxV1AdvancedSpec()
        {
        }

    }
}