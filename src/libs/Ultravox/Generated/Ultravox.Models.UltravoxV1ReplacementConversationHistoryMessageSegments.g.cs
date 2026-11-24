
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// All the segments to use for the next call/stage. Each segment is either templated<br/>
    ///  messages or a slice of the existing messages. Segments are added in order.
    /// </summary>
    public sealed partial class UltravoxV1ReplacementConversationHistoryMessageSegments
    {
        /// <summary>
        /// The segments to add.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1ReplacementConversationHistoryMessagesSegment>? Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ReplacementConversationHistoryMessageSegments" /> class.
        /// </summary>
        /// <param name="segments">
        /// The segments to add.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1ReplacementConversationHistoryMessageSegments(
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1ReplacementConversationHistoryMessagesSegment>? segments)
        {
            this.Segments = segments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ReplacementConversationHistoryMessageSegments" /> class.
        /// </summary>
        public UltravoxV1ReplacementConversationHistoryMessageSegments()
        {
        }

    }
}