
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// The security requirements for a request. All requirements must be met.
    /// </summary>
    public sealed partial class UltravoxV1SecurityRequirements
    {
        /// <summary>
        /// Requirements keyed by name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        public global::System.Collections.Generic.Dictionary<string, global::Ultravox.UltravoxV1SecurityRequirement>? Requirements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SecurityRequirements" /> class.
        /// </summary>
        /// <param name="requirements">
        /// Requirements keyed by name.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1SecurityRequirements(
            global::System.Collections.Generic.Dictionary<string, global::Ultravox.UltravoxV1SecurityRequirement>? requirements)
        {
            this.Requirements = requirements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SecurityRequirements" /> class.
        /// </summary>
        public UltravoxV1SecurityRequirements()
        {
        }
    }
}