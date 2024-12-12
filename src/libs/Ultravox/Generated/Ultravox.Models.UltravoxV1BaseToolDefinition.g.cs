
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// The base definition of a tool that can be used during a call. Exactly one<br/>
    ///  implementation (http or client) should be set.
    /// </summary>
    public sealed partial class UltravoxV1BaseToolDefinition
    {
        /// <summary>
        /// The name of the tool, as presented to the model. Must match ^[a-zA-Z0-9_-]{1,64}$.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelToolName")]
        public string? ModelToolName { get; set; }

        /// <summary>
        /// The description of the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The parameters that the tool accepts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamicParameters")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1DynamicParameter>? DynamicParameters { get; set; }

        /// <summary>
        /// The static parameters added when the tool is invoked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("staticParameters")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1StaticParameter>? StaticParameters { get; set; }

        /// <summary>
        /// Additional parameters that are automatically set by the system when the tool is invoked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automaticParameters")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AutomaticParameter>? AutomaticParameters { get; set; }

        /// <summary>
        /// Requirements that must be fulfilled when creating a call for the tool to be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        public global::Ultravox.UltravoxV1ToolRequirements? Requirements { get; set; }

        /// <summary>
        /// The maximum amount of time the tool is allowed for execution. The conversation is frozen<br/>
        ///  while tools run, so prefer sticking to the default unless you're comfortable with that<br/>
        ///  consequence. If your tool is too slow for the default and can't be made faster, still try to<br/>
        ///  keep this timeout as low as possible.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public string? Timeout { get; set; }

        /// <summary>
        /// Details for an HTTP tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http")]
        public global::Ultravox.UltravoxV1BaseHttpToolDetails? Http { get; set; }

        /// <summary>
        /// Details for a client-implemented tool. Only body parameters are allowed<br/>
        ///  for client tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client")]
        public object? Client { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1BaseToolDefinition" /> class.
        /// </summary>
        /// <param name="modelToolName">
        /// The name of the tool, as presented to the model. Must match ^[a-zA-Z0-9_-]{1,64}$.
        /// </param>
        /// <param name="description">
        /// The description of the tool.
        /// </param>
        /// <param name="dynamicParameters">
        /// The parameters that the tool accepts.
        /// </param>
        /// <param name="staticParameters">
        /// The static parameters added when the tool is invoked.
        /// </param>
        /// <param name="automaticParameters">
        /// Additional parameters that are automatically set by the system when the tool is invoked.
        /// </param>
        /// <param name="requirements">
        /// Requirements that must be fulfilled when creating a call for the tool to be used.
        /// </param>
        /// <param name="timeout">
        /// The maximum amount of time the tool is allowed for execution. The conversation is frozen<br/>
        ///  while tools run, so prefer sticking to the default unless you're comfortable with that<br/>
        ///  consequence. If your tool is too slow for the default and can't be made faster, still try to<br/>
        ///  keep this timeout as low as possible.
        /// </param>
        /// <param name="http">
        /// Details for an HTTP tool.
        /// </param>
        /// <param name="client">
        /// Details for a client-implemented tool. Only body parameters are allowed<br/>
        ///  for client tools.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1BaseToolDefinition(
            string? modelToolName,
            string? description,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1DynamicParameter>? dynamicParameters,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1StaticParameter>? staticParameters,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AutomaticParameter>? automaticParameters,
            global::Ultravox.UltravoxV1ToolRequirements? requirements,
            string? timeout,
            global::Ultravox.UltravoxV1BaseHttpToolDetails? http,
            object? client)
        {
            this.ModelToolName = modelToolName;
            this.Description = description;
            this.DynamicParameters = dynamicParameters;
            this.StaticParameters = staticParameters;
            this.AutomaticParameters = automaticParameters;
            this.Requirements = requirements;
            this.Timeout = timeout;
            this.Http = http;
            this.Client = client;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1BaseToolDefinition" /> class.
        /// </summary>
        public UltravoxV1BaseToolDefinition()
        {
        }
    }
}