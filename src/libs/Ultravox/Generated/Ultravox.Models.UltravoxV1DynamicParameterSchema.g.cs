
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// The JsonSchema definition of the parameter. This typically<br/>
    ///  includes things like type, description, enum values, format,<br/>
    ///  other restrictions, etc.
    /// </summary>
    public sealed partial class UltravoxV1DynamicParameterSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1DynamicParameterSchema" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1DynamicParameterSchema(
 )
        {
        }
    }
}