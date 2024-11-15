
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A message the agent should say after some duration. The duration's meaning<br/>
    ///  varies depending on the context.
    /// </summary>
    public sealed partial class UltravoxV1TimedMessage
    {
        /// <summary>
        /// The duration after which the message should be spoken.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// The message to speak.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The behavior to exhibit when the message is finished being spoken.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endBehavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.UltravoxV1TimedMessageEndBehaviorJsonConverter))]
        public global::Ultravox.UltravoxV1TimedMessageEndBehavior? EndBehavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TimedMessage" /> class.
        /// </summary>
        /// <param name="duration">
        /// The duration after which the message should be spoken.
        /// </param>
        /// <param name="message">
        /// The message to speak.
        /// </param>
        /// <param name="endBehavior">
        /// The behavior to exhibit when the message is finished being spoken.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1TimedMessage(
            string? duration,
            string? message,
            global::Ultravox.UltravoxV1TimedMessageEndBehavior? endBehavior)
        {
            this.Duration = duration;
            this.Message = message;
            this.EndBehavior = endBehavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TimedMessage" /> class.
        /// </summary>
        public UltravoxV1TimedMessage()
        {
        }
    }
}