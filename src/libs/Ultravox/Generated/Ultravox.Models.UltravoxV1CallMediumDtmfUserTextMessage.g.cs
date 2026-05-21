
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Configures DTMF digits to be sent as a user text message.
    /// </summary>
    public sealed partial class UltravoxV1CallMediumDtmfUserTextMessage
    {
        /// <summary>
        /// Template for the message text. Use {digits} as a placeholder for the<br/>
        ///  pressed digits. Defaults to "{digits}" if empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Urgency of the message. Defaults to URGENCY_IMMEDIATE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urgency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.UltravoxV1CallMediumDtmfUserTextMessageUrgencyJsonConverter))]
        public global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessageUrgency? Urgency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumDtmfUserTextMessage" /> class.
        /// </summary>
        /// <param name="text">
        /// Template for the message text. Use {digits} as a placeholder for the<br/>
        ///  pressed digits. Defaults to "{digits}" if empty.
        /// </param>
        /// <param name="urgency">
        /// Urgency of the message. Defaults to URGENCY_IMMEDIATE.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CallMediumDtmfUserTextMessage(
            string? text,
            global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessageUrgency? urgency)
        {
            this.Text = text;
            this.Urgency = urgency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMediumDtmfUserTextMessage" /> class.
        /// </summary>
        public UltravoxV1CallMediumDtmfUserTextMessage()
        {
        }

    }
}