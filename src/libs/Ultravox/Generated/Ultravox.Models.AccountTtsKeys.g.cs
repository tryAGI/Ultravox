
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountTtsKeys
    {
        /// <summary>
        /// The ElevenLabs API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elevenLabs")]
        public global::Ultravox.KeyPrefix? ElevenLabs { get; set; }

        /// <summary>
        /// The Cartesia API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cartesia")]
        public global::Ultravox.KeyPrefix? Cartesia { get; set; }

        /// <summary>
        /// The LMNT API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lmnt")]
        public global::Ultravox.KeyPrefix? Lmnt { get; set; }

        /// <summary>
        /// The Google service account key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        public global::Ultravox.KeyPrefix? Google { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTtsKeys" /> class.
        /// </summary>
        /// <param name="elevenLabs">
        /// The ElevenLabs API key.
        /// </param>
        /// <param name="cartesia">
        /// The Cartesia API key.
        /// </param>
        /// <param name="lmnt">
        /// The LMNT API key.
        /// </param>
        /// <param name="google">
        /// The Google service account key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccountTtsKeys(
            global::Ultravox.KeyPrefix? elevenLabs,
            global::Ultravox.KeyPrefix? cartesia,
            global::Ultravox.KeyPrefix? lmnt,
            global::Ultravox.KeyPrefix? google)
        {
            this.ElevenLabs = elevenLabs;
            this.Cartesia = cartesia;
            this.Lmnt = lmnt;
            this.Google = google;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountTtsKeys" /> class.
        /// </summary>
        public AccountTtsKeys()
        {
        }
    }
}