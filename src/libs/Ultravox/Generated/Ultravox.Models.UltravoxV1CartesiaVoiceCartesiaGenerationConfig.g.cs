
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Cartesia generation configuration for Sonic-3 and later models.
    /// </summary>
    public sealed partial class UltravoxV1CartesiaVoiceCartesiaGenerationConfig
    {
        /// <summary>
        /// Adjust the volume of the generated speech between 0.5x and 2.0x the original volume (default is 1.0x). Valid values are between [0.5, 2.0] inclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        public float? Volume { get; set; }

        /// <summary>
        /// Adjust the speed of the generated speech between 0.6x and 2.0x the original speed (default is 1.0x). Valid values are between [0.6, 1.5] inclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public float? Speed { get; set; }

        /// <summary>
        /// The primary emotions are neutral, calm, angry, content, sad, scared. For more options, see Prompting Sonic-3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emotion")]
        public string? Emotion { get; set; }

        /// <summary>
        /// The ID of a pronunciation dictionary to use for the generation.<br/>
        ///  Pronunciation dictionaries are supported by sonic-3 models and newer.<br/>
        ///  See https://docs.cartesia.ai/build-with-cartesia/capability-guides/specify-custom-pronunciations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pronunciationDictId")]
        public string? PronunciationDictId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CartesiaVoiceCartesiaGenerationConfig" /> class.
        /// </summary>
        /// <param name="volume">
        /// Adjust the volume of the generated speech between 0.5x and 2.0x the original volume (default is 1.0x). Valid values are between [0.5, 2.0] inclusive.
        /// </param>
        /// <param name="speed">
        /// Adjust the speed of the generated speech between 0.6x and 2.0x the original speed (default is 1.0x). Valid values are between [0.6, 1.5] inclusive.
        /// </param>
        /// <param name="emotion">
        /// The primary emotions are neutral, calm, angry, content, sad, scared. For more options, see Prompting Sonic-3.
        /// </param>
        /// <param name="pronunciationDictId">
        /// The ID of a pronunciation dictionary to use for the generation.<br/>
        ///  Pronunciation dictionaries are supported by sonic-3 models and newer.<br/>
        ///  See https://docs.cartesia.ai/build-with-cartesia/capability-guides/specify-custom-pronunciations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CartesiaVoiceCartesiaGenerationConfig(
            float? volume,
            float? speed,
            string? emotion,
            string? pronunciationDictId)
        {
            this.Volume = volume;
            this.Speed = speed;
            this.Emotion = emotion;
            this.PronunciationDictId = pronunciationDictId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CartesiaVoiceCartesiaGenerationConfig" /> class.
        /// </summary>
        public UltravoxV1CartesiaVoiceCartesiaGenerationConfig()
        {
        }
    }
}