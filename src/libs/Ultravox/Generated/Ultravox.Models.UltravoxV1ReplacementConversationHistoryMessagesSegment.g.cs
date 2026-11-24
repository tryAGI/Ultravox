
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A single segment of the conversation history to use for the next stage.
    /// </summary>
    public sealed partial class UltravoxV1ReplacementConversationHistoryMessagesSegment
    {
        /// <summary>
        /// Messages to add to the conversation history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public global::Ultravox.UltravoxV1ReplacementConversationHistoryMessagesTemplate? Template { get; set; }

        /// <summary>
        /// The slice of the existing messages to use next.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slice")]
        public global::Ultravox.UltravoxV1ReplacementConversationHistoryMessagesSlice? Slice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ReplacementConversationHistoryMessagesSegment" /> class.
        /// </summary>
        /// <param name="template">
        /// Messages to add to the conversation history.
        /// </param>
        /// <param name="slice">
        /// The slice of the existing messages to use next.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1ReplacementConversationHistoryMessagesSegment(
            global::Ultravox.UltravoxV1ReplacementConversationHistoryMessagesTemplate? template,
            global::Ultravox.UltravoxV1ReplacementConversationHistoryMessagesSlice? slice)
        {
            this.Template = template;
            this.Slice = slice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ReplacementConversationHistoryMessagesSegment" /> class.
        /// </summary>
        public UltravoxV1ReplacementConversationHistoryMessagesSegment()
        {
        }

    }
}