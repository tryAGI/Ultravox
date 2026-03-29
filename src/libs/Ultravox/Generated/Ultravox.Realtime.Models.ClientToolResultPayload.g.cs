
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Result of a client tool execution.
    /// </summary>
    public sealed partial class ClientToolResultPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.ClientToolResultPayloadTypeJsonConverter))]
        public global::Ultravox.Realtime.ClientToolResultPayloadType Type { get; set; }

        /// <summary>
        /// ID matching the tool invocation request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvocationId { get; set; }

        /// <summary>
        /// Tool execution result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public string? Result { get; set; }

        /// <summary>
        /// Response type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.ClientToolResultPayloadResponseTypeJsonConverter))]
        public global::Ultravox.Realtime.ClientToolResultPayloadResponseType? ResponseType { get; set; }

        /// <summary>
        /// How the agent should react.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentReaction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.ClientToolResultPayloadAgentReactionJsonConverter))]
        public global::Ultravox.Realtime.ClientToolResultPayloadAgentReaction? AgentReaction { get; set; }

        /// <summary>
        /// Error type if the tool failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.ClientToolResultPayloadErrorTypeJsonConverter))]
        public global::Ultravox.Realtime.ClientToolResultPayloadErrorType? ErrorType { get; set; }

        /// <summary>
        /// Error message if the tool failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolResultPayload" /> class.
        /// </summary>
        /// <param name="invocationId">
        /// ID matching the tool invocation request.
        /// </param>
        /// <param name="type"></param>
        /// <param name="result">
        /// Tool execution result.
        /// </param>
        /// <param name="responseType">
        /// Response type.
        /// </param>
        /// <param name="agentReaction">
        /// How the agent should react.
        /// </param>
        /// <param name="errorType">
        /// Error type if the tool failed.
        /// </param>
        /// <param name="errorMessage">
        /// Error message if the tool failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientToolResultPayload(
            string invocationId,
            global::Ultravox.Realtime.ClientToolResultPayloadType type,
            string? result,
            global::Ultravox.Realtime.ClientToolResultPayloadResponseType? responseType,
            global::Ultravox.Realtime.ClientToolResultPayloadAgentReaction? agentReaction,
            global::Ultravox.Realtime.ClientToolResultPayloadErrorType? errorType,
            string? errorMessage)
        {
            this.Type = type;
            this.InvocationId = invocationId ?? throw new global::System.ArgumentNullException(nameof(invocationId));
            this.Result = result;
            this.ResponseType = responseType;
            this.AgentReaction = agentReaction;
            this.ErrorType = errorType;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolResultPayload" /> class.
        /// </summary>
        public ClientToolResultPayload()
        {
        }
    }
}