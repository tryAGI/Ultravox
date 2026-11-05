
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Adds to one of the trigger's numeric local variables.
    /// </summary>
    public sealed partial class UltravoxV1TriggerActionIncrementLocalVariable
    {
        /// <summary>
        /// The local variable's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The amount to add, which may be negative. Defaults to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public double? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerActionIncrementLocalVariable" /> class.
        /// </summary>
        /// <param name="name">
        /// The local variable's name.
        /// </param>
        /// <param name="value">
        /// The amount to add, which may be negative. Defaults to 1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1TriggerActionIncrementLocalVariable(
            string? name,
            double? value)
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerActionIncrementLocalVariable" /> class.
        /// </summary>
        public UltravoxV1TriggerActionIncrementLocalVariable()
        {
        }

    }
}