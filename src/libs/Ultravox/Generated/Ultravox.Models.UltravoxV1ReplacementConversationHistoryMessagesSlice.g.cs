
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A Python-style slice of the existing messages to use for the next stage.<br/>
    ///  Negative indices are supported and out-of-bounds indices are clamped.
    /// </summary>
    public sealed partial class UltravoxV1ReplacementConversationHistoryMessagesSlice
    {
        /// <summary>
        /// The start index of the slice. Defaults to 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public int? Start { get; set; }

        /// <summary>
        /// The end index of the slice. Defaults to the end of the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public int? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ReplacementConversationHistoryMessagesSlice" /> class.
        /// </summary>
        /// <param name="start">
        /// The start index of the slice. Defaults to 0.
        /// </param>
        /// <param name="end">
        /// The end index of the slice. Defaults to the end of the list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1ReplacementConversationHistoryMessagesSlice(
            int? start,
            int? end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ReplacementConversationHistoryMessagesSlice" /> class.
        /// </summary>
        public UltravoxV1ReplacementConversationHistoryMessagesSlice()
        {
        }

    }
}