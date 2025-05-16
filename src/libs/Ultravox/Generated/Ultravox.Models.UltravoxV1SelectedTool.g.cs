
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A tool selected for a particular call. Exactly one of tool_id, tool_name, or<br/>
    ///  temporary_tool should be set.
    /// </summary>
    public sealed partial class UltravoxV1SelectedTool
    {
        /// <summary>
        /// The ID of an existing base tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolId")]
        public string? ToolId { get; set; }

        /// <summary>
        /// The name of an existing base tool. The name must uniquely identify the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolName")]
        public string? ToolName { get; set; }

        /// <summary>
        /// A temporary tool definition, available only for this call (and subsequent<br/>
        ///  calls created using priorCallId without overriding selected tools). Exactly one<br/>
        ///  implementation (http or client) should be set. See the 'Base Tool Definition'<br/>
        ///  schema for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temporaryTool")]
        public global::Ultravox.UltravoxV1BaseToolDefinition? TemporaryTool { get; set; }

        /// <summary>
        /// An override for the model_tool_name. This is primarily useful when using<br/>
        ///  multiple instances of the same durable tool (presumably with different<br/>
        ///  parameter overrides.) The set of tools used within a call must have a unique<br/>
        ///  set of model names and every name must match this pattern: ^[a-zA-Z0-9_-]{1,64}$.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nameOverride")]
        public string? NameOverride { get; set; }

        /// <summary>
        /// An override for the tool's description, as presented to the model. This is primarily<br/>
        ///  useful when using a built-in tool whose description you want to tweak to better fit<br/>
        ///  the rest of your prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descriptionOverride")]
        public string? DescriptionOverride { get; set; }

        /// <summary>
        /// Auth tokens used to satisfy the tool's security requirements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authTokens")]
        public global::System.Collections.Generic.Dictionary<string, string>? AuthTokens { get; set; }

        /// <summary>
        /// Static values to use in place of dynamic parameters. Any parameter included<br/>
        ///  here will be hidden from the model and the static value will be used instead.<br/>
        ///  Some tools may require certain parameters to be overridden, but any parameter<br/>
        ///  can be overridden regardless of whether it is required to be.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameterOverrides")]
        public object? ParameterOverrides { get; set; }

        /// <summary>
        /// For internal use. Relates this tool to a stage transition definition within a call template for attribution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transitionId")]
        public string? TransitionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SelectedTool" /> class.
        /// </summary>
        /// <param name="toolId">
        /// The ID of an existing base tool.
        /// </param>
        /// <param name="toolName">
        /// The name of an existing base tool. The name must uniquely identify the tool.
        /// </param>
        /// <param name="temporaryTool">
        /// A temporary tool definition, available only for this call (and subsequent<br/>
        ///  calls created using priorCallId without overriding selected tools). Exactly one<br/>
        ///  implementation (http or client) should be set. See the 'Base Tool Definition'<br/>
        ///  schema for more details.
        /// </param>
        /// <param name="nameOverride">
        /// An override for the model_tool_name. This is primarily useful when using<br/>
        ///  multiple instances of the same durable tool (presumably with different<br/>
        ///  parameter overrides.) The set of tools used within a call must have a unique<br/>
        ///  set of model names and every name must match this pattern: ^[a-zA-Z0-9_-]{1,64}$.
        /// </param>
        /// <param name="descriptionOverride">
        /// An override for the tool's description, as presented to the model. This is primarily<br/>
        ///  useful when using a built-in tool whose description you want to tweak to better fit<br/>
        ///  the rest of your prompt.
        /// </param>
        /// <param name="authTokens">
        /// Auth tokens used to satisfy the tool's security requirements.
        /// </param>
        /// <param name="parameterOverrides">
        /// Static values to use in place of dynamic parameters. Any parameter included<br/>
        ///  here will be hidden from the model and the static value will be used instead.<br/>
        ///  Some tools may require certain parameters to be overridden, but any parameter<br/>
        ///  can be overridden regardless of whether it is required to be.
        /// </param>
        /// <param name="transitionId">
        /// For internal use. Relates this tool to a stage transition definition within a call template for attribution.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1SelectedTool(
            string? toolId,
            string? toolName,
            global::Ultravox.UltravoxV1BaseToolDefinition? temporaryTool,
            string? nameOverride,
            string? descriptionOverride,
            global::System.Collections.Generic.Dictionary<string, string>? authTokens,
            object? parameterOverrides,
            string? transitionId)
        {
            this.ToolId = toolId;
            this.ToolName = toolName;
            this.TemporaryTool = temporaryTool;
            this.NameOverride = nameOverride;
            this.DescriptionOverride = descriptionOverride;
            this.AuthTokens = authTokens;
            this.ParameterOverrides = parameterOverrides;
            this.TransitionId = transitionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SelectedTool" /> class.
        /// </summary>
        public UltravoxV1SelectedTool()
        {
        }
    }
}