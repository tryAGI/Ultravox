
#nullable enable

namespace Ultravox
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.AdmissionPreferenceEnum), TypeInfoPropertyName = "AdmissionPreferenceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.AgentBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OwnershipEnum), TypeInfoPropertyName = "OwnershipEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.BillingStatusEnum), TypeInfoPropertyName = "BillingStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Call))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OneOf<global::Ultravox.EndReasonEnum?, global::Ultravox.NullEnum?>), TypeInfoPropertyName = "OneOfEndReasonEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.EndReasonEnum), TypeInfoPropertyName = "EndReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.NullEnum), TypeInfoPropertyName = "NullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.FirstSpeakerEnum), TypeInfoPropertyName = "FirstSpeakerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1FirstSpeakerSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TimedMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1TimedMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.InitialOutputMediumEnum), TypeInfoPropertyName = "InitialOutputMediumEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.CallMediumRestriction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.CallMediumRestrictionAllowedMedium>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.CallMediumRestrictionAllowedMedium), TypeInfoPropertyName = "CallMediumRestrictionAllowedMedium2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1TranscriptionSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OneOf<global::Ultravox.RetentionPolicyEnum?, global::Ultravox.NullEnum?>), TypeInfoPropertyName = "OneOfRetentionPolicyEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.RetentionPolicyEnum), TypeInfoPropertyName = "RetentionPolicyEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OneOf<global::Ultravox.AdmissionPreferenceEnum?, global::Ultravox.NullEnum?>), TypeInfoPropertyName = "OneOfAdmissionPreferenceEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1ExternalVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1VadSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1DataConnectionConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1Callbacks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.CallSipDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1BackgroundAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OneOf<global::Ultravox.TerminationReasonEnum?, global::Ultravox.NullEnum?>), TypeInfoPropertyName = "OneOfTerminationReasonEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.TerminationReasonEnum), TypeInfoPropertyName = "TerminationReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedToolHistoryList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.ToolHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.ToolHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.PaginatedToolList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1BaseToolDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.GoogleProtobufValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1AutomaticParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1AutomaticParameterLocation), TypeInfoPropertyName = "UltravoxV1AutomaticParameterLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1AutomaticParameterKnownValue), TypeInfoPropertyName = "UltravoxV1AutomaticParameterKnownValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1BaseClientToolDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1BaseDataConnectionToolDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1BaseHttpToolDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1DynamicParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1DynamicParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1StaticParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1StaticParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AutomaticParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1ToolRequirements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction), TypeInfoPropertyName = "UltravoxV1BaseToolDefinitionDefaultReaction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1StaticToolResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumWebRtcMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumTwilioMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumWebSocketMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumTelnyxMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumPlivoMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumExotelMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumSipMedium))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumDtmfHandling))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessageUrgency), TypeInfoPropertyName = "UltravoxV1CallMediumDtmfUserTextMessageUrgency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1PlivoMediumOutgoingRequestParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1SipMediumSipIncoming))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1SipMediumSipOutgoing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1TelnyxMediumOutgoingRequestParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1TwilioMediumOutgoingRequestParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1EnabledDataMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1Callback))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CartesiaVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CartesiaVoiceCartesiaGenerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1DataConnectionAudioConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode), TypeInfoPropertyName = "UltravoxV1DataConnectionAudioConfigChannelMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1DynamicParameterLocation), TypeInfoPropertyName = "UltravoxV1DynamicParameterLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1ElevenLabsVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1LmntVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1GoogleVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1InworldVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1RespeecherVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1GenericVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1FallbackAgentGreeting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1FirstSpeakerSettingsUserGreeting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1FirstSpeakerSettingsAgentGreeting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding), TypeInfoPropertyName = "UltravoxV1GenericVoiceJsonByteEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1HeaderApiKeyRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1HttpAuthRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1InworldVoiceDeliveryMode), TypeInfoPropertyName = "UltravoxV1InworldVoiceDeliveryMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1QueryApiKeyRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1SecurityOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SecurityRequirements>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1SecurityRequirements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1SecurityRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Ultravox.UltravoxV1SecurityRequirement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1UltravoxCallTokenRequirement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1StaticParameterLocation), TypeInfoPropertyName = "UltravoxV1StaticParameterLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1TimedMessageEndBehavior), TypeInfoPropertyName = "UltravoxV1TimedMessageEndBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.ToolsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.ToolsTestCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.ToolsListOwnership), TypeInfoPropertyName = "ToolsListOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.ToolsListSortOrder), TypeInfoPropertyName = "ToolsListSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.AdmissionPreferenceEnum?), TypeInfoPropertyName = "NullableAdmissionPreferenceEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OwnershipEnum?), TypeInfoPropertyName = "NullableOwnershipEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.BillingStatusEnum?), TypeInfoPropertyName = "NullableBillingStatusEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OneOf<global::Ultravox.EndReasonEnum?, global::Ultravox.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfEndReasonEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.EndReasonEnum?), TypeInfoPropertyName = "NullableEndReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.NullEnum?), TypeInfoPropertyName = "NullableNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.FirstSpeakerEnum?), TypeInfoPropertyName = "NullableFirstSpeakerEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.InitialOutputMediumEnum?), TypeInfoPropertyName = "NullableInitialOutputMediumEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.CallMediumRestrictionAllowedMedium?), TypeInfoPropertyName = "NullableCallMediumRestrictionAllowedMedium2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OneOf<global::Ultravox.RetentionPolicyEnum?, global::Ultravox.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfRetentionPolicyEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.RetentionPolicyEnum?), TypeInfoPropertyName = "NullableRetentionPolicyEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OneOf<global::Ultravox.AdmissionPreferenceEnum?, global::Ultravox.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfAdmissionPreferenceEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.OneOf<global::Ultravox.TerminationReasonEnum?, global::Ultravox.NullEnum?>?), TypeInfoPropertyName = "NullableOneOfTerminationReasonEnumNullEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.TerminationReasonEnum?), TypeInfoPropertyName = "NullableTerminationReasonEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1AutomaticParameterLocation?), TypeInfoPropertyName = "NullableUltravoxV1AutomaticParameterLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1AutomaticParameterKnownValue?), TypeInfoPropertyName = "NullableUltravoxV1AutomaticParameterKnownValue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction?), TypeInfoPropertyName = "NullableUltravoxV1BaseToolDefinitionDefaultReaction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessageUrgency?), TypeInfoPropertyName = "NullableUltravoxV1CallMediumDtmfUserTextMessageUrgency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode?), TypeInfoPropertyName = "NullableUltravoxV1DataConnectionAudioConfigChannelMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1DynamicParameterLocation?), TypeInfoPropertyName = "NullableUltravoxV1DynamicParameterLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding?), TypeInfoPropertyName = "NullableUltravoxV1GenericVoiceJsonByteEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1InworldVoiceDeliveryMode?), TypeInfoPropertyName = "NullableUltravoxV1InworldVoiceDeliveryMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1StaticParameterLocation?), TypeInfoPropertyName = "NullableUltravoxV1StaticParameterLocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.UltravoxV1TimedMessageEndBehavior?), TypeInfoPropertyName = "NullableUltravoxV1TimedMessageEndBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.ToolsListOwnership?), TypeInfoPropertyName = "NullableToolsListOwnership2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Ultravox.ToolsListSortOrder?), TypeInfoPropertyName = "NullableToolsListSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1TimedMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.CallMediumRestrictionAllowedMedium>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.ToolHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1DynamicParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1StaticParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1AutomaticParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Ultravox.UltravoxV1SecurityRequirements>))]
    internal sealed partial class ToolsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ToolsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ToolsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Ultravox.JsonConverters.OneOfJsonConverter<global::Ultravox.EndReasonEnum?, global::Ultravox.NullEnum?>());
            options.Converters.Add(new global::Ultravox.JsonConverters.OneOfJsonConverter<global::Ultravox.RetentionPolicyEnum?, global::Ultravox.NullEnum?>());
            options.Converters.Add(new global::Ultravox.JsonConverters.OneOfJsonConverter<global::Ultravox.AdmissionPreferenceEnum?, global::Ultravox.NullEnum?>());
            options.Converters.Add(new global::Ultravox.JsonConverters.OneOfJsonConverter<global::Ultravox.TerminationReasonEnum?, global::Ultravox.NullEnum?>());
            options.Converters.Add(new global::Ultravox.JsonConverters.OneOfJsonConverter<global::Ultravox.EndReasonEnum?, global::Ultravox.NullEnum?>());
            options.Converters.Add(new global::Ultravox.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Ultravox.AdmissionPreferenceEnum)

                    || typeToConvert == typeof(global::Ultravox.AdmissionPreferenceEnum?)

                    || typeToConvert == typeof(global::Ultravox.BillingStatusEnum)

                    || typeToConvert == typeof(global::Ultravox.BillingStatusEnum?)

                    || typeToConvert == typeof(global::Ultravox.CallMediumRestrictionAllowedMedium)

                    || typeToConvert == typeof(global::Ultravox.CallMediumRestrictionAllowedMedium?)

                    || typeToConvert == typeof(global::Ultravox.EndReasonEnum)

                    || typeToConvert == typeof(global::Ultravox.EndReasonEnum?)

                    || typeToConvert == typeof(global::Ultravox.FirstSpeakerEnum)

                    || typeToConvert == typeof(global::Ultravox.FirstSpeakerEnum?)

                    || typeToConvert == typeof(global::Ultravox.InitialOutputMediumEnum)

                    || typeToConvert == typeof(global::Ultravox.InitialOutputMediumEnum?)

                    || typeToConvert == typeof(global::Ultravox.NullEnum)

                    || typeToConvert == typeof(global::Ultravox.NullEnum?)

                    || typeToConvert == typeof(global::Ultravox.OwnershipEnum)

                    || typeToConvert == typeof(global::Ultravox.OwnershipEnum?)

                    || typeToConvert == typeof(global::Ultravox.RetentionPolicyEnum)

                    || typeToConvert == typeof(global::Ultravox.RetentionPolicyEnum?)

                    || typeToConvert == typeof(global::Ultravox.TerminationReasonEnum)

                    || typeToConvert == typeof(global::Ultravox.TerminationReasonEnum?)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1AutomaticParameterLocation)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1AutomaticParameterLocation?)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1AutomaticParameterKnownValue)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1AutomaticParameterKnownValue?)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction?)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessageUrgency)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessageUrgency?)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode?)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1DynamicParameterLocation)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1DynamicParameterLocation?)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding?)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1InworldVoiceDeliveryMode)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1InworldVoiceDeliveryMode?)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1StaticParameterLocation)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1StaticParameterLocation?)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1TimedMessageEndBehavior)

                    || typeToConvert == typeof(global::Ultravox.UltravoxV1TimedMessageEndBehavior?)

                    || typeToConvert == typeof(global::Ultravox.ToolsListOwnership)

                    || typeToConvert == typeof(global::Ultravox.ToolsListOwnership?)

                    || typeToConvert == typeof(global::Ultravox.ToolsListSortOrder)

                    || typeToConvert == typeof(global::Ultravox.ToolsListSortOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Ultravox.AdmissionPreferenceEnum))
                {
                    return new global::Ultravox.JsonConverters.AdmissionPreferenceEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.AdmissionPreferenceEnum?))
                {
                    return new global::Ultravox.JsonConverters.AdmissionPreferenceEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.BillingStatusEnum))
                {
                    return new global::Ultravox.JsonConverters.BillingStatusEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.BillingStatusEnum?))
                {
                    return new global::Ultravox.JsonConverters.BillingStatusEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.CallMediumRestrictionAllowedMedium))
                {
                    return new global::Ultravox.JsonConverters.CallMediumRestrictionAllowedMediumJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.CallMediumRestrictionAllowedMedium?))
                {
                    return new global::Ultravox.JsonConverters.CallMediumRestrictionAllowedMediumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.EndReasonEnum))
                {
                    return new global::Ultravox.JsonConverters.EndReasonEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.EndReasonEnum?))
                {
                    return new global::Ultravox.JsonConverters.EndReasonEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.FirstSpeakerEnum))
                {
                    return new global::Ultravox.JsonConverters.FirstSpeakerEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.FirstSpeakerEnum?))
                {
                    return new global::Ultravox.JsonConverters.FirstSpeakerEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.InitialOutputMediumEnum))
                {
                    return new global::Ultravox.JsonConverters.InitialOutputMediumEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.InitialOutputMediumEnum?))
                {
                    return new global::Ultravox.JsonConverters.InitialOutputMediumEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.NullEnum))
                {
                    return new global::Ultravox.JsonConverters.NullEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.NullEnum?))
                {
                    return new global::Ultravox.JsonConverters.NullEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.OwnershipEnum))
                {
                    return new global::Ultravox.JsonConverters.OwnershipEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.OwnershipEnum?))
                {
                    return new global::Ultravox.JsonConverters.OwnershipEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.RetentionPolicyEnum))
                {
                    return new global::Ultravox.JsonConverters.RetentionPolicyEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.RetentionPolicyEnum?))
                {
                    return new global::Ultravox.JsonConverters.RetentionPolicyEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.TerminationReasonEnum))
                {
                    return new global::Ultravox.JsonConverters.TerminationReasonEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.TerminationReasonEnum?))
                {
                    return new global::Ultravox.JsonConverters.TerminationReasonEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1AutomaticParameterLocation))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1AutomaticParameterLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1AutomaticParameterLocation?))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1AutomaticParameterLocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1AutomaticParameterKnownValue))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1AutomaticParameterKnownValueJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1AutomaticParameterKnownValue?))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1AutomaticParameterKnownValueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1BaseToolDefinitionDefaultReactionJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction?))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1BaseToolDefinitionDefaultReactionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessageUrgency))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1CallMediumDtmfUserTextMessageUrgencyJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessageUrgency?))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1CallMediumDtmfUserTextMessageUrgencyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1DataConnectionAudioConfigChannelModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode?))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1DataConnectionAudioConfigChannelModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1DynamicParameterLocation))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1DynamicParameterLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1DynamicParameterLocation?))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1DynamicParameterLocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1GenericVoiceJsonByteEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding?))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1GenericVoiceJsonByteEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1InworldVoiceDeliveryMode))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1InworldVoiceDeliveryModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1InworldVoiceDeliveryMode?))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1InworldVoiceDeliveryModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1StaticParameterLocation))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1StaticParameterLocationJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1StaticParameterLocation?))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1StaticParameterLocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1TimedMessageEndBehavior))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1TimedMessageEndBehaviorJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.UltravoxV1TimedMessageEndBehavior?))
                {
                    return new global::Ultravox.JsonConverters.UltravoxV1TimedMessageEndBehaviorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.ToolsListOwnership))
                {
                    return new global::Ultravox.JsonConverters.ToolsListOwnershipJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.ToolsListOwnership?))
                {
                    return new global::Ultravox.JsonConverters.ToolsListOwnershipNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.ToolsListSortOrder))
                {
                    return new global::Ultravox.JsonConverters.ToolsListSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Ultravox.ToolsListSortOrder?))
                {
                    return new global::Ultravox.JsonConverters.ToolsListSortOrderNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ToolsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}