
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Something a trigger does when it runs.
    /// </summary>
    public sealed partial class UltravoxV1TriggerAction
    {
        /// <summary>
        /// A data message to send into the call, such as a user_text_message, forced_agent_message, or<br/>
        ///  spawn_thread. String values within it are Mustache templates rendered against the<br/>
        ///  event and local variables (e.g. "{{event.text}}"), without HTML escaping. The<br/>
        ///  message's type may not be templated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataMessage")]
        public object? DataMessage { get; set; }

        /// <summary>
        /// Runs one list of actions or the other depending on a condition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ternary")]
        public global::Ultravox.UltravoxV1TriggerActionTernary? Ternary { get; set; }

        /// <summary>
        /// Sets a local variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setLocalVariable")]
        public global::Ultravox.UltravoxV1TriggerActionSetLocalVariable? SetLocalVariable { get; set; }

        /// <summary>
        /// Adds to a numeric local variable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incrementLocalVariable")]
        public global::Ultravox.UltravoxV1TriggerActionIncrementLocalVariable? IncrementLocalVariable { get; set; }

        /// <summary>
        /// Starts a timer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTimer")]
        public global::Ultravox.UltravoxV1TriggerActionStartTimer? StartTimer { get; set; }

        /// <summary>
        /// Cancels a timer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelTimer")]
        public global::Ultravox.UltravoxV1TriggerActionCancelTimer? CancelTimer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerAction" /> class.
        /// </summary>
        /// <param name="dataMessage">
        /// A data message to send into the call, such as a user_text_message, forced_agent_message, or<br/>
        ///  spawn_thread. String values within it are Mustache templates rendered against the<br/>
        ///  event and local variables (e.g. "{{event.text}}"), without HTML escaping. The<br/>
        ///  message's type may not be templated.
        /// </param>
        /// <param name="ternary">
        /// Runs one list of actions or the other depending on a condition.
        /// </param>
        /// <param name="setLocalVariable">
        /// Sets a local variable.
        /// </param>
        /// <param name="incrementLocalVariable">
        /// Adds to a numeric local variable.
        /// </param>
        /// <param name="startTimer">
        /// Starts a timer.
        /// </param>
        /// <param name="cancelTimer">
        /// Cancels a timer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1TriggerAction(
            object? dataMessage,
            global::Ultravox.UltravoxV1TriggerActionTernary? ternary,
            global::Ultravox.UltravoxV1TriggerActionSetLocalVariable? setLocalVariable,
            global::Ultravox.UltravoxV1TriggerActionIncrementLocalVariable? incrementLocalVariable,
            global::Ultravox.UltravoxV1TriggerActionStartTimer? startTimer,
            global::Ultravox.UltravoxV1TriggerActionCancelTimer? cancelTimer)
        {
            this.DataMessage = dataMessage;
            this.Ternary = ternary;
            this.SetLocalVariable = setLocalVariable;
            this.IncrementLocalVariable = incrementLocalVariable;
            this.StartTimer = startTimer;
            this.CancelTimer = cancelTimer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerAction" /> class.
        /// </summary>
        public UltravoxV1TriggerAction()
        {
        }

    }
}