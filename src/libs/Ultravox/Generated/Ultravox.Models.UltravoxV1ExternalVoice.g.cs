
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A voice not known to Ultravox Realtime that can nonetheless be used for a call.<br/>
    ///  Such voices are significantly less validated than normal voices and you'll be<br/>
    ///  responsible for your own TTS-related errors.<br/>
    ///  Exactly one field must be set.
    /// </summary>
    public sealed partial class UltravoxV1ExternalVoice
    {
        /// <summary>
        /// A voice served by ElevenLabs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevenLabs")]
        public global::Ultravox.UltravoxV1ElevenLabsVoice? ElevenLabs { get; set; }

        /// <summary>
        /// A voice served by Cartesia.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cartesia")]
        public global::Ultravox.UltravoxV1CartesiaVoice? Cartesia { get; set; }

        /// <summary>
        /// A voice served by PlayHT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playHt")]
        public global::Ultravox.UltravoxV1PlayHtVoice? PlayHt { get; set; }

        /// <summary>
        /// A voice served by LMNT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lmnt")]
        public global::Ultravox.UltravoxV1LmntVoice? Lmnt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ExternalVoice" /> class.
        /// </summary>
        /// <param name="elevenLabs">
        /// A voice served by ElevenLabs.
        /// </param>
        /// <param name="cartesia">
        /// A voice served by Cartesia.
        /// </param>
        /// <param name="playHt">
        /// A voice served by PlayHT.
        /// </param>
        /// <param name="lmnt">
        /// A voice served by LMNT.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1ExternalVoice(
            global::Ultravox.UltravoxV1ElevenLabsVoice? elevenLabs,
            global::Ultravox.UltravoxV1CartesiaVoice? cartesia,
            global::Ultravox.UltravoxV1PlayHtVoice? playHt,
            global::Ultravox.UltravoxV1LmntVoice? lmnt)
        {
            this.ElevenLabs = elevenLabs;
            this.Cartesia = cartesia;
            this.PlayHt = playHt;
            this.Lmnt = lmnt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1ExternalVoice" /> class.
        /// </summary>
        public UltravoxV1ExternalVoice()
        {
        }
    }
}