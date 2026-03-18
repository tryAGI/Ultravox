
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
            typeof(global::Ultravox.JsonConverters.UltravoxV1CallMediumDtmfUserTextMessageUrgencyJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1CallMediumDtmfUserTextMessageUrgencyNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1CallTemplateInitialOutputMediumJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1CallTemplateInitialOutputMediumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1GenericVoiceJsonByteEncodingJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1GenericVoiceJsonByteEncodingNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1TimedMessageEndBehaviorJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1TimedMessageEndBehaviorNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1DynamicParameterLocationJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1DynamicParameterLocationNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1StaticParameterLocationJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1StaticParameterLocationNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1AutomaticParameterLocationJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1AutomaticParameterLocationNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1AutomaticParameterKnownValueJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1AutomaticParameterKnownValueNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1BaseToolDefinitionDefaultReactionJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1BaseToolDefinitionDefaultReactionNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1DataConnectionAudioConfigChannelModeJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1DataConnectionAudioConfigChannelModeNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1CallTemplateRetentionPolicyJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1CallTemplateRetentionPolicyNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.BillingReasonEnumJsonConverter),

            typeof(global::Ultravox.JsonConverters.BillingReasonEnumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.BillingStatusEnumJsonConverter),

            typeof(global::Ultravox.JsonConverters.BillingStatusEnumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.BillingStyleEnumJsonConverter),

            typeof(global::Ultravox.JsonConverters.BillingStyleEnumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.EndReasonEnumJsonConverter),

            typeof(global::Ultravox.JsonConverters.EndReasonEnumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.NullEnumJsonConverter),

            typeof(global::Ultravox.JsonConverters.NullEnumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.FirstSpeakerEnumJsonConverter),

            typeof(global::Ultravox.JsonConverters.FirstSpeakerEnumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.InitialOutputMediumEnumJsonConverter),

            typeof(global::Ultravox.JsonConverters.InitialOutputMediumEnumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.RetentionPolicyEnumJsonConverter),

            typeof(global::Ultravox.JsonConverters.RetentionPolicyEnumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.TerminationReasonEnumJsonConverter),

            typeof(global::Ultravox.JsonConverters.TerminationReasonEnumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.SeverityEnumJsonConverter),

            typeof(global::Ultravox.JsonConverters.SeverityEnumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1CallToolDefaultReactionJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1CallToolDefaultReactionNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.EventsEnumJsonConverter),

            typeof(global::Ultravox.JsonConverters.EventsEnumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.InvoiceStatusEnumJsonConverter),

            typeof(global::Ultravox.JsonConverters.InvoiceStatusEnumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.OwnershipEnumJsonConverter),

            typeof(global::Ultravox.JsonConverters.OwnershipEnumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.ScheduledCallStatusEnumJsonConverter),

            typeof(global::Ultravox.JsonConverters.ScheduledCallStatusEnumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.WebhookStatusEnumJsonConverter),

            typeof(global::Ultravox.JsonConverters.WebhookStatusEnumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1CorpusStatsStatusJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1CorpusStatsStatusNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1SourceStatsStatusJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1SourceStatsStatusNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1MessageRoleJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1MessageRoleNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1MessageMediumJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1MessageMediumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1StartAgentCallRequestInitialOutputMediumJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1StartAgentCallRequestInitialOutputMediumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1StartAgentCallRequestRetentionPolicyJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1StartAgentCallRequestRetentionPolicyNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1StartCallRequestFirstSpeakerJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1StartCallRequestFirstSpeakerNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1StartCallRequestInitialOutputMediumJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1StartCallRequestInitialOutputMediumNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1StartCallRequestRetentionPolicyJsonConverter),

            typeof(global::Ultravox.JsonConverters.UltravoxV1StartCallRequestRetentionPolicyNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.AgentsScheduledBatchesScheduledCallsListStatusJsonConverter),

            typeof(global::Ultravox.JsonConverters.AgentsScheduledBatchesScheduledCallsListStatusNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.CallsEventsListMinimumSeverityJsonConverter),

            typeof(global::Ultravox.JsonConverters.CallsEventsListMinimumSeverityNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.CallsMessagesListModeJsonConverter),

            typeof(global::Ultravox.JsonConverters.CallsMessagesListModeNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.SchemaRetrieveFormatJsonConverter),

            typeof(global::Ultravox.JsonConverters.SchemaRetrieveFormatNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.SchemaRetrieveLangJsonConverter),

            typeof(global::Ultravox.JsonConverters.SchemaRetrieveLangNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.ToolsListOwnershipJsonConverter),

            typeof(global::Ultravox.JsonConverters.ToolsListOwnershipNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.ToolsListSortOrderJsonConverter),

            typeof(global::Ultravox.JsonConverters.ToolsListSortOrderNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.VoicesListBillingStyleJsonConverter),

            typeof(global::Ultravox.JsonConverters.VoicesListBillingStyleNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.VoicesListOwnershipJsonConverter),

            typeof(global::Ultravox.JsonConverters.VoicesListOwnershipNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.VoicesListProviderItemJsonConverter),

            typeof(global::Ultravox.JsonConverters.VoicesListProviderItemNullableJsonConverter),

            typeof(global::Ultravox.JsonConverters.OneOfJsonConverter<global::Ultravox.EndReasonEnum?, global::Ultravox.NullEnum?>),

            typeof(global::Ultravox.JsonConverters.OneOfJsonConverter<global::Ultravox.RetentionPolicyEnum?, global::Ultravox.NullEnum?>),

            typeof(global::Ultravox.JsonConverters.OneOfJsonConverter<global::Ultravox.TerminationReasonEnum?, global::Ultravox.NullEnum?>),

            typeof(global::Ultravox.JsonConverters.OneOfJsonConverter<global::Ultravox.EndReasonEnum?, global::Ultravox.NullEnum?>),

            typeof(global::Ultravox.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.APIKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.APIKeyCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Account))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.AccountBillingInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.AccountTelephonyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.TwilioConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.KeyPrefix))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.TelnyxConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PlivoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.AccountTtsKeys))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Agent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumWebRtcMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1EnabledDataMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumTwilioMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1TwilioMediumOutgoingRequestParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumDtmfHandling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessageUrgency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumWebSocketMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumTelnyxMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1TelnyxMediumOutgoingRequestParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumPlivoMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1PlivoMediumOutgoingRequestParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumExotelMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumSipMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1SipMediumSipOutgoing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallTemplateInitialOutputMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1VadSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1FirstSpeakerSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1FirstSpeakerSettingsUserGreeting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1FallbackAgentGreeting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1FirstSpeakerSettingsAgentGreeting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1ExternalVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1ElevenLabsVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CartesiaVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CartesiaVoiceCartesiaGenerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1LmntVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1GoogleVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1InworldVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1RespeecherVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1GenericVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TimedMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1TimedMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1TimedMessageEndBehavior))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SelectedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1SelectedTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1BaseToolDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1DynamicParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1DynamicParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1DynamicParameterLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1StaticParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1StaticParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1StaticParameterLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AutomaticParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1AutomaticParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1AutomaticParameterLocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1AutomaticParameterKnownValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1ToolRequirements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1SecurityOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SecurityRequirements>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1SecurityRequirements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Ultravox.UltravoxV1SecurityRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1SecurityRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1UltravoxCallTokenRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1BaseHttpToolDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1StaticToolResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1DataConnectionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1DataConnectionAudioConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallTemplateRetentionPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.AgentStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.AgentAllowance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.AgentBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.AgentDailyUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.AgentUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.AgentDailyUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.BillingReasonEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.BillingStatusEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.BillingStyleEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.BillingUsageDay))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Call))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OneOf<global::Ultravox.EndReasonEnum?, global::Ultravox.NullEnum?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.EndReasonEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.NullEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.FirstSpeakerEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.InitialOutputMediumEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OneOf<global::Ultravox.RetentionPolicyEnum?, global::Ultravox.NullEnum?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.RetentionPolicyEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1Callbacks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1Callback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.CallSipDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OneOf<global::Ultravox.TerminationReasonEnum?, global::Ultravox.NullEnum?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.TerminationReasonEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.CallEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.SeverityEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.CallStage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.CallStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.CallTombstone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.CallTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1HttpCallToolDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallToolDefaultReaction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.CallUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.DailyCallStatistics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.DailyCallStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.HourlyCallStatistics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.HourlyCallStatistics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.CorpusUploadsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.CorpusUploadsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.EventsEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Invoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.InvoiceStatusEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.ModelAlias))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OwnershipEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedAPIKeyList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.APIKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedAgentList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedCallEventList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.CallEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedCallList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.Call>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedCallStageList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.CallStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedCallTombstoneList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.CallTombstone>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedInvoiceList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.Invoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedModelAliasList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.ModelAlias>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedScheduledCallBatchList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.ScheduledCallBatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.ScheduledCallBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.ScheduledCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.ScheduledCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.ScheduledCallStatusEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedScheduledCallList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedSipRegistrationList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.SipRegistration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.SipRegistration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedToolHistoryList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.ToolHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.ToolHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedToolList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1QueryApiKeyRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1HeaderApiKeyRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1HttpAuthRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedVoiceList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Voice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedWebhookList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.Webhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Webhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.EventsEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.WebhookStatusEnum))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.WebhookFailure>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.WebhookFailure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedultravoxV1CorpusDocumentList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CorpusDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CorpusDocumentMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedultravoxV1CorpusList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Corpus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1Corpus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CorpusStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CorpusStatsStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedultravoxV1CorpusSourceList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CorpusSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1SourceStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1SourceStatsStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CrawlSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1MimeTypeFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1MimeTypeSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1UploadSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1AdvancedSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedultravoxV1MessageList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1MessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1MessageMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1InCallTimespan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PatchedAPIKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PatchedAccountTelephonyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PatchedAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PatchedPlivoConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PatchedScheduledCallBatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PatchedSetTtsApiKeysRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PatchedSipConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.AgentAllowance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PatchedSipRegistration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PatchedTelnyxConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PatchedTwilioConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PatchedVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PatchedWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.SendCallDataMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.SipConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.BillingUsageDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CorpusQueryResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CorpusQueryResultCitation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1QueryCorpusRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1StartAgentCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1StartAgentCallRequestInitialOutputMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1ToolOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1StartAgentCallRequestRetentionPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1StartCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1StartCallRequestFirstSpeaker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1StartCallRequestInitialOutputMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1StartCallRequestRetentionPolicy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.ToolsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.VoicesCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.AgentsScheduledBatchesScheduledCallsListStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.CallsEventsListMinimumSeverity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.CallsMessagesListMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.SchemaRetrieveFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.SchemaRetrieveLang))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.ToolsListOwnership))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.ToolsListSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.VoicesListBillingStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.VoicesListOwnership))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.VoicesListProviderItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.VoicesListProviderItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.Account>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.AgentUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.CallTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusQueryResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1TimedMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1SelectedTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1DynamicParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1StaticParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1AutomaticParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1SecurityRequirements>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.AgentDailyUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.DailyCallStatistics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.HourlyCallStatistics>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.APIKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.CallEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.Call>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.CallStage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.CallTombstone>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.Invoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.ModelAlias>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.ScheduledCallBatch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.ScheduledCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.SipRegistration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.ToolHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.Voice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.Webhook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.EventsEnum>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.WebhookFailure>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1CorpusDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1Corpus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1CorpusSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.AgentAllowance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.BillingUsageDay>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.VoicesListProviderItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.Account>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.AgentUsage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.CallTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1CorpusQueryResult>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}