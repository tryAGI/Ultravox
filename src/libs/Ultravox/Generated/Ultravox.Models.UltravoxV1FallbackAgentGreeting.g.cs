
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A fallback for the case when the user is expected to speak first but doesn't.
    /// </summary>
    public sealed partial class UltravoxV1FallbackAgentGreeting
    {
        /// <summary>
        /// How long the agent should wait before starting the conversation itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delay")]
        public string? Delay { get; set; }

        /// <summary>
        /// A specific greeting the agent should say.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// A prompt for the agent to generate a greeting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1FallbackAgentGreeting" /> class.
        /// </summary>
        /// <param name="delay">
        /// How long the agent should wait before starting the conversation itself.
        /// </param>
        /// <param name="text">
        /// A specific greeting the agent should say.
        /// </param>
        /// <param name="prompt">
        /// A prompt for the agent to generate a greeting.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1FallbackAgentGreeting(
            string? delay,
            string? text,
            string? prompt)
        {
            this.Delay = delay;
            this.Text = text;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1FallbackAgentGreeting" /> class.
        /// </summary>
        public UltravoxV1FallbackAgentGreeting()
        {
        }
    }
}