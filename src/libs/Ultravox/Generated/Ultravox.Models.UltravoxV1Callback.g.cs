
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A lifecycle callback configuration.
    /// </summary>
    public sealed partial class UltravoxV1Callback
    {
        /// <summary>
        /// The URL to invoke.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Secrets to use to signing the callback request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secrets")]
        public global::System.Collections.Generic.IList<string>? Secrets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1Callback" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to invoke.
        /// </param>
        /// <param name="secrets">
        /// Secrets to use to signing the callback request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1Callback(
            string? url,
            global::System.Collections.Generic.IList<string>? secrets)
        {
            this.Url = url;
            this.Secrets = secrets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1Callback" /> class.
        /// </summary>
        public UltravoxV1Callback()
        {
        }

    }
}