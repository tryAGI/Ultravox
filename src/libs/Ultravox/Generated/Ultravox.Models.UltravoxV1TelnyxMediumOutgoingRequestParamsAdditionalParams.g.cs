
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Additional parameters to include in the Telnyx call creation request.<br/>
    ///  See https://developers.telnyx.com/api/call-scripting/initiate-texml-call
    /// </summary>
    public sealed partial class UltravoxV1TelnyxMediumOutgoingRequestParamsAdditionalParams
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}