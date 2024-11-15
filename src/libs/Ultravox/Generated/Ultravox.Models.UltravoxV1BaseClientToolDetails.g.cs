
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Details for invoking a tool expected to be implemented by the client.
    /// </summary>
    public sealed partial class UltravoxV1BaseClientToolDetails
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1BaseClientToolDetails" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1BaseClientToolDetails(
 )
        {
        }
    }
}