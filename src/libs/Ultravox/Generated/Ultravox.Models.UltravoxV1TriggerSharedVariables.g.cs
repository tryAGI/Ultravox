
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Variables shared with the call's other triggers that declare them, by name, with their<br/>
    ///  initial values. At most 10. They follow the same rules as `localVariables`, but<br/>
    ///  conditions and templates read them under "shared" (e.g. "shared.verified"). Every<br/>
    ///  trigger that declares a name must declare the same initial value. A trigger can only<br/>
    ///  read and write the shared variables it declares.
    /// </summary>
    public sealed partial class UltravoxV1TriggerSharedVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}