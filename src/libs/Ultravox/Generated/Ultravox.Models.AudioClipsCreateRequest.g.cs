
#nullable enable

namespace Ultravox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AudioClipsCreateRequest
    {
        /// <summary>
        /// A mono 16-bit PCM WAV file with a sample rate between 16kHz and 48kHz containing at most 60 seconds of audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// A mono 16-bit PCM WAV file with a sample rate between 16kHz and 48kHz containing at most 60 seconds of audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Name for the audio clip. Must be unique within your account.<br/>
        /// Example: my_office
        /// </summary>
        /// <example>my_office</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional description for the audio clip.<br/>
        /// Example: Background chatter recorded in our office
        /// </summary>
        /// <example>Background chatter recorded in our office</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioClipsCreateRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// A mono 16-bit PCM WAV file with a sample rate between 16kHz and 48kHz containing at most 60 seconds of audio.
        /// </param>
        /// <param name="filename">
        /// A mono 16-bit PCM WAV file with a sample rate between 16kHz and 48kHz containing at most 60 seconds of audio.
        /// </param>
        /// <param name="name">
        /// Name for the audio clip. Must be unique within your account.<br/>
        /// Example: my_office
        /// </param>
        /// <param name="description">
        /// Optional description for the audio clip.<br/>
        /// Example: Background chatter recorded in our office
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioClipsCreateRequest(
            byte[] file,
            string filename,
            string name,
            string? description)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioClipsCreateRequest" /> class.
        /// </summary>
        public AudioClipsCreateRequest()
        {
        }

    }
}