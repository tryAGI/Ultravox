
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// Whether certain data messages are enabled for a connection.
    /// </summary>
    public sealed partial class UltravoxV1EnabledDataMessages
    {
        /// <summary>
        /// Responds to a ping message. (Default: enabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pong")]
        public bool? Pong { get; set; }

        /// <summary>
        /// Indicates that the agent state has changed. (Default: enabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public bool? State { get; set; }

        /// <summary>
        /// Provides transcripts of the user and agent speech. (Default: enabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public bool? Transcript { get; set; }

        /// <summary>
        /// Requests a client-implemented tool invocation. (Default: enabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientToolInvocation")]
        public bool? ClientToolInvocation { get; set; }

        /// <summary>
        /// Requests a data-connection-implemented tool invocation. (Default: enabled for data connections, disabled otherwise)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataConnectionToolInvocation")]
        public bool? DataConnectionToolInvocation { get; set; }

        /// <summary>
        /// Requests the client-side audio buffer to be cleared. (Default: enabled for websocket connections, disabled otherwise)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playbackClearBuffer")]
        public bool? PlaybackClearBuffer { get; set; }

        /// <summary>
        /// Provides information about the call when it starts. (Default: enabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callStarted")]
        public bool? CallStarted { get; set; }

        /// <summary>
        /// Communicates debug information. (Default: disabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debug")]
        public bool? Debug { get; set; }

        /// <summary>
        /// Indicates that a call event has been recorded. (Default: disabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callEvent")]
        public bool? CallEvent { get; set; }

        /// <summary>
        /// Indicates that a tool was used. (Default: disabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolUsed")]
        public bool? ToolUsed { get; set; }

        /// <summary>
        /// Indicates that the user has started speaking (according to simple VAD). (Default: disabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userStartedSpeaking")]
        public bool? UserStartedSpeaking { get; set; }

        /// <summary>
        /// Indicates that the user has stopped speaking (according to simple VAD). (Default: disabled)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userStoppedSpeaking")]
        public bool? UserStoppedSpeaking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1EnabledDataMessages" /> class.
        /// </summary>
        /// <param name="pong">
        /// Responds to a ping message. (Default: enabled)
        /// </param>
        /// <param name="state">
        /// Indicates that the agent state has changed. (Default: enabled)
        /// </param>
        /// <param name="transcript">
        /// Provides transcripts of the user and agent speech. (Default: enabled)
        /// </param>
        /// <param name="clientToolInvocation">
        /// Requests a client-implemented tool invocation. (Default: enabled)
        /// </param>
        /// <param name="dataConnectionToolInvocation">
        /// Requests a data-connection-implemented tool invocation. (Default: enabled for data connections, disabled otherwise)
        /// </param>
        /// <param name="playbackClearBuffer">
        /// Requests the client-side audio buffer to be cleared. (Default: enabled for websocket connections, disabled otherwise)
        /// </param>
        /// <param name="callStarted">
        /// Provides information about the call when it starts. (Default: enabled)
        /// </param>
        /// <param name="debug">
        /// Communicates debug information. (Default: disabled)
        /// </param>
        /// <param name="callEvent">
        /// Indicates that a call event has been recorded. (Default: disabled)
        /// </param>
        /// <param name="toolUsed">
        /// Indicates that a tool was used. (Default: disabled)
        /// </param>
        /// <param name="userStartedSpeaking">
        /// Indicates that the user has started speaking (according to simple VAD). (Default: disabled)
        /// </param>
        /// <param name="userStoppedSpeaking">
        /// Indicates that the user has stopped speaking (according to simple VAD). (Default: disabled)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1EnabledDataMessages(
            bool? pong,
            bool? state,
            bool? transcript,
            bool? clientToolInvocation,
            bool? dataConnectionToolInvocation,
            bool? playbackClearBuffer,
            bool? callStarted,
            bool? debug,
            bool? callEvent,
            bool? toolUsed,
            bool? userStartedSpeaking,
            bool? userStoppedSpeaking)
        {
            this.Pong = pong;
            this.State = state;
            this.Transcript = transcript;
            this.ClientToolInvocation = clientToolInvocation;
            this.DataConnectionToolInvocation = dataConnectionToolInvocation;
            this.PlaybackClearBuffer = playbackClearBuffer;
            this.CallStarted = callStarted;
            this.Debug = debug;
            this.CallEvent = callEvent;
            this.ToolUsed = toolUsed;
            this.UserStartedSpeaking = userStartedSpeaking;
            this.UserStoppedSpeaking = userStoppedSpeaking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1EnabledDataMessages" /> class.
        /// </summary>
        public UltravoxV1EnabledDataMessages()
        {
        }
    }
}