
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Ultravox
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.APIKey? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.APIKeyCreate? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Account? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Guid? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AccountBillingInfo? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AccountTelephonyConfig? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.TwilioConfig? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.TelnyxConfig? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PlivoConfig? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AccountTtsKeys? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.KeyPrefix? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Agent? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplate? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AgentStatistics? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AgentAllowance? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AgentBasic? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AgentDailyUsage? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AgentUsage? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AgentDailyUsage>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AudioClip? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.OwnershipEnum? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.BillingReasonEnum? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.BillingStatusEnum? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.BillingStyleEnum? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.BillingUsageDay? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Call? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.OneOf<global::Ultravox.EndReasonEnum?, global::Ultravox.NullEnum?>? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.EndReasonEnum? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.NullEnum? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.FirstSpeakerEnum? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FirstSpeakerSettings? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TimedMessage>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TimedMessage? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.InitialOutputMediumEnum? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMedium? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.OneOf<global::Ultravox.RetentionPolicyEnum?, global::Ultravox.NullEnum?>? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.RetentionPolicyEnum? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ExternalVoice? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1VadSettings? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionConfig? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Callbacks? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallSipDetails? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BackgroundAudio? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallEvent? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SeverityEnum? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.OneOf<global::Ultravox.TerminationReasonEnum?, global::Ultravox.NullEnum?>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.TerminationReasonEnum? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallStage? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallStatistics? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallThrottle? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallThrottleRule>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallThrottleRule? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallTombstone? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallTool? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTool? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallUsage? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.DailyCallStatistics>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.DailyCallStatistics? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.HourlyCallStatistics>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.HourlyCallStatistics? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ConcurrencyBucket? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ConcurrencyResponse? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ConcurrencyBucket>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CorpusUploadsRequest? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CorpusUploadsResponse? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.EventsEnum? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.FallbackHandler? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Invoice? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.InvoiceStatusEnum? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ModelAlias? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedAPIKeyList? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.APIKey>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedAgentList? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Agent>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedAudioClipList? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AudioClip>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallEventList? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallEvent>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallList? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Call>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallStageList? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallStage>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallThrottleList? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallThrottle>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallTombstoneList? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallTombstone>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedInvoiceList? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Invoice>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedModelAliasList? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ModelAlias>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedScheduledCallBatchList? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ScheduledCallBatch>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ScheduledCallBatch? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedScheduledCallList? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ScheduledCall>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ScheduledCall? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedSipRegistrationList? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.SipRegistration>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SipRegistration? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedToolHistoryList? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ToolHistory>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolHistory? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedToolList? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Tool>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Tool? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedVoiceList? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Voice>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Voice? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedWebhookList? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Webhook>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Webhook? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1CorpusDocumentList? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusDocument>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusDocument? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1CorpusList? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Corpus>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Corpus? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1CorpusSourceList? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusSource>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusSource? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1MessageList? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Message>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Message? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAPIKey? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAccountTelephonyConfig? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAgent? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAudioClip? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedCallThrottle? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedPlivoConfig? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedScheduledCallBatch? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedSetTtsApiKeysRequest? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedSipConfig? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AgentAllowance>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedSipRegistration? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedTelnyxConfig? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedTwilioConfig? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedVoice? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedWebhook? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.EventsEnum>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.WebhookStatusEnum? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.WebhookFailure>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.WebhookFailure? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ScheduledCallStatusEnum? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SendCallDataMessage? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SipConfig? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseToolDefinition? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UsageResponse? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.BillingUsageDay>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplateInitialOutputMedium? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SelectedTool>? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SelectedTool? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplateRetentionPolicy? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusStats? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusDocumentMetadata? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusQueryResult? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusQueryResultCitation? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SourceStats? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CrawlSpec? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1UploadSpec? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AdvancedSpec? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MessageRole? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MessageMedium? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1InCallTimespan? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.GoogleProtobufValue? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AutomaticParameter? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AutomaticParameterLocation? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AutomaticParameterKnownValue? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseClientToolDetails? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseDataConnectionToolDetails? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseHttpToolDetails? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1DynamicParameter>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DynamicParameter? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1StaticParameter>? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StaticParameter? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AutomaticParameter>? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ToolRequirements? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StaticToolResponse? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumWebRtcMedium? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumTwilioMedium? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumWebSocketMedium? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumTelnyxMedium? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumPlivoMedium? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumExotelMedium? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumSipMedium? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumDtmfHandling? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessage? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessageUrgency? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1PlivoMediumOutgoingRequestParams? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipMediumSipIncoming? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipMediumSipOutgoing? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TelnyxMediumOutgoingRequestParams? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TwilioMediumOutgoingRequestParams? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1EnabledDataMessages? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1HttpCallToolDetails? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ClientCallToolDetails? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionCallToolDetails? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallToolDefaultReaction? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Callback? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CartesiaVoice? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CartesiaVoiceCartesiaGenerationConfig? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusStatsStatus? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MimeTypeFilter? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionAudioConfig? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DynamicParameterLocation? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ElevenLabsVoice? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1LmntVoice? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1GoogleVoice? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1InworldVoice? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1RespeecherVoice? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1GenericVoice? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FallbackAgentGreeting? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FirstSpeakerSettingsUserGreeting? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FirstSpeakerSettingsAgentGreeting? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1HeaderApiKeyRequirement? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1HttpAuthRequirement? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1InworldVoiceDeliveryMode? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MimeTypeSet? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1QueryApiKeyRequirement? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1QueryCorpusRequest? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SecurityOptions? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SecurityRequirements>? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SecurityRequirements? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SecurityRequirement? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Ultravox.UltravoxV1SecurityRequirement>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1UltravoxCallTokenRequirement? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipFallbackHandlerResponse? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequest? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequest? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipRejection? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SourceStatsStatus? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequestInitialOutputMedium? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ToolOverrides? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequestRetentionPolicy? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestFirstSpeaker? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestInitialOutputMedium? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestRetentionPolicy? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StaticParameterLocation? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TimedMessageEndBehavior? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AudioClipsCreateRequest? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsCreateRequest? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsTestCreateRequest? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesCreateRequest? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AccountsMeUsageConcurrencyRetrieveBucket? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AgentsScheduledBatchesScheduledCallsListStatus? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallsEventsListMinimumSeverity? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallsMessagesListMode? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SchemaRetrieveFormat? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SchemaRetrieveLang? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsListOwnership? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsListSortOrder? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListBillingStyle? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListOwnership? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.VoicesListProviderItem>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListProviderItem? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Account>? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AgentUsage>? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallTool>? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusQueryResult>? Type276 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.AgentDailyUsage>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1TimedMessage>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.CallThrottleRule>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.DailyCallStatistics>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.HourlyCallStatistics>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ConcurrencyBucket>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.APIKey>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Agent>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.AudioClip>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.CallEvent>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Call>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.CallStage>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.CallThrottle>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.CallTombstone>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Invoice>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ModelAlias>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ScheduledCallBatch>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ScheduledCall>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.SipRegistration>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ToolHistory>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Tool>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Voice>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Webhook>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1CorpusDocument>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1Corpus>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1CorpusSource>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1Message>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.AgentAllowance>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.EventsEnum>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.WebhookFailure>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.BillingUsageDay>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1SelectedTool>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1DynamicParameter>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1StaticParameter>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1AutomaticParameter>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1SecurityRequirements>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.VoicesListProviderItem>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Account>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.AgentUsage>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.CallTool>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1CorpusQueryResult>? ListType44 { get; set; }
    }
}