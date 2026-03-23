
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
        CallStarted,
        /// <summary>
        /// 
        /// </summary>
        ClientToolInvocation,
        /// <summary>
        /// 
        /// </summary>
        Debug,
        /// <summary>
        /// 
        /// </summary>
        PlaybackClearBuffer,
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
                ServerEventDiscriminatorType.CallStarted => "call_started",
                ServerEventDiscriminatorType.ClientToolInvocation => "client_tool_invocation",
                ServerEventDiscriminatorType.Debug => "debug",
                ServerEventDiscriminatorType.PlaybackClearBuffer => "playback_clear_buffer",
                ServerEventDiscriminatorType.Pong => "pong",
                ServerEventDiscriminatorType.State => "state",
                ServerEventDiscriminatorType.Transcript => "transcript",
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
                "call_started" => ServerEventDiscriminatorType.CallStarted,
                "client_tool_invocation" => ServerEventDiscriminatorType.ClientToolInvocation,
                "debug" => ServerEventDiscriminatorType.Debug,
                "playback_clear_buffer" => ServerEventDiscriminatorType.PlaybackClearBuffer,
                "pong" => ServerEventDiscriminatorType.Pong,
                "state" => ServerEventDiscriminatorType.State,
                "transcript" => ServerEventDiscriminatorType.Transcript,
                _ => null,
            };
        }
    }
}