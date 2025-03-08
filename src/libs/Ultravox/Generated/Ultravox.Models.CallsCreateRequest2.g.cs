
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallsCreateRequest2
    {
        /// <summary>
        /// Optional metadata key-value pairs to associate with the call. All values must be strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallsCreateRequest2" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Optional metadata key-value pairs to associate with the call. All values must be strings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallsCreateRequest2(
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallsCreateRequest2" /> class.
        /// </summary>
        public CallsCreateRequest2()
        {
        }
    }
}