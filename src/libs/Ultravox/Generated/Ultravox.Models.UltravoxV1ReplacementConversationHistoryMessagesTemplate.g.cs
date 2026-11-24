
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Explicitly-defined messages to add to the conversation history.
    /// </summary>
    public sealed partial class UltravoxV1ReplacementConversationHistoryMessagesTemplate
    {
        /// <summary>
        /// The messages to use next.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Message>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ReplacementConversationHistoryMessagesTemplate" /> class.
        /// </summary>
        /// <param name="messages">
        /// The messages to use next.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1ReplacementConversationHistoryMessagesTemplate(
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Message>? messages)
        {
            this.Messages = messages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ReplacementConversationHistoryMessagesTemplate" /> class.
        /// </summary>
        public UltravoxV1ReplacementConversationHistoryMessagesTemplate()
        {
        }

    }
}