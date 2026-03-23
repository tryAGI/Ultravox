
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
        /// Audio configuration for the data connection. If not set, no audio will be sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioConfig")]
        public global::Ultravox.UltravoxV1DataConnectionAudioConfig? AudioConfig { get; set; }

        /// <summary>
        /// Controls which data messages are enabled for the data connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataMessages")]
        public global::Ultravox.UltravoxV1EnabledDataMessages? DataMessages { get; set; }

        /// <summary>
        /// Additional headers to include when connecting to the websocket endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

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
        /// <param name="audioConfig">
        /// Audio configuration for the data connection. If not set, no audio will be sent.
        /// </param>
        /// <param name="dataMessages">
        /// Controls which data messages are enabled for the data connection.
        /// </param>
        /// <param name="headers">
        /// Additional headers to include when connecting to the websocket endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1DataConnectionConfig(
            string? websocketUrl,
            global::Ultravox.UltravoxV1DataConnectionAudioConfig? audioConfig,
            global::Ultravox.UltravoxV1EnabledDataMessages? dataMessages,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.WebsocketUrl = websocketUrl;
            this.AudioConfig = audioConfig;
            this.DataMessages = dataMessages;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1DataConnectionConfig" /> class.
        /// </summary>
        public UltravoxV1DataConnectionConfig()
        {
        }
    }
}