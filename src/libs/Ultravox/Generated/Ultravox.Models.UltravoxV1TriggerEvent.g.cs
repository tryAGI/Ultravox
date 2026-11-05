
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// What causes a trigger to run.
    /// </summary>
    public sealed partial class UltravoxV1TriggerEvent
    {
        /// <summary>
        /// The type of a server data message, as in the message's "type" field (e.g.<br/>
        ///  "user_started_speaking", not "userStartedSpeaking"). Any message EnabledDataMessages<br/>
        ///  can enable may be used. The trigger runs each time the server produces a message of<br/>
        ///  this type, regardless of which messages clients receive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataMessage")]
        public string? DataMessage { get; set; }

        /// <summary>
        /// The name of a timer, which runs the trigger each time it fires. Timer names are 1-64<br/>
        ///  letters, digits, or underscores. Only one trigger may listen for each timer, but any<br/>
        ///  trigger can start or cancel it. The event's only property is "forwardedEvent": the<br/>
        ///  event of the trigger run that started the timer. If that run was itself for a timer,<br/>
        ///  it's that timer's forwardedEvent instead, so a timer that restarts itself keeps<br/>
        ///  forwarding the event that started the chain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timer")]
        public string? Timer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerEvent" /> class.
        /// </summary>
        /// <param name="dataMessage">
        /// The type of a server data message, as in the message's "type" field (e.g.<br/>
        ///  "user_started_speaking", not "userStartedSpeaking"). Any message EnabledDataMessages<br/>
        ///  can enable may be used. The trigger runs each time the server produces a message of<br/>
        ///  this type, regardless of which messages clients receive.
        /// </param>
        /// <param name="timer">
        /// The name of a timer, which runs the trigger each time it fires. Timer names are 1-64<br/>
        ///  letters, digits, or underscores. Only one trigger may listen for each timer, but any<br/>
        ///  trigger can start or cancel it. The event's only property is "forwardedEvent": the<br/>
        ///  event of the trigger run that started the timer. If that run was itself for a timer,<br/>
        ///  it's that timer's forwardedEvent instead, so a timer that restarts itself keeps<br/>
        ///  forwarding the event that started the chain.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1TriggerEvent(
            string? dataMessage,
            string? timer)
        {
            this.DataMessage = dataMessage;
            this.Timer = timer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1TriggerEvent" /> class.
        /// </summary>
        public UltravoxV1TriggerEvent()
        {
        }

    }
}