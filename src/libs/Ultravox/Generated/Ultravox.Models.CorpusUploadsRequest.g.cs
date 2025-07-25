
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CorpusUploadsRequest
    {
        /// <summary>
        /// The MIME type of the file to be uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// The name of the file to be uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusUploadsRequest" /> class.
        /// </summary>
        /// <param name="mimeType">
        /// The MIME type of the file to be uploaded.
        /// </param>
        /// <param name="fileName">
        /// The name of the file to be uploaded.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CorpusUploadsRequest(
            string mimeType,
            string? fileName)
        {
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.FileName = fileName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusUploadsRequest" /> class.
        /// </summary>
        public CorpusUploadsRequest()
        {
        }
    }
}