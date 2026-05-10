#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Ultravox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Ultravox.Realtime.ServerEventDiscriminatorType? Type { get; }

        /// <summary>
        /// Pong response to a ping.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ultravox.Realtime.PongPayload? Pong { get; init; }
#else
        public global::Ultravox.Realtime.PongPayload? Pong { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pong))]
#endif
        public bool IsPong => Pong != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPong(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ultravox.Realtime.PongPayload? value)
        {
            value = Pong;
            return IsPong;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Ultravox.Realtime.PongPayload PickPong() => IsPong
            ? Pong!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Pong' but the value was {ToString()}.");

        /// <summary>
        /// Agent state change notification.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ultravox.Realtime.StatePayload? State { get; init; }
#else
        public global::Ultravox.Realtime.StatePayload? State { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(State))]
#endif
        public bool IsState => State != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickState(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ultravox.Realtime.StatePayload? value)
        {
            value = State;
            return IsState;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Ultravox.Realtime.StatePayload PickState() => IsState
            ? State!
            : throw new global::System.InvalidOperationException($"Expected union variant 'State' but the value was {ToString()}.");

        /// <summary>
        /// Speech transcript event.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ultravox.Realtime.TranscriptPayload? Transcript { get; init; }
#else
        public global::Ultravox.Realtime.TranscriptPayload? Transcript { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Transcript))]
#endif
        public bool IsTranscript => Transcript != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTranscript(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ultravox.Realtime.TranscriptPayload? value)
        {
            value = Transcript;
            return IsTranscript;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Ultravox.Realtime.TranscriptPayload PickTranscript() => IsTranscript
            ? Transcript!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Transcript' but the value was {ToString()}.");

        /// <summary>
        /// Server request to execute a client-side tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ultravox.Realtime.ClientToolInvocationPayload? ClientToolInvocation { get; init; }
#else
        public global::Ultravox.Realtime.ClientToolInvocationPayload? ClientToolInvocation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientToolInvocation))]
#endif
        public bool IsClientToolInvocation => ClientToolInvocation != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickClientToolInvocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ultravox.Realtime.ClientToolInvocationPayload? value)
        {
            value = ClientToolInvocation;
            return IsClientToolInvocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Ultravox.Realtime.ClientToolInvocationPayload PickClientToolInvocation() => IsClientToolInvocation
            ? ClientToolInvocation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientToolInvocation' but the value was {ToString()}.");

        /// <summary>
        /// Request to clear the audio playback buffer.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ultravox.Realtime.PlaybackClearBufferPayload? PlaybackClearBuffer { get; init; }
#else
        public global::Ultravox.Realtime.PlaybackClearBufferPayload? PlaybackClearBuffer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlaybackClearBuffer))]
#endif
        public bool IsPlaybackClearBuffer => PlaybackClearBuffer != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPlaybackClearBuffer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ultravox.Realtime.PlaybackClearBufferPayload? value)
        {
            value = PlaybackClearBuffer;
            return IsPlaybackClearBuffer;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Ultravox.Realtime.PlaybackClearBufferPayload PickPlaybackClearBuffer() => IsPlaybackClearBuffer
            ? PlaybackClearBuffer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PlaybackClearBuffer' but the value was {ToString()}.");

        /// <summary>
        /// Call started notification.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ultravox.Realtime.CallStartedPayload? CallStarted { get; init; }
#else
        public global::Ultravox.Realtime.CallStartedPayload? CallStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CallStarted))]
#endif
        public bool IsCallStarted => CallStarted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCallStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ultravox.Realtime.CallStartedPayload? value)
        {
            value = CallStarted;
            return IsCallStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Ultravox.Realtime.CallStartedPayload PickCallStarted() => IsCallStarted
            ? CallStarted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CallStarted' but the value was {ToString()}.");

        /// <summary>
        /// Debug information from the server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Ultravox.Realtime.DebugPayload? Debug { get; init; }
#else
        public global::Ultravox.Realtime.DebugPayload? Debug { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Debug))]
#endif
        public bool IsDebug => Debug != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDebug(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Ultravox.Realtime.DebugPayload? value)
        {
            value = Debug;
            return IsDebug;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Ultravox.Realtime.DebugPayload PickDebug() => IsDebug
            ? Debug!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Debug' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Ultravox.Realtime.PongPayload value) => new ServerEvent((global::Ultravox.Realtime.PongPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Ultravox.Realtime.PongPayload?(ServerEvent @this) => @this.Pong;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Ultravox.Realtime.PongPayload? value)
        {
            Pong = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromPong(global::Ultravox.Realtime.PongPayload? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Ultravox.Realtime.StatePayload value) => new ServerEvent((global::Ultravox.Realtime.StatePayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Ultravox.Realtime.StatePayload?(ServerEvent @this) => @this.State;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Ultravox.Realtime.StatePayload? value)
        {
            State = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromState(global::Ultravox.Realtime.StatePayload? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Ultravox.Realtime.TranscriptPayload value) => new ServerEvent((global::Ultravox.Realtime.TranscriptPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Ultravox.Realtime.TranscriptPayload?(ServerEvent @this) => @this.Transcript;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Ultravox.Realtime.TranscriptPayload? value)
        {
            Transcript = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromTranscript(global::Ultravox.Realtime.TranscriptPayload? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Ultravox.Realtime.ClientToolInvocationPayload value) => new ServerEvent((global::Ultravox.Realtime.ClientToolInvocationPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Ultravox.Realtime.ClientToolInvocationPayload?(ServerEvent @this) => @this.ClientToolInvocation;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Ultravox.Realtime.ClientToolInvocationPayload? value)
        {
            ClientToolInvocation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromClientToolInvocation(global::Ultravox.Realtime.ClientToolInvocationPayload? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Ultravox.Realtime.PlaybackClearBufferPayload value) => new ServerEvent((global::Ultravox.Realtime.PlaybackClearBufferPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Ultravox.Realtime.PlaybackClearBufferPayload?(ServerEvent @this) => @this.PlaybackClearBuffer;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Ultravox.Realtime.PlaybackClearBufferPayload? value)
        {
            PlaybackClearBuffer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromPlaybackClearBuffer(global::Ultravox.Realtime.PlaybackClearBufferPayload? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Ultravox.Realtime.CallStartedPayload value) => new ServerEvent((global::Ultravox.Realtime.CallStartedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Ultravox.Realtime.CallStartedPayload?(ServerEvent @this) => @this.CallStarted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Ultravox.Realtime.CallStartedPayload? value)
        {
            CallStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromCallStarted(global::Ultravox.Realtime.CallStartedPayload? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::Ultravox.Realtime.DebugPayload value) => new ServerEvent((global::Ultravox.Realtime.DebugPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Ultravox.Realtime.DebugPayload?(ServerEvent @this) => @this.Debug;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::Ultravox.Realtime.DebugPayload? value)
        {
            Debug = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromDebug(global::Ultravox.Realtime.DebugPayload? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(
            global::Ultravox.Realtime.ServerEventDiscriminatorType? type,
            global::Ultravox.Realtime.PongPayload? pong,
            global::Ultravox.Realtime.StatePayload? state,
            global::Ultravox.Realtime.TranscriptPayload? transcript,
            global::Ultravox.Realtime.ClientToolInvocationPayload? clientToolInvocation,
            global::Ultravox.Realtime.PlaybackClearBufferPayload? playbackClearBuffer,
            global::Ultravox.Realtime.CallStartedPayload? callStarted,
            global::Ultravox.Realtime.DebugPayload? debug
            )
        {
            Type = type;

            Pong = pong;
            State = state;
            Transcript = transcript;
            ClientToolInvocation = clientToolInvocation;
            PlaybackClearBuffer = playbackClearBuffer;
            CallStarted = callStarted;
            Debug = debug;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Debug as object ??
            CallStarted as object ??
            PlaybackClearBuffer as object ??
            ClientToolInvocation as object ??
            Transcript as object ??
            State as object ??
            Pong as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Pong?.ToString() ??
            State?.ToString() ??
            Transcript?.ToString() ??
            ClientToolInvocation?.ToString() ??
            PlaybackClearBuffer?.ToString() ??
            CallStarted?.ToString() ??
            Debug?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPong && !IsState && !IsTranscript && !IsClientToolInvocation && !IsPlaybackClearBuffer && !IsCallStarted && !IsDebug || !IsPong && IsState && !IsTranscript && !IsClientToolInvocation && !IsPlaybackClearBuffer && !IsCallStarted && !IsDebug || !IsPong && !IsState && IsTranscript && !IsClientToolInvocation && !IsPlaybackClearBuffer && !IsCallStarted && !IsDebug || !IsPong && !IsState && !IsTranscript && IsClientToolInvocation && !IsPlaybackClearBuffer && !IsCallStarted && !IsDebug || !IsPong && !IsState && !IsTranscript && !IsClientToolInvocation && IsPlaybackClearBuffer && !IsCallStarted && !IsDebug || !IsPong && !IsState && !IsTranscript && !IsClientToolInvocation && !IsPlaybackClearBuffer && IsCallStarted && !IsDebug || !IsPong && !IsState && !IsTranscript && !IsClientToolInvocation && !IsPlaybackClearBuffer && !IsCallStarted && IsDebug;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Ultravox.Realtime.PongPayload, TResult>? pong = null,
            global::System.Func<global::Ultravox.Realtime.StatePayload, TResult>? state = null,
            global::System.Func<global::Ultravox.Realtime.TranscriptPayload, TResult>? transcript = null,
            global::System.Func<global::Ultravox.Realtime.ClientToolInvocationPayload, TResult>? clientToolInvocation = null,
            global::System.Func<global::Ultravox.Realtime.PlaybackClearBufferPayload, TResult>? playbackClearBuffer = null,
            global::System.Func<global::Ultravox.Realtime.CallStartedPayload, TResult>? callStarted = null,
            global::System.Func<global::Ultravox.Realtime.DebugPayload, TResult>? debug = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPong && pong != null)
            {
                return pong(Pong!);
            }
            else if (IsState && state != null)
            {
                return state(State!);
            }
            else if (IsTranscript && transcript != null)
            {
                return transcript(Transcript!);
            }
            else if (IsClientToolInvocation && clientToolInvocation != null)
            {
                return clientToolInvocation(ClientToolInvocation!);
            }
            else if (IsPlaybackClearBuffer && playbackClearBuffer != null)
            {
                return playbackClearBuffer(PlaybackClearBuffer!);
            }
            else if (IsCallStarted && callStarted != null)
            {
                return callStarted(CallStarted!);
            }
            else if (IsDebug && debug != null)
            {
                return debug(Debug!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Ultravox.Realtime.PongPayload>? pong = null,

            global::System.Action<global::Ultravox.Realtime.StatePayload>? state = null,

            global::System.Action<global::Ultravox.Realtime.TranscriptPayload>? transcript = null,

            global::System.Action<global::Ultravox.Realtime.ClientToolInvocationPayload>? clientToolInvocation = null,

            global::System.Action<global::Ultravox.Realtime.PlaybackClearBufferPayload>? playbackClearBuffer = null,

            global::System.Action<global::Ultravox.Realtime.CallStartedPayload>? callStarted = null,

            global::System.Action<global::Ultravox.Realtime.DebugPayload>? debug = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPong)
            {
                pong?.Invoke(Pong!);
            }
            else if (IsState)
            {
                state?.Invoke(State!);
            }
            else if (IsTranscript)
            {
                transcript?.Invoke(Transcript!);
            }
            else if (IsClientToolInvocation)
            {
                clientToolInvocation?.Invoke(ClientToolInvocation!);
            }
            else if (IsPlaybackClearBuffer)
            {
                playbackClearBuffer?.Invoke(PlaybackClearBuffer!);
            }
            else if (IsCallStarted)
            {
                callStarted?.Invoke(CallStarted!);
            }
            else if (IsDebug)
            {
                debug?.Invoke(Debug!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Ultravox.Realtime.PongPayload>? pong = null,
            global::System.Action<global::Ultravox.Realtime.StatePayload>? state = null,
            global::System.Action<global::Ultravox.Realtime.TranscriptPayload>? transcript = null,
            global::System.Action<global::Ultravox.Realtime.ClientToolInvocationPayload>? clientToolInvocation = null,
            global::System.Action<global::Ultravox.Realtime.PlaybackClearBufferPayload>? playbackClearBuffer = null,
            global::System.Action<global::Ultravox.Realtime.CallStartedPayload>? callStarted = null,
            global::System.Action<global::Ultravox.Realtime.DebugPayload>? debug = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPong)
            {
                pong?.Invoke(Pong!);
            }
            else if (IsState)
            {
                state?.Invoke(State!);
            }
            else if (IsTranscript)
            {
                transcript?.Invoke(Transcript!);
            }
            else if (IsClientToolInvocation)
            {
                clientToolInvocation?.Invoke(ClientToolInvocation!);
            }
            else if (IsPlaybackClearBuffer)
            {
                playbackClearBuffer?.Invoke(PlaybackClearBuffer!);
            }
            else if (IsCallStarted)
            {
                callStarted?.Invoke(CallStarted!);
            }
            else if (IsDebug)
            {
                debug?.Invoke(Debug!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Pong,
                typeof(global::Ultravox.Realtime.PongPayload),
                State,
                typeof(global::Ultravox.Realtime.StatePayload),
                Transcript,
                typeof(global::Ultravox.Realtime.TranscriptPayload),
                ClientToolInvocation,
                typeof(global::Ultravox.Realtime.ClientToolInvocationPayload),
                PlaybackClearBuffer,
                typeof(global::Ultravox.Realtime.PlaybackClearBufferPayload),
                CallStarted,
                typeof(global::Ultravox.Realtime.CallStartedPayload),
                Debug,
                typeof(global::Ultravox.Realtime.DebugPayload),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Ultravox.Realtime.PongPayload?>.Default.Equals(Pong, other.Pong) &&
                global::System.Collections.Generic.EqualityComparer<global::Ultravox.Realtime.StatePayload?>.Default.Equals(State, other.State) &&
                global::System.Collections.Generic.EqualityComparer<global::Ultravox.Realtime.TranscriptPayload?>.Default.Equals(Transcript, other.Transcript) &&
                global::System.Collections.Generic.EqualityComparer<global::Ultravox.Realtime.ClientToolInvocationPayload?>.Default.Equals(ClientToolInvocation, other.ClientToolInvocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Ultravox.Realtime.PlaybackClearBufferPayload?>.Default.Equals(PlaybackClearBuffer, other.PlaybackClearBuffer) &&
                global::System.Collections.Generic.EqualityComparer<global::Ultravox.Realtime.CallStartedPayload?>.Default.Equals(CallStarted, other.CallStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Ultravox.Realtime.DebugPayload?>.Default.Equals(Debug, other.Debug) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ServerEvent obj1, ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ServerEvent obj1, ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerEvent o && Equals(o);
        }
    }
}
