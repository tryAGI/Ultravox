#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Ultravox.Realtime.JsonConverters
{
    /// <inheritdoc />
    public class ServerEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Ultravox.Realtime.ServerEvent>
    {
        /// <inheritdoc />
        public override global::Ultravox.Realtime.ServerEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ultravox.Realtime.ServerEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ultravox.Realtime.ServerEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ultravox.Realtime.ServerEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Ultravox.Realtime.PongPayload? pong = default;
            if (discriminator?.Type == global::Ultravox.Realtime.ServerEventDiscriminatorType.Pong)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ultravox.Realtime.PongPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ultravox.Realtime.PongPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ultravox.Realtime.PongPayload)}");
                pong = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ultravox.Realtime.StatePayload? state = default;
            if (discriminator?.Type == global::Ultravox.Realtime.ServerEventDiscriminatorType.State)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ultravox.Realtime.StatePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ultravox.Realtime.StatePayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ultravox.Realtime.StatePayload)}");
                state = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ultravox.Realtime.TranscriptPayload? transcript = default;
            if (discriminator?.Type == global::Ultravox.Realtime.ServerEventDiscriminatorType.Transcript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ultravox.Realtime.TranscriptPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ultravox.Realtime.TranscriptPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ultravox.Realtime.TranscriptPayload)}");
                transcript = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ultravox.Realtime.ClientToolInvocationPayload? clientToolInvocation = default;
            if (discriminator?.Type == global::Ultravox.Realtime.ServerEventDiscriminatorType.ClientToolInvocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ultravox.Realtime.ClientToolInvocationPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ultravox.Realtime.ClientToolInvocationPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ultravox.Realtime.ClientToolInvocationPayload)}");
                clientToolInvocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ultravox.Realtime.PlaybackClearBufferPayload? playbackClearBuffer = default;
            if (discriminator?.Type == global::Ultravox.Realtime.ServerEventDiscriminatorType.PlaybackClearBuffer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ultravox.Realtime.PlaybackClearBufferPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ultravox.Realtime.PlaybackClearBufferPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ultravox.Realtime.PlaybackClearBufferPayload)}");
                playbackClearBuffer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ultravox.Realtime.CallStartedPayload? callStarted = default;
            if (discriminator?.Type == global::Ultravox.Realtime.ServerEventDiscriminatorType.CallStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ultravox.Realtime.CallStartedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ultravox.Realtime.CallStartedPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ultravox.Realtime.CallStartedPayload)}");
                callStarted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Ultravox.Realtime.DebugPayload? debug = default;
            if (discriminator?.Type == global::Ultravox.Realtime.ServerEventDiscriminatorType.Debug)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ultravox.Realtime.DebugPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ultravox.Realtime.DebugPayload> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Ultravox.Realtime.DebugPayload)}");
                debug = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Ultravox.Realtime.ServerEvent(
                discriminator?.Type,
                pong,

                state,

                transcript,

                clientToolInvocation,

                playbackClearBuffer,

                callStarted,

                debug
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Ultravox.Realtime.ServerEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPong)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ultravox.Realtime.PongPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ultravox.Realtime.PongPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ultravox.Realtime.PongPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pong, typeInfo);
            }
            else if (value.IsState)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ultravox.Realtime.StatePayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ultravox.Realtime.StatePayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ultravox.Realtime.StatePayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.State, typeInfo);
            }
            else if (value.IsTranscript)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ultravox.Realtime.TranscriptPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ultravox.Realtime.TranscriptPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ultravox.Realtime.TranscriptPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Transcript, typeInfo);
            }
            else if (value.IsClientToolInvocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ultravox.Realtime.ClientToolInvocationPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ultravox.Realtime.ClientToolInvocationPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ultravox.Realtime.ClientToolInvocationPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClientToolInvocation, typeInfo);
            }
            else if (value.IsPlaybackClearBuffer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ultravox.Realtime.PlaybackClearBufferPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ultravox.Realtime.PlaybackClearBufferPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ultravox.Realtime.PlaybackClearBufferPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlaybackClearBuffer, typeInfo);
            }
            else if (value.IsCallStarted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ultravox.Realtime.CallStartedPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ultravox.Realtime.CallStartedPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ultravox.Realtime.CallStartedPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CallStarted, typeInfo);
            }
            else if (value.IsDebug)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Ultravox.Realtime.DebugPayload), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Ultravox.Realtime.DebugPayload?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Ultravox.Realtime.DebugPayload).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Debug, typeInfo);
            }
        }
    }
}