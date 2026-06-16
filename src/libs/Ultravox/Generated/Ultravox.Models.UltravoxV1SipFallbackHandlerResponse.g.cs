
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// The response a customer-hosted SIP fallback handler returns to Ultravox when<br/>
    ///  Ultravox receives an incoming SIP INVITE that does not match any configured<br/>
    ///  agent allowance. The handler decides how to dispatch the call by returning<br/>
    ///  one of the variants below.
    /// </summary>
    public sealed partial class UltravoxV1SipFallbackHandlerResponse
    {
        /// <summary>
        /// Create the call using an agent. The agentId subfield is required in this case.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startAgentCall")]
        public global::Ultravox.UltravoxV1StartAgentCallRequest? StartAgentCall { get; set; }

        /// <summary>
        /// Create the call with the supplied inline configuration (no agent).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startCall")]
        public global::Ultravox.UltravoxV1StartCallRequest? StartCall { get; set; }

        /// <summary>
        /// Reject the call with an appropriate error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reject")]
        public global::Ultravox.UltravoxV1SipRejection? Reject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SipFallbackHandlerResponse" /> class.
        /// </summary>
        /// <param name="startAgentCall">
        /// Create the call using an agent. The agentId subfield is required in this case.
        /// </param>
        /// <param name="startCall">
        /// Create the call with the supplied inline configuration (no agent).
        /// </param>
        /// <param name="reject">
        /// Reject the call with an appropriate error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1SipFallbackHandlerResponse(
            global::Ultravox.UltravoxV1StartAgentCallRequest? startAgentCall,
            global::Ultravox.UltravoxV1StartCallRequest? startCall,
            global::Ultravox.UltravoxV1SipRejection? reject)
        {
            this.StartAgentCall = startAgentCall;
            this.StartCall = startCall;
            this.Reject = reject;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SipFallbackHandlerResponse" /> class.
        /// </summary>
        public UltravoxV1SipFallbackHandlerResponse()
        {
        }

    }
}