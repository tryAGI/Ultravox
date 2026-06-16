
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackHandler
    {
        /// <summary>
        /// The URL to which POSTs will be sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Shared secrets used to sign requests. A strong secret is auto-generated if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<string>? Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackHandler" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to which POSTs will be sent.
        /// </param>
        /// <param name="secrets">
        /// Shared secrets used to sign requests. A strong secret is auto-generated if omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackHandler(
            string url,
            global::System.Collections.Generic.IList<string>? secrets)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Secrets = secrets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackHandler" /> class.
        /// </summary>
        public FallbackHandler()
        {
        }

    }
}