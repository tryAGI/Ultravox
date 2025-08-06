
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Voice
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public global::System.Guid VoiceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// BCP47 language code for the primary language supported by this voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryLanguage")]
        public string? PrimaryLanguage { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("previewUrl")]
        public string PreviewUrl { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownership")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.OwnershipEnumJsonConverter))]
        public global::Ultravox.OwnershipEnum Ownership { get; set; } = default!;

        /// <summary>
        /// How billing works for this voice.<br/>
        /// VOICE_BILLING_STYLE_INCLUDED - The cost of this voice is included in the call cost. There are no additional charges for it.<br/>
        /// VOICE_BILLING_STYLE_EXTERNAL - This voice requires an API key for its provider, who will bill for usage separately.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("billingStyle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.BillingStyleEnumJsonConverter))]
        public global::Ultravox.BillingStyleEnum BillingStyle { get; set; } = default!;

        /// <summary>
        /// A voice not known to Ultravox Realtime that can nonetheless be used for a call.<br/>
        ///  Such voices are significantly less validated than normal voices and you'll be<br/>
        ///  responsible for your own TTS-related errors.<br/>
        ///  Exactly one field must be set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Ultravox.UltravoxV1ExternalVoice Definition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// Included only in responses
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="primaryLanguage">
        /// BCP47 language code for the primary language supported by this voice.
        /// </param>
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
        public Voice(
            string name,
            global::Ultravox.UltravoxV1ExternalVoice definition,
            string? description,
            string? primaryLanguage,
            global::System.Guid voiceId = default!,
            string previewUrl = default!,
            global::Ultravox.OwnershipEnum ownership = default!,
            global::Ultravox.BillingStyleEnum billingStyle = default!)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
            this.VoiceId = voiceId;
            this.Description = description;
            this.PrimaryLanguage = primaryLanguage;
            this.PreviewUrl = previewUrl;
            this.Ownership = ownership;
            this.BillingStyle = billingStyle;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        public Voice()
        {
        }
    }
}