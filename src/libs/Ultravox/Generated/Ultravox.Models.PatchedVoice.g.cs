
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedVoice
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public global::System.Guid? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewUrl")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownership")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.OwnershipEnumJsonConverter))]
        public global::Ultravox.OwnershipEnum? Ownership { get; set; }

        /// <summary>
        /// How billing works for this voice.<br/>
        /// VOICE_BILLING_STYLE_INCLUDED - The cost of this voice is included in the call cost. There are no additional charges for it.<br/>
        /// VOICE_BILLING_STYLE_EXTERNAL - This voice requires an API key for its provider, who will bill for usage separately.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingStyle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.BillingStyleEnumJsonConverter))]
        public global::Ultravox.BillingStyleEnum? BillingStyle { get; set; }

        /// <summary>
        /// A voice not known to Ultravox Realtime that can nonetheless be used for a call.<br/>
        ///  Such voices are significantly less validated than normal voices and you'll be<br/>
        ///  responsible for your own TTS-related errors.<br/>
        ///  Exactly one field must be set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        public global::Ultravox.UltravoxV1ExternalVoice? Definition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedVoice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Included only in responses
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="previewUrl">
        /// Included only in responses
        /// </param>
        /// <param name="ownership">
        /// Included only in responses
        /// </param>
        /// <param name="billingStyle">
        /// How billing works for this voice.<br/>
        /// VOICE_BILLING_STYLE_INCLUDED - The cost of this voice is included in the call cost. There are no additional charges for it.<br/>
        /// VOICE_BILLING_STYLE_EXTERNAL - This voice requires an API key for its provider, who will bill for usage separately.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="definition">
        /// A voice not known to Ultravox Realtime that can nonetheless be used for a call.<br/>
        ///  Such voices are significantly less validated than normal voices and you'll be<br/>
        ///  responsible for your own TTS-related errors.<br/>
        ///  Exactly one field must be set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedVoice(
            global::System.Guid? voiceId,
            string? name,
            string? description,
            string? previewUrl,
            global::Ultravox.OwnershipEnum? ownership,
            global::Ultravox.BillingStyleEnum? billingStyle,
            global::Ultravox.UltravoxV1ExternalVoice? definition)
        {
            this.VoiceId = voiceId;
            this.Name = name;
            this.Description = description;
            this.PreviewUrl = previewUrl;
            this.Ownership = ownership;
            this.BillingStyle = billingStyle;
            this.Definition = definition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedVoice" /> class.
        /// </summary>
        public PatchedVoice()
        {
        }
    }
}