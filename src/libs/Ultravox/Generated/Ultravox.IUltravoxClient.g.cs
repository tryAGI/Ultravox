
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// API for the Ultravox service.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IUltravoxClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AccountsClient Accounts { get; }

        /// <summary>
        /// 
        /// </summary>
        public ApiKeysClient ApiKeys { get; }

        /// <summary>
        /// 
        /// </summary>
        public CallsClient Calls { get; }

        /// <summary>
        /// 
        /// </summary>
        public SchemaClient Schema { get; }

        /// <summary>
        /// 
        /// </summary>
        public ToolsClient Tools { get; }

        /// <summary>
        /// 
        /// </summary>
        public VoicesClient Voices { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks { get; }

    }
}