
#nullable enable

namespace Ultravox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolsTestCreateRequest
    {
        /// <summary>
        /// Values satisfying the tool's security requirements, keyed by requirement name. Applied the same way as for a real call: a headerApiKey requirement sends its value as the named header, a queryApiKey requirement as the named query parameter, and an httpAuth requirement as an Authorization header prefixed with the requirement's scheme.<br/>
        /// Example: {"myServiceApiKey":"my-secret-value"}
        /// </summary>
        /// <example>{"myServiceApiKey":"my-secret-value"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("authTokens")]
        public global::System.Collections.Generic.Dictionary<string, string>? AuthTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsTestCreateRequest" /> class.
        /// </summary>
        /// <param name="authTokens">
        /// Values satisfying the tool's security requirements, keyed by requirement name. Applied the same way as for a real call: a headerApiKey requirement sends its value as the named header, a queryApiKey requirement as the named query parameter, and an httpAuth requirement as an Authorization header prefixed with the requirement's scheme.<br/>
        /// Example: {"myServiceApiKey":"my-secret-value"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsTestCreateRequest(
            global::System.Collections.Generic.Dictionary<string, string>? authTokens)
        {
            this.AuthTokens = authTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsTestCreateRequest" /> class.
        /// </summary>
        public ToolsTestCreateRequest()
        {
        }

    }
}