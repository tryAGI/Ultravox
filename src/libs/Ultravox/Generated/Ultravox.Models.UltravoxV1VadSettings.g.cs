
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Call-level VAD settings.
    /// </summary>
    public sealed partial class UltravoxV1VadSettings
    {
        /// <summary>
        /// The delay to wait after the last speech frame before ending the user's "turn". Increasing<br/>
        ///  this value makes the agent wait longer before speaking after the user stops speaking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turnEndpointDelay")]
        public string? TurnEndpointDelay { get; set; }

        /// <summary>
        /// The minimum duration of user speech required to be considered a user turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimumTurnDuration")]
        public string? MinimumTurnDuration { get; set; }

        /// <summary>
        /// The minimum duration of user speech required to interrupt the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimumInterruptionDuration")]
        public string? MinimumInterruptionDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1VadSettings" /> class.
        /// </summary>
        /// <param name="turnEndpointDelay">
        /// The delay to wait after the last speech frame before ending the user's "turn". Increasing<br/>
        ///  this value makes the agent wait longer before speaking after the user stops speaking.
        /// </param>
        /// <param name="minimumTurnDuration">
        /// The minimum duration of user speech required to be considered a user turn.
        /// </param>
        /// <param name="minimumInterruptionDuration">
        /// The minimum duration of user speech required to interrupt the agent.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1VadSettings(
            string? turnEndpointDelay,
            string? minimumTurnDuration,
            string? minimumInterruptionDuration)
        {
            this.TurnEndpointDelay = turnEndpointDelay;
            this.MinimumTurnDuration = minimumTurnDuration;
            this.MinimumInterruptionDuration = minimumInterruptionDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1VadSettings" /> class.
        /// </summary>
        public UltravoxV1VadSettings()
        {
        }
    }
}