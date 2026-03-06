
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Specification for a voice served by Inworld.
    /// </summary>
    public sealed partial class UltravoxV1InworldVoice
    {
        /// <summary>
        /// The ID of the voice in Inworld.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// The ID of the model to use for generations, e.g. "inworld-tts-1-max".<br/>
        ///  See https://docs.inworld.ai/docs/tts/tts-models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// The speaking rate. Must be between 0.5 and 1.5. Defaults to 1.<br/>
        ///  See https://docs.inworld.ai/api-reference/ttsAPI/texttospeech/synthesize-speech-stream#body-audio-config-speaking-rate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speakingRate")]
        public float? SpeakingRate { get; set; }

        /// <summary>
        /// How much randomness to use when sampling audio tokens. Must be between 0.0 and 2.0.<br/>
        ///  See https://docs.inworld.ai/api-reference/ttsAPI/texttospeech/synthesize-speech-stream#body-temperature
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Whether or not to apply text normalization. This should typically only be disabled if the<br/>
        ///  agent is instructed to normalize text directly.<br/>
        ///  See https://docs.inworld.ai/api-reference/ttsAPI/texttospeech/synthesize-speech-stream#body-apply-text-normalization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applyTextNormalization")]
        public bool? ApplyTextNormalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1InworldVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The ID of the voice in Inworld.
        /// </param>
        /// <param name="modelId">
        /// The ID of the model to use for generations, e.g. "inworld-tts-1-max".<br/>
        ///  See https://docs.inworld.ai/docs/tts/tts-models
        /// </param>
        /// <param name="speakingRate">
        /// The speaking rate. Must be between 0.5 and 1.5. Defaults to 1.<br/>
        ///  See https://docs.inworld.ai/api-reference/ttsAPI/texttospeech/synthesize-speech-stream#body-audio-config-speaking-rate
        /// </param>
        /// <param name="temperature">
        /// How much randomness to use when sampling audio tokens. Must be between 0.0 and 2.0.<br/>
        ///  See https://docs.inworld.ai/api-reference/ttsAPI/texttospeech/synthesize-speech-stream#body-temperature
        /// </param>
        /// <param name="applyTextNormalization">
        /// Whether or not to apply text normalization. This should typically only be disabled if the<br/>
        ///  agent is instructed to normalize text directly.<br/>
        ///  See https://docs.inworld.ai/api-reference/ttsAPI/texttospeech/synthesize-speech-stream#body-apply-text-normalization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1InworldVoice(
            string? voiceId,
            string? modelId,
            float? speakingRate,
            float? temperature,
            bool? applyTextNormalization)
        {
            this.VoiceId = voiceId;
            this.ModelId = modelId;
            this.SpeakingRate = speakingRate;
            this.Temperature = temperature;
            this.ApplyTextNormalization = applyTextNormalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1InworldVoice" /> class.
        /// </summary>
        public UltravoxV1InworldVoice()
        {
        }
    }
}