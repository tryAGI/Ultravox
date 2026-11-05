
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Variables that only this trigger can read and write, by name, with their initial values.<br/>
    ///  At most 10. Names are letters, digits, or underscores, and may not start with a digit.<br/>
    ///  Each variable keeps the type of its initial value, which must be a string, number, or<br/>
    ///  boolean. Their values persist across runs for the rest of the call. Conditions and<br/>
    ///  templates read them under "local" (e.g. "local.count").
    /// </summary>
    public sealed partial class UltravoxV1TriggerLocalVariables
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}