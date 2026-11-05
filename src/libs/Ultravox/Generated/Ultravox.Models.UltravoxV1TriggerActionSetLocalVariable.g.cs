
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Sets one of the trigger's local variables.
    /// </summary>
    public sealed partial class UltravoxV1TriggerActionSetLocalVariable
    {
        /// <summary>
        /// The local variable's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The new value, of the variable's type. String values within it are Mustache<br/>
        ///  templates, as in `dataMessage`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public global::Ultravox.GoogleProtobufValue? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerActionSetLocalVariable" /> class.
        /// </summary>
        /// <param name="name">
        /// The local variable's name.
        /// </param>
        /// <param name="value">
        /// The new value, of the variable's type. String values within it are Mustache<br/>
        ///  templates, as in `dataMessage`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1TriggerActionSetLocalVariable(
            string? name,
            global::Ultravox.GoogleProtobufValue? value)
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerActionSetLocalVariable" /> class.
        /// </summary>
        public UltravoxV1TriggerActionSetLocalVariable()
        {
        }

    }
}