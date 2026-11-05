
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A rule that sends data messages into a call when an event occurs and a condition is met.<br/>
    ///  Triggers run shortly after their events, in the order the events occur, so their actions<br/>
    ///  may interleave with other activity in the call. If one of its conditions can't be<br/>
    ///  evaluated, that run of the trigger stops, and a trigger whose runs fail three times in a<br/>
    ///  row is dropped for the rest of the call.
    /// </summary>
    public sealed partial class UltravoxV1Trigger
    {
        /// <summary>
        /// Identifies the trigger, such as in call events and in triggerOverrides. Names are 1-64<br/>
        ///  letters, digits, or underscores, unique among the call's triggers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// What causes the trigger to run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public global::Ultravox.UltravoxV1TriggerEvent? Event { get; set; }

        /// <summary>
        /// Filters events. If unset, every event runs the trigger's actions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public global::Ultravox.UltravoxV1TriggerCondition? Condition { get; set; }

        /// <summary>
        /// What happens when the trigger runs (and its condition is met), in order. At most 10,<br/>
        ///  counting the actions within ternaries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TriggerAction>? Actions { get; set; }

        /// <summary>
        /// Variables that only this trigger can read and write, by name, with their initial values.<br/>
        ///  At most 10. Names are letters, digits, or underscores, and may not start with a digit.<br/>
        ///  Each variable keeps the type of its initial value, which must be a string, number, or<br/>
        ///  boolean. Their values persist across runs for the rest of the call. Conditions and<br/>
        ///  templates read them under "local" (e.g. "local.count").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localVariables")]
        public object? LocalVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1Trigger" /> class.
        /// </summary>
        /// <param name="name">
        /// Identifies the trigger, such as in call events and in triggerOverrides. Names are 1-64<br/>
        ///  letters, digits, or underscores, unique among the call's triggers.
        /// </param>
        /// <param name="event">
        /// What causes the trigger to run.
        /// </param>
        /// <param name="condition">
        /// Filters events. If unset, every event runs the trigger's actions.
        /// </param>
        /// <param name="actions">
        /// What happens when the trigger runs (and its condition is met), in order. At most 10,<br/>
        ///  counting the actions within ternaries.
        /// </param>
        /// <param name="localVariables">
        /// Variables that only this trigger can read and write, by name, with their initial values.<br/>
        ///  At most 10. Names are letters, digits, or underscores, and may not start with a digit.<br/>
        ///  Each variable keeps the type of its initial value, which must be a string, number, or<br/>
        ///  boolean. Their values persist across runs for the rest of the call. Conditions and<br/>
        ///  templates read them under "local" (e.g. "local.count").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1Trigger(
            string? name,
            global::Ultravox.UltravoxV1TriggerEvent? @event,
            global::Ultravox.UltravoxV1TriggerCondition? condition,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TriggerAction>? actions,
            object? localVariables)
        {
            this.Name = name;
            this.Event = @event;
            this.Condition = condition;
            this.Actions = actions;
            this.LocalVariables = localVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1Trigger" /> class.
        /// </summary>
        public UltravoxV1Trigger()
        {
        }

    }
}