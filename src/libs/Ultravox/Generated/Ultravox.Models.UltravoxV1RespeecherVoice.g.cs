
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Specification for a voice served by Respeecher.<br/>
    ///  See https://space.respeecher.com/docs/api/tts/sampling-params-guide<br/>
    ///  for parameter guidance.
    /// </summary>
    public sealed partial class UltravoxV1RespeecherVoice
    {
        /// <summary>
        /// The ID of the voice in Respeecher.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// The model to use, e.g. "/v1/public/tts/ua-rt" or "/v1/public/tts/en-rt"<br/>
        ///  Requests will be sent to wss://api.respeecher.com{model}/tts/websocket.<br/>
        ///  If not set, defaults to "/v1/public/tts/en-rt" for calls with an English<br/>
        ///  language hint and "/v1/public/tts/ua-rt" otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Random seed for reproducible generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Controls randomness of the output. Higher values produce more varied speech.<br/>
        ///  If set, must be greater than or equal to 0.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Limits sampling to the top K most likely tokens.<br/>
        ///  If set, must be exactly -1 or greater than 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public int? TopK { get; set; }

        /// <summary>
        /// Limits sampling to tokens with cumulative probability up to this value.<br/>
        ///  If set, must be greater than 0 and less than or equal to 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topP")]
        public float? TopP { get; set; }

        /// <summary>
        /// Minimum probability threshold for token sampling.<br/>
        ///  If set, must be between 0.0 and 1.0, inclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minP")]
        public float? MinP { get; set; }

        /// <summary>
        /// Penalty for tokens already present in the context.<br/>
        ///  If set, must be between 0 and 2, inclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presencePenalty")]
        public float? PresencePenalty { get; set; }

        /// <summary>
        /// Penalty for repeating tokens.<br/>
        ///  If set, must be between 1 and 2, inclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetitionPenalty")]
        public float? RepetitionPenalty { get; set; }

        /// <summary>
        /// Penalty based on token frequency.<br/>
        ///  If set, must be between 0 and 2, inclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequencyPenalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1RespeecherVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The ID of the voice in Respeecher.
        /// </param>
        /// <param name="model">
        /// The model to use, e.g. "/v1/public/tts/ua-rt" or "/v1/public/tts/en-rt"<br/>
        ///  Requests will be sent to wss://api.respeecher.com{model}/tts/websocket.<br/>
        ///  If not set, defaults to "/v1/public/tts/en-rt" for calls with an English<br/>
        ///  language hint and "/v1/public/tts/ua-rt" otherwise.
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducible generation.
        /// </param>
        /// <param name="temperature">
        /// Controls randomness of the output. Higher values produce more varied speech.<br/>
        ///  If set, must be greater than or equal to 0.0.
        /// </param>
        /// <param name="topK">
        /// Limits sampling to the top K most likely tokens.<br/>
        ///  If set, must be exactly -1 or greater than 0.
        /// </param>
        /// <param name="topP">
        /// Limits sampling to tokens with cumulative probability up to this value.<br/>
        ///  If set, must be greater than 0 and less than or equal to 1.0.
        /// </param>
        /// <param name="minP">
        /// Minimum probability threshold for token sampling.<br/>
        ///  If set, must be between 0.0 and 1.0, inclusive.
        /// </param>
        /// <param name="presencePenalty">
        /// Penalty for tokens already present in the context.<br/>
        ///  If set, must be between 0 and 2, inclusive.
        /// </param>
        /// <param name="repetitionPenalty">
        /// Penalty for repeating tokens.<br/>
        ///  If set, must be between 1 and 2, inclusive.
        /// </param>
        /// <param name="frequencyPenalty">
        /// Penalty based on token frequency.<br/>
        ///  If set, must be between 0 and 2, inclusive.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1RespeecherVoice(
            string? voiceId,
            string? model,
            int? seed,
            float? temperature,
            int? topK,
            float? topP,
            float? minP,
            float? presencePenalty,
            float? repetitionPenalty,
            float? frequencyPenalty)
        {
            this.VoiceId = voiceId;
            this.Model = model;
            this.Seed = seed;
            this.Temperature = temperature;
            this.TopK = topK;
            this.TopP = topP;
            this.MinP = minP;
            this.PresencePenalty = presencePenalty;
            this.RepetitionPenalty = repetitionPenalty;
            this.FrequencyPenalty = frequencyPenalty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1RespeecherVoice" /> class.
        /// </summary>
        public UltravoxV1RespeecherVoice()
        {
        }

    }
}