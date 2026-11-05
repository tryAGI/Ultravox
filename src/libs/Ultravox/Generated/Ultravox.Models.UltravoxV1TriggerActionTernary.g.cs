
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Runs one list of actions or the other depending on a condition.
    /// </summary>
    public sealed partial class UltravoxV1TriggerActionTernary
    {
        /// <summary>
        /// Decides which list of actions runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public global::Ultravox.UltravoxV1TriggerCondition? Condition { get; set; }

        /// <summary>
        /// The actions to run when the condition is met.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whenTrue")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TriggerAction>? WhenTrue { get; set; }

        /// <summary>
        /// The actions to run when the condition isn't met.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whenFalse")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TriggerAction>? WhenFalse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerActionTernary" /> class.
        /// </summary>
        /// <param name="condition">
        /// Decides which list of actions runs.
        /// </param>
        /// <param name="whenTrue">
        /// The actions to run when the condition is met.
        /// </param>
        /// <param name="whenFalse">
        /// The actions to run when the condition isn't met.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1TriggerActionTernary(
            global::Ultravox.UltravoxV1TriggerCondition? condition,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TriggerAction>? whenTrue,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TriggerAction>? whenFalse)
        {
            this.Condition = condition;
            this.WhenTrue = whenTrue;
            this.WhenFalse = whenFalse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerActionTernary" /> class.
        /// </summary>
        public UltravoxV1TriggerActionTernary()
        {
        }

    }
}