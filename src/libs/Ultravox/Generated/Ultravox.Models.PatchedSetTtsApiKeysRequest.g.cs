
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedSetTtsApiKeysRequest
    {
        /// <summary>
        /// Your ElevenLabs API key.<br/>
        /// https://elevenlabs.io/app/settings/api-keys
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevenLabs")]
        public string? ElevenLabs { get; set; }

        /// <summary>
        /// Your Cartesia API key.<br/>
        /// https://play.cartesia.ai/keys
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cartesia")]
        public string? Cartesia { get; set; }

        /// <summary>
        /// Your PlayHT API key.<br/>
        /// Note: This must come from play.ht, not play.ai. Their users are NOT interchangeable!<br/>
        /// https://play.ht/studio/api-access
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playHt")]
        public string? PlayHt { get; set; }

        /// <summary>
        /// Your LMNT API key.<br/>
        /// https://app.lmnt.com/account#api-keys
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lmnt")]
        public string? Lmnt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedSetTtsApiKeysRequest" /> class.
        /// </summary>
        /// <param name="elevenLabs">
        /// Your ElevenLabs API key.<br/>
        /// https://elevenlabs.io/app/settings/api-keys
        /// </param>
        /// <param name="cartesia">
        /// Your Cartesia API key.<br/>
        /// https://play.cartesia.ai/keys
        /// </param>
        /// <param name="playHt">
        /// Your PlayHT API key.<br/>
        /// Note: This must come from play.ht, not play.ai. Their users are NOT interchangeable!<br/>
        /// https://play.ht/studio/api-access
        /// </param>
        /// <param name="lmnt">
        /// Your LMNT API key.<br/>
        /// https://app.lmnt.com/account#api-keys
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedSetTtsApiKeysRequest(
            string? elevenLabs,
            string? cartesia,
            string? playHt,
            string? lmnt)
        {
            this.ElevenLabs = elevenLabs;
            this.Cartesia = cartesia;
            this.PlayHt = playHt;
            this.Lmnt = lmnt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedSetTtsApiKeysRequest" /> class.
        /// </summary>
        public PatchedSetTtsApiKeysRequest()
        {
        }
    }
}