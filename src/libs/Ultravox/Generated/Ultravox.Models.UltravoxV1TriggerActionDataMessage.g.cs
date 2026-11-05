
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A data message to send into the call, such as a user_text_message, forced_agent_message, or<br/>
    ///  spawn_thread. String values within it are Mustache templates rendered against the<br/>
    ///  event and local variables (e.g. "{{event.text}}"), without HTML escaping. The<br/>
    ///  message's type may not be templated.
    /// </summary>
    public sealed partial class UltravoxV1TriggerActionDataMessage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}