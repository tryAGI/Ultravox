
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Specification for a voice served by Cartesia. See https://docs.cartesia.ai/api-reference/tts/websocket
    /// </summary>
    public sealed partial class UltravoxV1CartesiaVoice
    {
        /// <summary>
        /// The ID of the voice in Cartesia.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// The Cartesia model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// (Deprecated) The speaking rate. Must be between -1 and 1. Defaults to 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// (Deprecated) Use generation_config.emotion instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        public string? Emotion { get; set; }

        /// <summary>
        /// (Deprecated) Use generation_config.emotion instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotions")]
        public global::System.Collections.Generic.IList<string>? Emotions { get; set; }

        /// <summary>
        /// Configure the various attributes of the generated speech.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generationConfig")]
        public global::Ultravox.UltravoxV1CartesiaVoiceCartesiaGenerationConfig? GenerationConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CartesiaVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The ID of the voice in Cartesia.
        /// </param>
        /// <param name="model">
        /// The Cartesia model to use.
        /// </param>
        /// <param name="speed">
        /// (Deprecated) The speaking rate. Must be between -1 and 1. Defaults to 0.
        /// </param>
        /// <param name="emotion">
        /// (Deprecated) Use generation_config.emotion instead.
        /// </param>
        /// <param name="emotions">
        /// (Deprecated) Use generation_config.emotion instead.
        /// </param>
        /// <param name="generationConfig">
        /// Configure the various attributes of the generated speech.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CartesiaVoice(
            string? voiceId,
            string? model,
            float? speed,
            string? emotion,
            global::System.Collections.Generic.IList<string>? emotions,
            global::Ultravox.UltravoxV1CartesiaVoiceCartesiaGenerationConfig? generationConfig)
        {
            this.VoiceId = voiceId;
            this.Model = model;
            this.Speed = speed;
            this.Emotion = emotion;
            this.Emotions = emotions;
            this.GenerationConfig = generationConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CartesiaVoice" /> class.
        /// </summary>
        public UltravoxV1CartesiaVoice()
        {
        }
    }
}