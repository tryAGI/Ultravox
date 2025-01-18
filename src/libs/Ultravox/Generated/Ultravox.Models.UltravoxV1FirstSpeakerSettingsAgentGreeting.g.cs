
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Additional properties for when the agent speaks first.
    /// </summary>
    public sealed partial class UltravoxV1FirstSpeakerSettingsAgentGreeting
    {
        /// <summary>
        /// Whether the user should be prevented from interrupting the agent's first message.<br/>
        ///  Defaults to false (meaning the agent is interruptible as usual).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uninterruptible")]
        public bool? Uninterruptible { get; set; }

        /// <summary>
        /// What the agent should say. If unset, the model will generate a greeting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1FirstSpeakerSettingsAgentGreeting" /> class.
        /// </summary>
        /// <param name="uninterruptible">
        /// Whether the user should be prevented from interrupting the agent's first message.<br/>
        ///  Defaults to false (meaning the agent is interruptible as usual).
        /// </param>
        /// <param name="text">
        /// What the agent should say. If unset, the model will generate a greeting.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1FirstSpeakerSettingsAgentGreeting(
            bool? uninterruptible,
            string? text)
        {
            this.Uninterruptible = uninterruptible;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1FirstSpeakerSettingsAgentGreeting" /> class.
        /// </summary>
        public UltravoxV1FirstSpeakerSettingsAgentGreeting()
        {
        }
    }
}