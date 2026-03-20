
#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Pong,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        Transcript,
        /// <summary>
        /// 
        /// </summary>
        ClientToolInvocation,
        /// <summary>
        /// 
        /// </summary>
        PlaybackClearBuffer,
        /// <summary>
        /// 
        /// </summary>
        CallStarted,
        /// <summary>
        /// 
        /// </summary>
        Debug,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerEventDiscriminatorType value)
        {
            return value switch
            {
                ServerEventDiscriminatorType.Pong => "pong",
                ServerEventDiscriminatorType.State => "state",
                ServerEventDiscriminatorType.Transcript => "transcript",
                ServerEventDiscriminatorType.ClientToolInvocation => "client_tool_invocation",
                ServerEventDiscriminatorType.PlaybackClearBuffer => "playback_clear_buffer",
                ServerEventDiscriminatorType.CallStarted => "call_started",
                ServerEventDiscriminatorType.Debug => "debug",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "pong" => ServerEventDiscriminatorType.Pong,
                "state" => ServerEventDiscriminatorType.State,
                "transcript" => ServerEventDiscriminatorType.Transcript,
                "client_tool_invocation" => ServerEventDiscriminatorType.ClientToolInvocation,
                "playback_clear_buffer" => ServerEventDiscriminatorType.PlaybackClearBuffer,
                "call_started" => ServerEventDiscriminatorType.CallStarted,
                "debug" => ServerEventDiscriminatorType.Debug,
                _ => null,
            };
        }
    }
}