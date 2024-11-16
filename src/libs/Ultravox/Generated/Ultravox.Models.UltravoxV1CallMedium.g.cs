
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Details about a call's protocol. By default, calls occur over WebRTC using<br/>
    ///  the Ultravox client SDK. Setting a different call medium will prepare the<br/>
    ///  server for a call using a different protocol.<br/>
    ///  At most one call medium may be set.
    /// </summary>
    public sealed partial class UltravoxV1CallMedium
    {
        /// <summary>
        /// The call will use WebRTC with the Ultravox client SDK.<br/>
        ///  This is the default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webRtc")]
        public object? WebRtc { get; set; }

        /// <summary>
        /// The call will use Twilio's "Media Streams" protocol.<br/>
        ///  Once you have a join URL from starting a call, include it in your<br/>
        ///  TwiML like so:<br/>
        ///  &lt;Connect&gt;&lt;Stream url=${your-join-url} /&gt;&lt;/Connect&gt;<br/>
        ///  This works for both inbound and outbound calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twilio")]
        public object? Twilio { get; set; }

        /// <summary>
        /// The call will use a plain websocket connection. This is unlikely to yield an acceptable user<br/>
        ///  experience if used from a browser or mobile client, but may be suitable for a<br/>
        ///  server-to-server connection. This option provides a simple way to connect your own server to<br/>
        ///  an Ultravox inference instance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverWebSocket")]
        public global::Ultravox.UltravoxV1CallMediumWebSocketMedium? ServerWebSocket { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMedium" /> class.
        /// </summary>
        /// <param name="webRtc">
        /// The call will use WebRTC with the Ultravox client SDK.<br/>
        ///  This is the default.
        /// </param>
        /// <param name="twilio">
        /// The call will use Twilio's "Media Streams" protocol.<br/>
        ///  Once you have a join URL from starting a call, include it in your<br/>
        ///  TwiML like so:<br/>
        ///  &lt;Connect&gt;&lt;Stream url=${your-join-url} /&gt;&lt;/Connect&gt;<br/>
        ///  This works for both inbound and outbound calls.
        /// </param>
        /// <param name="serverWebSocket">
        /// The call will use a plain websocket connection. This is unlikely to yield an acceptable user<br/>
        ///  experience if used from a browser or mobile client, but may be suitable for a<br/>
        ///  server-to-server connection. This option provides a simple way to connect your own server to<br/>
        ///  an Ultravox inference instance.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UltravoxV1CallMedium(
            object? webRtc,
            object? twilio,
            global::Ultravox.UltravoxV1CallMediumWebSocketMedium? serverWebSocket)
        {
            this.WebRtc = webRtc;
            this.Twilio = twilio;
            this.ServerWebSocket = serverWebSocket;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallMedium" /> class.
        /// </summary>
        public UltravoxV1CallMedium()
        {
        }
    }
}