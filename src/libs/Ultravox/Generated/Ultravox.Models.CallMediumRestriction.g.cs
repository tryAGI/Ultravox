
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// The mediums the call may use for both user input and agent output. Null allows every medium.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class CallMediumRestriction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowedMediums")]
        public global::System.Collections.Generic.IList<global::Ultravox.CallMediumRestrictionAllowedMedium>? AllowedMediums { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallMediumRestriction" /> class.
        /// </summary>
        /// <param name="allowedMediums"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallMediumRestriction(
            global::System.Collections.Generic.IList<global::Ultravox.CallMediumRestrictionAllowedMedium>? allowedMediums)
        {
            this.AllowedMediums = allowedMediums;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallMediumRestriction" /> class.
        /// </summary>
        public CallMediumRestriction()
        {
        }

    }
}