
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Data connection enables an auxiliary websocket for streaming data messages.
    /// </summary>
    public sealed partial class UltravoxV1DataConnectionConfig
    {
        /// <summary>
        /// The websocket URL to which the session will connect to stream data messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("websocketUrl")]
        public string? WebsocketUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1DataConnectionConfig" /> class.
        /// </summary>
        /// <param name="websocketUrl">
        /// The websocket URL to which the session will connect to stream data messages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1DataConnectionConfig(
            string? websocketUrl)
        {
            this.WebsocketUrl = websocketUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1DataConnectionConfig" /> class.
        /// </summary>
        public UltravoxV1DataConnectionConfig()
        {
        }
    }
}