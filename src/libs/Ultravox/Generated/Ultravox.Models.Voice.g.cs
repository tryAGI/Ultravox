
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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Included only in responses
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
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownership")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.OwnershipEnumJsonConverter))]
        public global::Ultravox.OwnershipEnum Ownership { get; set; } = default!;

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
        /// <param name="name">
        /// Included only in responses
        /// </param>
        /// <param name="description">
        /// Included only in responses
        /// </param>
        /// <param name="previewUrl">
        /// Included only in responses
        /// </param>
        /// <param name="ownership">
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Voice(
            string? description,
            string? previewUrl,
            global::System.Guid voiceId = default!,
            string name = default!,
            global::Ultravox.OwnershipEnum ownership = default!)
        {
            this.VoiceId = voiceId;
            this.Name = name;
            this.Description = description;
            this.PreviewUrl = previewUrl;
            this.Ownership = ownership;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        public Voice()
        {
        }
    }
}