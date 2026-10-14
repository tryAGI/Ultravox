
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Limits the mediums a call may use for both user input and agent output.
    /// </summary>
    public sealed partial class UltravoxV1MediumRestriction
    {
        /// <summary>
        /// The mediums the call may use. Must not be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedMediums")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1MediumRestrictionAllowedMedium>? AllowedMediums { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1MediumRestriction" /> class.
        /// </summary>
        /// <param name="allowedMediums">
        /// The mediums the call may use. Must not be empty.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1MediumRestriction(
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1MediumRestrictionAllowedMedium>? allowedMediums)
        {
            this.AllowedMediums = allowedMediums;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1MediumRestriction" /> class.
        /// </summary>
        public UltravoxV1MediumRestriction()
        {
        }

    }
}