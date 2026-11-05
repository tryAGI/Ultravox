
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Starts a timer, restarting it if it's already running. Timers last until they fire, are<br/>
    ///  canceled, or the call ends. To fire repeatedly, a timer's trigger can restart it.
    /// </summary>
    public sealed partial class UltravoxV1TriggerActionStartTimer
    {
        /// <summary>
        /// The timer's name. Starting a timer that no trigger listens for does nothing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// How long until the timer fires. Must be at least 10 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delay")]
        public string? Delay { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerActionStartTimer" /> class.
        /// </summary>
        /// <param name="name">
        /// The timer's name. Starting a timer that no trigger listens for does nothing.
        /// </param>
        /// <param name="delay">
        /// How long until the timer fires. Must be at least 10 seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1TriggerActionStartTimer(
            string? name,
            string? delay)
        {
            this.Name = name;
            this.Delay = delay;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerActionStartTimer" /> class.
        /// </summary>
        public UltravoxV1TriggerActionStartTimer()
        {
        }

    }
}