
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Settings that guide speech recognition of the user's speech.<br/>
    ///  When prompts are used, a transcript that only repeats them (as speech recognition can<br/>
    ///  for audio without words, such as a hum) is treated as empty.
    /// </summary>
    public sealed partial class UltravoxV1TranscriptionSettings
    {
        /// <summary>
        /// Words or phrases the user is likely to say, such as names, places or the answers<br/>
        ///  the agent expects. They bias speech recognition towards these terms.<br/>
        ///  At most 100 prompts (99 when `includeAgentContext` is true), each at most 100<br/>
        ///  characters of letters, digits, whitespace and the punctuation . , ; : ! ? ( ) - '
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompts")]
        public global::System.Collections.Generic.IList<string>? Prompts { get; set; }

        /// <summary>
        /// Whether to also guide recognition of each user turn with the agent's last message<br/>
        ///  before it, typically the question being answered (its last 100 characters, with<br/>
        ///  characters outside the allowed set removed). This mainly helps short answers.<br/>
        ///  Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeAgentContext")]
        public bool? IncludeAgentContext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TranscriptionSettings" /> class.
        /// </summary>
        /// <param name="prompts">
        /// Words or phrases the user is likely to say, such as names, places or the answers<br/>
        ///  the agent expects. They bias speech recognition towards these terms.<br/>
        ///  At most 100 prompts (99 when `includeAgentContext` is true), each at most 100<br/>
        ///  characters of letters, digits, whitespace and the punctuation . , ; : ! ? ( ) - '
        /// </param>
        /// <param name="includeAgentContext">
        /// Whether to also guide recognition of each user turn with the agent's last message<br/>
        ///  before it, typically the question being answered (its last 100 characters, with<br/>
        ///  characters outside the allowed set removed). This mainly helps short answers.<br/>
        ///  Defaults to false.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1TranscriptionSettings(
            global::System.Collections.Generic.IList<string>? prompts,
            bool? includeAgentContext)
        {
            this.Prompts = prompts;
            this.IncludeAgentContext = includeAgentContext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TranscriptionSettings" /> class.
        /// </summary>
        public UltravoxV1TranscriptionSettings()
        {
        }

    }
}