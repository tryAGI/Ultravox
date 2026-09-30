
#nullable enable

namespace Ultravox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioClip
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioClipId")]
        public global::System.Guid AudioClipId { get; set; } = default!;

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
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime Created { get; set; } = default!;

        /// <summary>
        /// The duration of the audio.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public string Duration { get; set; } = default!;

        /// <summary>
        /// The sample rate of the audio in Hz.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleRate")]
        public int SampleRate { get; set; } = default!;

        /// <summary>
        /// The size of the audio file in bytes.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeBytes")]
        public long SizeBytes { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="AudioClip" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="audioClipId">
        /// Included only in responses
        /// </param>
        /// <param name="created">
        /// Included only in responses
        /// </param>
        /// <param name="duration">
        /// The duration of the audio.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="sampleRate">
        /// The sample rate of the audio in Hz.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="sizeBytes">
        /// The size of the audio file in bytes.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="ownership">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioClip(
            string name,
            string? description,
            global::System.Guid audioClipId = default!,
            global::System.DateTime created = default!,
            string duration = default!,
            int sampleRate = default!,
            long sizeBytes = default!,
            global::Ultravox.OwnershipEnum ownership = default!)
        {
            this.AudioClipId = audioClipId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Created = created;
            this.Duration = duration;
            this.SampleRate = sampleRate;
            this.SizeBytes = sizeBytes;
            this.Ownership = ownership;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioClip" /> class.
        /// </summary>
        public AudioClip()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AudioClip"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AudioClip FromName(string name)
        {
            return new AudioClip
            {
                Name = name,
            };
        }

    }
}