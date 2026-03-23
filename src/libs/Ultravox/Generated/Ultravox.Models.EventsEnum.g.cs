
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// * `call.started` - Fired when a call starts<br/>
    /// * `call.joined` - Fired when a call is joined<br/>
    /// * `call.ended` - Fired when a call ends<br/>
    /// * `call.billed` - Fired when a call is billed
    /// </summary>
    public enum EventsEnum
    {
        /// <summary>
        /// 
        /// </summary>
        CallBilled,
        /// <summary>
        /// 
        /// </summary>
        CallEnded,
        /// <summary>
        /// 
        /// </summary>
        CallJoined,
        /// <summary>
        /// 
        /// </summary>
        CallStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventsEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventsEnum value)
        {
            return value switch
            {
                EventsEnum.CallBilled => "call.billed",
                EventsEnum.CallEnded => "call.ended",
                EventsEnum.CallJoined => "call.joined",
                EventsEnum.CallStarted => "call.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventsEnum? ToEnum(string value)
        {
            return value switch
            {
                "call.billed" => EventsEnum.CallBilled,
                "call.ended" => EventsEnum.CallEnded,
                "call.joined" => EventsEnum.CallJoined,
                "call.started" => EventsEnum.CallStarted,
                _ => null,
            };
        }
    }
}