
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Values satisfying the tool's security requirements, keyed by requirement name. Applied the same way as for a real call: a headerApiKey requirement sends its value as the named header, a queryApiKey requirement as the named query parameter, and an httpAuth requirement as an Authorization header prefixed with the requirement's scheme.<br/>
    /// Example: {"myServiceApiKey":"my-secret-value"}
    /// </summary>
    public sealed partial class ToolsTestCreateRequestAuthTokens
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}