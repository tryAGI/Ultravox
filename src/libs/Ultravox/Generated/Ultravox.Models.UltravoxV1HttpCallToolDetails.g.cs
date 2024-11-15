
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Details for a CallTool implemented via HTTP requests.
    /// </summary>
    public sealed partial class UltravoxV1HttpCallToolDetails
    {
        /// <summary>
        /// The base URL pattern for the tool, possibly with placeholders for path parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseUrlPattern")]
        public string? BaseUrlPattern { get; set; }

        /// <summary>
        /// The HTTP method for the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpMethod")]
        public string? HttpMethod { get; set; }

        /// <summary>
        /// Auth headers added when the tool is invoked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authHeaders")]
        public global::System.Collections.Generic.IList<string>? AuthHeaders { get; set; }

        /// <summary>
        /// Auth query parameters added when the tool is invoked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authQueryParams")]
        public global::System.Collections.Generic.IList<string>? AuthQueryParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1HttpCallToolDetails" /> class.
        /// </summary>
        /// <param name="baseUrlPattern">
        /// The base URL pattern for the tool, possibly with placeholders for path parameters.
        /// </param>
        /// <param name="httpMethod">
        /// The HTTP method for the tool.
        /// </param>
        /// <param name="authHeaders">
        /// Auth headers added when the tool is invoked.
        /// </param>
        /// <param name="authQueryParams">
        /// Auth query parameters added when the tool is invoked.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1HttpCallToolDetails(
            string? baseUrlPattern,
            string? httpMethod,
            global::System.Collections.Generic.IList<string>? authHeaders,
            global::System.Collections.Generic.IList<string>? authQueryParams)
        {
            this.BaseUrlPattern = baseUrlPattern;
            this.HttpMethod = httpMethod;
            this.AuthHeaders = authHeaders;
            this.AuthQueryParams = authQueryParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1HttpCallToolDetails" /> class.
        /// </summary>
        public UltravoxV1HttpCallToolDetails()
        {
        }
    }
}