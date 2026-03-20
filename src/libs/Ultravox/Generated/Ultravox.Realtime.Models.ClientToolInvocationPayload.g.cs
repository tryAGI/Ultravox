
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Server request to execute a client-side tool.
    /// </summary>
    public sealed partial class ClientToolInvocationPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.Realtime.JsonConverters.ClientToolInvocationPayloadTypeJsonConverter))]
        public global::Ultravox.Realtime.ClientToolInvocationPayloadType Type { get; set; }

        /// <summary>
        /// Name of the tool to execute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Unique invocation ID to match with the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvocationId { get; set; }

        /// <summary>
        /// Tool parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolInvocationPayload" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="toolName">
        /// Name of the tool to execute.
        /// </param>
        /// <param name="invocationId">
        /// Unique invocation ID to match with the result.
        /// </param>
        /// <param name="parameters">
        /// Tool parameters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientToolInvocationPayload(
            string toolName,
            string invocationId,
            object parameters,
            global::Ultravox.Realtime.ClientToolInvocationPayloadType type)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.InvocationId = invocationId ?? throw new global::System.ArgumentNullException(nameof(invocationId));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolInvocationPayload" /> class.
        /// </summary>
        public ClientToolInvocationPayload()
        {
        }
    }
}