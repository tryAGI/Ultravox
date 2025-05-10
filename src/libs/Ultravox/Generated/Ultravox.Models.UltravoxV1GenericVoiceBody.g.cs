
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// The request body to send. Some field should include a placeholder for text<br/>
    ///  represented as {text}. The placeholder will be replaced with the text to synthesize.
    /// </summary>
    public sealed partial class UltravoxV1GenericVoiceBody
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}