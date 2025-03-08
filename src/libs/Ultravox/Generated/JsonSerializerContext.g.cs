
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Ultravox.JsonConverters.EndReasonEnumJsonConverter),
            typeof(global::Ultravox.JsonConverters.EndReasonEnumNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.NullEnumJsonConverter),
            typeof(global::Ultravox.JsonConverters.NullEnumNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.FirstSpeakerEnumJsonConverter),
            typeof(global::Ultravox.JsonConverters.FirstSpeakerEnumNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1TimedMessageEndBehaviorJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1TimedMessageEndBehaviorNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.InitialOutputMediumEnumJsonConverter),
            typeof(global::Ultravox.JsonConverters.InitialOutputMediumEnumNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1DynamicParameterLocationJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1DynamicParameterLocationNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1StaticParameterLocationJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1StaticParameterLocationNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1AutomaticParameterLocationJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1AutomaticParameterLocationNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1AutomaticParameterKnownValueJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1AutomaticParameterKnownValueNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.EventsEnumJsonConverter),
            typeof(global::Ultravox.JsonConverters.EventsEnumNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.OwnershipEnumJsonConverter),
            typeof(global::Ultravox.JsonConverters.OwnershipEnumNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1CorpusStatsStatusJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1CorpusStatsStatusNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1SourceStatsStatusJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1SourceStatsStatusNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1MessageRoleJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1MessageRoleNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1MessageMediumJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1MessageMediumNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1StartCallRequestFirstSpeakerJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1StartCallRequestFirstSpeakerNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1StartCallRequestInitialOutputMediumJsonConverter),
            typeof(global::Ultravox.JsonConverters.UltravoxV1StartCallRequestInitialOutputMediumNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.SchemaRetrieveFormatJsonConverter),
            typeof(global::Ultravox.JsonConverters.SchemaRetrieveFormatNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.SchemaRetrieveLangJsonConverter),
            typeof(global::Ultravox.JsonConverters.SchemaRetrieveLangNullableJsonConverter),
            typeof(global::Ultravox.JsonConverters.OneOfJsonConverter<global::Ultravox.EndReasonEnum?, global::Ultravox.NullEnum?>),
            typeof(global::Ultravox.JsonConverters.AllOfJsonConverter<global::Ultravox.UltravoxV1StartCallRequest, global::Ultravox.CallsCreateRequest2>),
            typeof(global::Ultravox.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}