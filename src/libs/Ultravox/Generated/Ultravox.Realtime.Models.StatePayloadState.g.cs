
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// Current agent state.
    /// </summary>
    public enum StatePayloadState
    {
        /// <summary>
        /// 
        /// </summary>
        Idle,
        /// <summary>
        /// 
        /// </summary>
        Listening,
        /// <summary>
        /// 
        /// </summary>
        Speaking,
        /// <summary>
        /// 
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatePayloadStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatePayloadState value)
        {
            return value switch
            {
                StatePayloadState.Idle => "idle",
                StatePayloadState.Listening => "listening",
                StatePayloadState.Speaking => "speaking",
                StatePayloadState.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatePayloadState? ToEnum(string value)
        {
            return value switch
            {
                "idle" => StatePayloadState.Idle,
                "listening" => StatePayloadState.Listening,
                "speaking" => StatePayloadState.Speaking,
                "thinking" => StatePayloadState.Thinking,
                _ => null,
            };
        }
    }
}