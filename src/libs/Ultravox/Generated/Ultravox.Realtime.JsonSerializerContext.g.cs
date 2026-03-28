
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Ultravox.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Ultravox.Realtime.JsonConverters.PingPayloadTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.PingPayloadTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.UserTextMessagePayloadTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.UserTextMessagePayloadTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.UserTextMessagePayloadUrgencyJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.UserTextMessagePayloadUrgencyNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.SetOutputMediumPayloadTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.SetOutputMediumPayloadTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.SetOutputMediumPayloadMediumJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.SetOutputMediumPayloadMediumNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ClientToolResultPayloadTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ClientToolResultPayloadTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ClientToolResultPayloadResponseTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ClientToolResultPayloadResponseTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ClientToolResultPayloadAgentReactionJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ClientToolResultPayloadAgentReactionNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ClientToolResultPayloadErrorTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ClientToolResultPayloadErrorTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ForcedAgentMessagePayloadTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ForcedAgentMessagePayloadTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ForcedAgentMessagePayloadUrgencyJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ForcedAgentMessagePayloadUrgencyNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.HangUpPayloadTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.HangUpPayloadTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.PongPayloadTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.PongPayloadTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.StatePayloadTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.StatePayloadTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.StatePayloadStateJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.StatePayloadStateNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.TranscriptPayloadTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.TranscriptPayloadTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.TranscriptPayloadRoleJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.TranscriptPayloadRoleNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.TranscriptPayloadMediumJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.TranscriptPayloadMediumNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ClientToolInvocationPayloadTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ClientToolInvocationPayloadTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.PlaybackClearBufferPayloadTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.PlaybackClearBufferPayloadTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.CallStartedPayloadTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.CallStartedPayloadTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.DebugPayloadTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.DebugPayloadTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ServerEventDiscriminatorTypeJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ServerEventDiscriminatorTypeNullableJsonConverter),

            typeof(global::Ultravox.Realtime.JsonConverters.ServerEventJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.PingPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.PingPayloadType), TypeInfoPropertyName = "PingPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.UserTextMessagePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.UserTextMessagePayloadType), TypeInfoPropertyName = "UserTextMessagePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.UserTextMessagePayloadUrgency), TypeInfoPropertyName = "UserTextMessagePayloadUrgency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.SetOutputMediumPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.SetOutputMediumPayloadType), TypeInfoPropertyName = "SetOutputMediumPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.SetOutputMediumPayloadMedium), TypeInfoPropertyName = "SetOutputMediumPayloadMedium2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.ClientToolResultPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.ClientToolResultPayloadType), TypeInfoPropertyName = "ClientToolResultPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.ClientToolResultPayloadResponseType), TypeInfoPropertyName = "ClientToolResultPayloadResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.ClientToolResultPayloadAgentReaction), TypeInfoPropertyName = "ClientToolResultPayloadAgentReaction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.ClientToolResultPayloadErrorType), TypeInfoPropertyName = "ClientToolResultPayloadErrorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.ForcedAgentMessagePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.ForcedAgentMessagePayloadType), TypeInfoPropertyName = "ForcedAgentMessagePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.Realtime.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.ForcedAgentMessagePayloadUrgency), TypeInfoPropertyName = "ForcedAgentMessagePayloadUrgency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.HangUpPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.HangUpPayloadType), TypeInfoPropertyName = "HangUpPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.PongPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.PongPayloadType), TypeInfoPropertyName = "PongPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.StatePayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.StatePayloadType), TypeInfoPropertyName = "StatePayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.StatePayloadState), TypeInfoPropertyName = "StatePayloadState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.TranscriptPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.TranscriptPayloadType), TypeInfoPropertyName = "TranscriptPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.TranscriptPayloadRole), TypeInfoPropertyName = "TranscriptPayloadRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.TranscriptPayloadMedium), TypeInfoPropertyName = "TranscriptPayloadMedium2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.ClientToolInvocationPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.ClientToolInvocationPayloadType), TypeInfoPropertyName = "ClientToolInvocationPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.PlaybackClearBufferPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.PlaybackClearBufferPayloadType), TypeInfoPropertyName = "PlaybackClearBufferPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.CallStartedPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.CallStartedPayloadType), TypeInfoPropertyName = "CallStartedPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.DebugPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.DebugPayloadType), TypeInfoPropertyName = "DebugPayloadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.ServerEvent), TypeInfoPropertyName = "ServerEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.ServerEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Realtime.ServerEventDiscriminatorType), TypeInfoPropertyName = "ServerEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.Realtime.ToolCall>))]
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}