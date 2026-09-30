
#nullable enable

namespace Ultravox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchedAudioClip
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioClipId")]
        public global::System.Guid? AudioClipId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// The duration of the audio.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// The sample rate of the audio in Hz.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleRate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// The size of the audio file in bytes.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizeBytes")]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownership")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.OwnershipEnumJsonConverter))]
        public global::Ultravox.OwnershipEnum? Ownership { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAudioClip" /> class.
        /// </summary>
        /// <param name="audioClipId">
        /// Included only in responses
        /// </param>
        /// <param name="name"></param>
        /// <param name="description"></param>
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
        public PatchedAudioClip(
            global::System.Guid? audioClipId,
            string? name,
            string? description,
            global::System.DateTime? created,
            string? duration,
            int? sampleRate,
            long? sizeBytes,
            global::Ultravox.OwnershipEnum? ownership)
        {
            this.AudioClipId = audioClipId;
            this.Name = name;
            this.Description = description;
            this.Created = created;
            this.Duration = duration;
            this.SampleRate = sampleRate;
            this.SizeBytes = sizeBytes;
            this.Ownership = ownership;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAudioClip" /> class.
        /// </summary>
        public PatchedAudioClip()
        {
        }

    }
}