
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Background audio played behind the agent's voice for the duration of a call,<br/>
    ///  for example to make the agent sound like it's in a busy office.
    /// </summary>
    public sealed partial class UltravoxV1BackgroundAudio
    {
        /// <summary>
        /// The name or ID of the audio clip to play.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioClip")]
        public string? AudioClip { get; set; }

        /// <summary>
        /// The volume of the background audio relative to the agent's voice, between<br/>
        ///  0 and 10. Defaults to 0.3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public float? Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1BackgroundAudio" /> class.
        /// </summary>
        /// <param name="audioClip">
        /// The name or ID of the audio clip to play.
        /// </param>
        /// <param name="volume">
        /// The volume of the background audio relative to the agent's voice, between<br/>
        ///  0 and 10. Defaults to 0.3.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1BackgroundAudio(
            string? audioClip,
            float? volume)
        {
            this.AudioClip = audioClip;
            this.Volume = volume;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1BackgroundAudio" /> class.
        /// </summary>
        public UltravoxV1BackgroundAudio()
        {
        }

    }
}