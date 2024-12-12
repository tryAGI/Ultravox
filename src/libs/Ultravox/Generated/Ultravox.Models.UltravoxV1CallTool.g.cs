
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A tool as used for a particular call (omitting auth details).
    /// </summary>
    public sealed partial class UltravoxV1CallTool
    {
        /// <summary>
        /// The description of the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The parameters presented to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamicParameters")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1DynamicParameter>? DynamicParameters { get; set; }

        /// <summary>
        /// Parameters added unconditionally when the tool is invoked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("staticParameters")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1StaticParameter>? StaticParameters { get; set; }

        /// <summary>
        /// Parameters automatically set by the system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automaticParameters")]
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AutomaticParameter>? AutomaticParameters { get; set; }

        /// <summary>
        /// The maximum amount of time the tool is allowed for execution. The conversation is frozen<br/>
        ///  while tools run, so prefer sticking to the default unless you're comfortable with that<br/>
        ///  consequence. If your tool is too slow for the default and can't be made faster, still try to<br/>
        ///  keep this timeout as low as possible.<br/>
        ///  Note: For read APIs, 0s actually means unset (i.e. use the default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public string? Timeout { get; set; }

        /// <summary>
        /// Details for an HTTP tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http")]
        public global::Ultravox.UltravoxV1HttpCallToolDetails? Http { get; set; }

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
        /// Initializes a new instance of the <see cref="UltravoxV1CallTool" /> class.
        /// </summary>
        /// <param name="description">
        /// The description of the tool.
        /// </param>
        /// <param name="dynamicParameters">
        /// The parameters presented to the model.
        /// </param>
        /// <param name="staticParameters">
        /// Parameters added unconditionally when the tool is invoked.
        /// </param>
        /// <param name="automaticParameters">
        /// Parameters automatically set by the system.
        /// </param>
        /// <param name="timeout">
        /// The maximum amount of time the tool is allowed for execution. The conversation is frozen<br/>
        ///  while tools run, so prefer sticking to the default unless you're comfortable with that<br/>
        ///  consequence. If your tool is too slow for the default and can't be made faster, still try to<br/>
        ///  keep this timeout as low as possible.<br/>
        ///  Note: For read APIs, 0s actually means unset (i.e. use the default).
        /// </param>
        /// <param name="http">
        /// Details for an HTTP tool.
        /// </param>
        /// <param name="client">
        /// Details for a client-implemented tool. Only body parameters are allowed<br/>
        ///  for client tools.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1CallTool(
            string? description,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1DynamicParameter>? dynamicParameters,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1StaticParameter>? staticParameters,
            global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AutomaticParameter>? automaticParameters,
            string? timeout,
            global::Ultravox.UltravoxV1HttpCallToolDetails? http,
            object? client)
        {
            this.Description = description;
            this.DynamicParameters = dynamicParameters;
            this.StaticParameters = staticParameters;
            this.AutomaticParameters = automaticParameters;
            this.Timeout = timeout;
            this.Http = http;
            this.Client = client;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallTool" /> class.
        /// </summary>
        public UltravoxV1CallTool()
        {
        }
    }
}