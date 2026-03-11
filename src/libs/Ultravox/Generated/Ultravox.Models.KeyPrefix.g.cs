
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeyPrefix
    {
        /// <summary>
        /// The prefix of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyPrefix" /> class.
        /// </summary>
        /// <param name="prefix">
        /// The prefix of the API key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeyPrefix(
            string prefix)
        {
            this.Prefix = prefix ?? throw new global::System.ArgumentNullException(nameof(prefix));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyPrefix" /> class.
        /// </summary>
        public KeyPrefix()
        {
        }
    }
}