
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Additional parameters to include in the Twilio call creation request.<br/>
    ///  See https://www.twilio.com/docs/voice/api/call-resource#request-body-parameters
    /// </summary>
    public sealed partial class UltravoxV1TwilioMediumOutgoingRequestParamsAdditionalParams
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}