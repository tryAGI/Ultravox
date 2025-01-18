
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Settings for the initial message to get a conversation started.<br/>
    ///  Exactly one of user or agent should be set. The default is agent<br/>
    ///  (unless firstSpeaker is also set, in which case the default will<br/>
    ///  match that).
    /// </summary>
    public sealed partial class UltravoxV1FirstSpeakerSettings
    {
        /// <summary>
        /// If set, the user should speak first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public object? User { get; set; }

        /// <summary>
        /// If set, the agent should speak first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::Ultravox.UltravoxV1FirstSpeakerSettingsAgentGreeting? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1FirstSpeakerSettings" /> class.
        /// </summary>
        /// <param name="user">
        /// If set, the user should speak first.
        /// </param>
        /// <param name="agent">
        /// If set, the agent should speak first.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1FirstSpeakerSettings(
            object? user,
            global::Ultravox.UltravoxV1FirstSpeakerSettingsAgentGreeting? agent)
        {
            this.User = user;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1FirstSpeakerSettings" /> class.
        /// </summary>
        public UltravoxV1FirstSpeakerSettings()
        {
        }
    }
}