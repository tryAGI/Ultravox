
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A trigger to use in a call or an agent's calls.
    /// </summary>
    public sealed partial class UltravoxV1SelectedTrigger
    {
        /// <summary>
        /// A trigger defined only for this call or agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temporaryTrigger")]
        public global::Ultravox.UltravoxV1Trigger? TemporaryTrigger { get; set; }

        /// <summary>
        /// The ID of an existing trigger. A call uses the trigger as it is when the call is<br/>
        ///  created. An agent's calls use its latest version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerId")]
        public string? TriggerId { get; set; }

        /// <summary>
        /// The name of an existing trigger, used as with triggerId. Your account's own triggers<br/>
        ///  take precedence over public ones with the same name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerName")]
        public string? TriggerName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SelectedTrigger" /> class.
        /// </summary>
        /// <param name="temporaryTrigger">
        /// A trigger defined only for this call or agent.
        /// </param>
        /// <param name="triggerId">
        /// The ID of an existing trigger. A call uses the trigger as it is when the call is<br/>
        ///  created. An agent's calls use its latest version.
        /// </param>
        /// <param name="triggerName">
        /// The name of an existing trigger, used as with triggerId. Your account's own triggers<br/>
        ///  take precedence over public ones with the same name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1SelectedTrigger(
            global::Ultravox.UltravoxV1Trigger? temporaryTrigger,
            string? triggerId,
            string? triggerName)
        {
            this.TemporaryTrigger = temporaryTrigger;
            this.TriggerId = triggerId;
            this.TriggerName = triggerName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SelectedTrigger" /> class.
        /// </summary>
        public UltravoxV1SelectedTrigger()
        {
        }

    }
}