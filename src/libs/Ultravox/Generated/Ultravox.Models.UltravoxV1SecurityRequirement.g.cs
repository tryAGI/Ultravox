
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// A single security requirement that must be met for a tool to be available. Exactly one<br/>
    ///  of query_api_key, header_api_key, or http_auth should be set.
    /// </summary>
    public sealed partial class UltravoxV1SecurityRequirement
    {
        /// <summary>
        /// An API key must be added to the query string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queryApiKey")]
        public global::Ultravox.UltravoxV1QueryApiKeyRequirement? QueryApiKey { get; set; }

        /// <summary>
        /// An API key must be added to a custom header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headerApiKey")]
        public global::Ultravox.UltravoxV1HeaderApiKeyRequirement? HeaderApiKey { get; set; }

        /// <summary>
        /// The HTTP authentication header must be added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpAuth")]
        public global::Ultravox.UltravoxV1HttpAuthRequirement? HttpAuth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SecurityRequirement" /> class.
        /// </summary>
        /// <param name="queryApiKey">
        /// An API key must be added to the query string.
        /// </param>
        /// <param name="headerApiKey">
        /// An API key must be added to a custom header.
        /// </param>
        /// <param name="httpAuth">
        /// The HTTP authentication header must be added.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1SecurityRequirement(
            global::Ultravox.UltravoxV1QueryApiKeyRequirement? queryApiKey,
            global::Ultravox.UltravoxV1HeaderApiKeyRequirement? headerApiKey,
            global::Ultravox.UltravoxV1HttpAuthRequirement? httpAuth)
        {
            this.QueryApiKey = queryApiKey;
            this.HeaderApiKey = headerApiKey;
            this.HttpAuth = httpAuth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SecurityRequirement" /> class.
        /// </summary>
        public UltravoxV1SecurityRequirement()
        {
        }
    }
}