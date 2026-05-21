
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A data message to send to a call.
    /// </summary>
    public sealed partial class SendCallDataMessage
    {
        /// <summary>
        /// The type of the data message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendCallDataMessage" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the data message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendCallDataMessage(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendCallDataMessage" /> class.
        /// </summary>
        public SendCallDataMessage()
        {
        }

    }
}