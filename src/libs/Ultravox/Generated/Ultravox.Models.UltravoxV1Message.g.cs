
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A message exchanged during a call.
    /// </summary>
    public sealed partial class UltravoxV1Message
    {
        /// <summary>
        /// The message's role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.UltravoxV1MessageRoleJsonConverter))]
        public global::Ultravox.UltravoxV1MessageRole? Role { get; set; }

        /// <summary>
        /// The message text for user and agent messages, tool arguments for tool_call messages, tool results for tool_result messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The invocation ID for tool messages. Used to pair tool calls with their results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invocationId")]
        public string? InvocationId { get; set; }

        /// <summary>
        /// The tool name for tool messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolName")]
        public string? ToolName { get; set; }

        /// <summary>
        /// For failed tool calls, additional debugging information. While the text field is<br/>
        ///  presented to the model so it can respond to failures gracefully, the full details<br/>
        ///  are only exposed via the Ultravox REST API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorDetails")]
        public string? ErrorDetails { get; set; }

        /// <summary>
        /// The medium of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medium")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.UltravoxV1MessageMediumJsonConverter))]
        public global::Ultravox.UltravoxV1MessageMedium? Medium { get; set; }

        /// <summary>
        /// The index of the message within the call stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callStageMessageIndex")]
        public int? CallStageMessageIndex { get; set; }

        /// <summary>
        /// The call stage this message appeared in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callStageId")]
        public string? CallStageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1Message" /> class.
        /// </summary>
        /// <param name="role">
        /// The message's role.
        /// </param>
        /// <param name="text">
        /// The message text for user and agent messages, tool arguments for tool_call messages, tool results for tool_result messages.
        /// </param>
        /// <param name="invocationId">
        /// The invocation ID for tool messages. Used to pair tool calls with their results.
        /// </param>
        /// <param name="toolName">
        /// The tool name for tool messages.
        /// </param>
        /// <param name="errorDetails">
        /// For failed tool calls, additional debugging information. While the text field is<br/>
        ///  presented to the model so it can respond to failures gracefully, the full details<br/>
        ///  are only exposed via the Ultravox REST API.
        /// </param>
        /// <param name="medium">
        /// The medium of the message.
        /// </param>
        /// <param name="callStageMessageIndex">
        /// The index of the message within the call stage.
        /// </param>
        /// <param name="callStageId">
        /// The call stage this message appeared in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1Message(
            global::Ultravox.UltravoxV1MessageRole? role,
            string? text,
            string? invocationId,
            string? toolName,
            string? errorDetails,
            global::Ultravox.UltravoxV1MessageMedium? medium,
            int? callStageMessageIndex,
            string? callStageId)
        {
            this.Role = role;
            this.Text = text;
            this.InvocationId = invocationId;
            this.ToolName = toolName;
            this.ErrorDetails = errorDetails;
            this.Medium = medium;
            this.CallStageMessageIndex = callStageMessageIndex;
            this.CallStageId = callStageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1Message" /> class.
        /// </summary>
        public UltravoxV1Message()
        {
        }
    }
}