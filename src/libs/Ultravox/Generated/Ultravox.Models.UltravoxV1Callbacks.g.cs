
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Configuration for call lifecycle callbacks.
    /// </summary>
    public sealed partial class UltravoxV1Callbacks
    {
        /// <summary>
        /// Callback invoked when the call is joined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joined")]
        public global::Ultravox.UltravoxV1Callback? Joined { get; set; }

        /// <summary>
        /// Callback invoked when the call has ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ended")]
        public global::Ultravox.UltravoxV1Callback? Ended { get; set; }

        /// <summary>
        /// Callback invoked when the call is billed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billed")]
        public global::Ultravox.UltravoxV1Callback? Billed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1Callbacks" /> class.
        /// </summary>
        /// <param name="joined">
        /// Callback invoked when the call is joined.
        /// </param>
        /// <param name="ended">
        /// Callback invoked when the call has ended.
        /// </param>
        /// <param name="billed">
        /// Callback invoked when the call is billed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1Callbacks(
            global::Ultravox.UltravoxV1Callback? joined,
            global::Ultravox.UltravoxV1Callback? ended,
            global::Ultravox.UltravoxV1Callback? billed)
        {
            this.Joined = joined;
            this.Ended = ended;
            this.Billed = billed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1Callbacks" /> class.
        /// </summary>
        public UltravoxV1Callbacks()
        {
        }
    }
}