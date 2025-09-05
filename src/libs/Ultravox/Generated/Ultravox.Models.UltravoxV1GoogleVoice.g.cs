
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Specification for a voice served by Google.<br/>
    ///  This implementation uses bidirectional streaming, so voices prior to Chirp3 are not supported.
    /// </summary>
    public sealed partial class UltravoxV1GoogleVoice
    {
        /// <summary>
        /// The ID (name) of the voice in Google, e.g. "en-US-Chirp3-HD-Charon".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// The speaking rate. Must be between 0.25 and 2. Defaults to 1.<br/>
        ///  See https://cloud.google.com/python/docs/reference/texttospeech/latest/google.cloud.texttospeech_v1.types.StreamingAudioConfig
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakingRate")]
        public float? SpeakingRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1GoogleVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The ID (name) of the voice in Google, e.g. "en-US-Chirp3-HD-Charon".
        /// </param>
        /// <param name="speakingRate">
        /// The speaking rate. Must be between 0.25 and 2. Defaults to 1.<br/>
        ///  See https://cloud.google.com/python/docs/reference/texttospeech/latest/google.cloud.texttospeech_v1.types.StreamingAudioConfig
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1GoogleVoice(
            string? voiceId,
            float? speakingRate)
        {
            this.VoiceId = voiceId;
            this.SpeakingRate = speakingRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1GoogleVoice" /> class.
        /// </summary>
        public UltravoxV1GoogleVoice()
        {
        }
    }
}