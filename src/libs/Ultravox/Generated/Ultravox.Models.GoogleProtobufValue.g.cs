
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Represents a dynamically typed value which can be either null, a number, a string, a boolean, a recursive struct value, or a list of values.
    /// </summary>
    public sealed partial class GoogleProtobufValue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleProtobufValue" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GoogleProtobufValue(
 )
        {
        }
    }
}