
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Static values to use in place of dynamic parameters. Any parameter included<br/>
    ///  here will be hidden from the model and the static value will be used instead.<br/>
    ///  Some tools may require certain parameters to be overridden, but any parameter<br/>
    ///  can be overridden regardless of whether it is required to be.
    /// </summary>
    public sealed partial class UltravoxV1SelectedToolParameterOverrides
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SelectedToolParameterOverrides" /> class.
        /// </summary>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1SelectedToolParameterOverrides(
 )
        {
        }
    }
}