
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Either a simple condition (`property`, `operator`, and `value`) or a complex condition<br/>
    ///  (`operator` and child `conditions`). A trigger may have at most 20 conditions, counting<br/>
    ///  every child and the conditions of its ternaries.
    /// </summary>
    public sealed partial class UltravoxV1TriggerCondition
    {
        /// <summary>
        /// A dotted path to the property being compared. Properties of the event are under "event"<br/>
        ///  (e.g. "event.role" for a transcript), the trigger's local variables are under "local",<br/>
        ///  and global data is under "global" (e.g. "global.callState", the state from the call's<br/>
        ///  latest state message).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property")]
        public string? Property { get; set; }

        /// <summary>
        /// Arguments for global properties that take them. Values are Mustache templates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propertyArguments")]
        public global::System.Collections.Generic.Dictionary<string, string>? PropertyArguments { get; set; }

        /// <summary>
        /// How the condition is evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.UltravoxV1TriggerConditionOperatorJsonConverter))]
        public global::Ultravox.UltravoxV1TriggerConditionOperator? Operator { get; set; }

        /// <summary>
        /// The value the property is compared to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::Ultravox.GoogleProtobufValue? Value { get; set; }

        /// <summary>
        /// Child conditions for complex operators.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TriggerCondition>? Conditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerCondition" /> class.
        /// </summary>
        /// <param name="property">
        /// A dotted path to the property being compared. Properties of the event are under "event"<br/>
        ///  (e.g. "event.role" for a transcript), the trigger's local variables are under "local",<br/>
        ///  and global data is under "global" (e.g. "global.callState", the state from the call's<br/>
        ///  latest state message).
        /// </param>
        /// <param name="propertyArguments">
        /// Arguments for global properties that take them. Values are Mustache templates.
        /// </param>
        /// <param name="operator">
        /// How the condition is evaluated.
        /// </param>
        /// <param name="value">
        /// The value the property is compared to.
        /// </param>
        /// <param name="conditions">
        /// Child conditions for complex operators.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1TriggerCondition(
            string? property,
            global::System.Collections.Generic.Dictionary<string, string>? propertyArguments,
            global::Ultravox.UltravoxV1TriggerConditionOperator? @operator,
            global::Ultravox.GoogleProtobufValue? value,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TriggerCondition>? conditions)
        {
            this.Property = property;
            this.PropertyArguments = propertyArguments;
            this.Operator = @operator;
            this.Value = value;
            this.Conditions = conditions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerCondition" /> class.
        /// </summary>
        public UltravoxV1TriggerCondition()
        {
        }

    }
}