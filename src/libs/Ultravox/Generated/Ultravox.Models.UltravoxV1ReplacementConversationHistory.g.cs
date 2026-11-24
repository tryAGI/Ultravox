
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Defines how to transfer conversation history from one call (or call stage) to another.<br/>
    ///  Exactly one of `retain` or `segments` must be set.
    /// </summary>
    public sealed partial class UltravoxV1ReplacementConversationHistory
    {
        /// <summary>
        /// Retain the existing conversation history unaltered if true. If false, the conversation history is dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retain")]
        public bool? Retain { get; set; }

        /// <summary>
        /// Use parts of the existing conversation history, mixing in explicitly defined messages as needed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::Ultravox.UltravoxV1ReplacementConversationHistoryMessageSegments? Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ReplacementConversationHistory" /> class.
        /// </summary>
        /// <param name="retain">
        /// Retain the existing conversation history unaltered if true. If false, the conversation history is dropped.
        /// </param>
        /// <param name="segments">
        /// Use parts of the existing conversation history, mixing in explicitly defined messages as needed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1ReplacementConversationHistory(
            bool? retain,
            global::Ultravox.UltravoxV1ReplacementConversationHistoryMessageSegments? segments)
        {
            this.Retain = retain;
            this.Segments = segments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ReplacementConversationHistory" /> class.
        /// </summary>
        public UltravoxV1ReplacementConversationHistory()
        {
        }

    }
}