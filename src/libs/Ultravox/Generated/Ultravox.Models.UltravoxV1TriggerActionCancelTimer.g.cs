
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Stops a timer from firing. Does nothing if it isn't running.
    /// </summary>
    public sealed partial class UltravoxV1TriggerActionCancelTimer
    {
        /// <summary>
        /// The timer's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerActionCancelTimer" /> class.
        /// </summary>
        /// <param name="name">
        /// The timer's name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1TriggerActionCancelTimer(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerActionCancelTimer" /> class.
        /// </summary>
        public UltravoxV1TriggerActionCancelTimer()
        {
        }

    }
}