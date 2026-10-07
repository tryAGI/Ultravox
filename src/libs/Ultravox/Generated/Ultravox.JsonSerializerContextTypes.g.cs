
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
        public global::Ultravox.AdmissionPreferenceEnum? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Agent? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplate? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AgentStatistics? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AgentAllowance? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AgentBasic? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AgentDailyUsage? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AgentUsage? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AgentDailyUsage>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AudioClip? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.OwnershipEnum? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.BillingReasonEnum? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.BillingStatusEnum? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.BillingStyleEnum? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.BillingUsageDay? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Call? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.OneOf<global::Ultravox.EndReasonEnum?, global::Ultravox.NullEnum?>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.EndReasonEnum? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.NullEnum? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.FirstSpeakerEnum? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FirstSpeakerSettings? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TimedMessage>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TimedMessage? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.InitialOutputMediumEnum? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMedium? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.OneOf<global::Ultravox.RetentionPolicyEnum?, global::Ultravox.NullEnum?>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.RetentionPolicyEnum? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.OneOf<global::Ultravox.AdmissionPreferenceEnum?, global::Ultravox.NullEnum?>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ExternalVoice? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1VadSettings? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionConfig? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Callbacks? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallSipDetails? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BackgroundAudio? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallEvent? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SeverityEnum? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.OneOf<global::Ultravox.TerminationReasonEnum?, global::Ultravox.NullEnum?>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.TerminationReasonEnum? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallStage? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallStatistics? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallThrottle? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallThrottleRule>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallThrottleRule? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallTombstone? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallTool? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTool? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallUsage? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.DailyCallStatistics>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.DailyCallStatistics? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.HourlyCallStatistics>? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.HourlyCallStatistics? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ConcurrencyBucket? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ConcurrencyResponse? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ConcurrencyBucket>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CorpusUploadsRequest? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CorpusUploadsResponse? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.EventsEnum? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.FallbackHandler? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Invoice? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.InvoiceStatusEnum? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ModelAlias? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedAPIKeyList? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.APIKey>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedAgentList? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Agent>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedAudioClipList? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AudioClip>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallEventList? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallEvent>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallList? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Call>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallStageList? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallStage>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallThrottleList? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallThrottle>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallTombstoneList? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallTombstone>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedInvoiceList? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Invoice>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedModelAliasList? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ModelAlias>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedScheduledCallBatchList? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ScheduledCallBatch>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ScheduledCallBatch? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedScheduledCallList? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ScheduledCall>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ScheduledCall? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedSipRegistrationList? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.SipRegistration>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SipRegistration? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedToolHistoryList? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ToolHistory>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolHistory? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedToolList? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Tool>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Tool? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedVoiceList? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Voice>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Voice? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedWebhookList? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Webhook>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Webhook? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1CorpusDocumentList? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusDocument>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusDocument? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1CorpusList? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Corpus>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Corpus? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1CorpusSourceList? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusSource>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusSource? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1MessageList? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Message>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Message? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAPIKey? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAccountTelephonyConfig? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAgent? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAudioClip? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedCallThrottle? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedPlivoConfig? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedScheduledCallBatch? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedSetTtsApiKeysRequest? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedSipConfig? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AgentAllowance>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedSipRegistration? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedTelnyxConfig? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedTwilioConfig? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedVoice? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedWebhook? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.EventsEnum>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.WebhookStatusEnum? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.WebhookFailure>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.WebhookFailure? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ScheduledCallStatusEnum? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SendCallDataMessage? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SipConfig? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseToolDefinition? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UsageResponse? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.BillingUsageDay>? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplateInitialOutputMedium? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SelectedTool>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SelectedTool? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplateRetentionPolicy? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplateAdmissionPreference? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusStats? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusDocumentMetadata? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusQueryResult? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusQueryResultCitation? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SourceStats? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CrawlSpec? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1UploadSpec? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AdvancedSpec? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MessageRole? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MessageMedium? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1InCallTimespan? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.GoogleProtobufValue? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AutomaticParameter? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AutomaticParameterLocation? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AutomaticParameterKnownValue? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseClientToolDetails? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseDataConnectionToolDetails? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseHttpToolDetails? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1DynamicParameter>? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DynamicParameter? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1StaticParameter>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StaticParameter? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AutomaticParameter>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ToolRequirements? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StaticToolResponse? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumWebRtcMedium? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumTwilioMedium? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumWebSocketMedium? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumTelnyxMedium? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumPlivoMedium? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumExotelMedium? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumSipMedium? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumDtmfHandling? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessage? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessageUrgency? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1PlivoMediumOutgoingRequestParams? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipMediumSipIncoming? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipMediumSipOutgoing? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TelnyxMediumOutgoingRequestParams? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TwilioMediumOutgoingRequestParams? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1EnabledDataMessages? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1HttpCallToolDetails? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ClientCallToolDetails? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionCallToolDetails? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallToolDefaultReaction? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Callback? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CartesiaVoice? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CartesiaVoiceCartesiaGenerationConfig? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusStatsStatus? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MimeTypeFilter? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionAudioConfig? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DynamicParameterLocation? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ElevenLabsVoice? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1LmntVoice? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1GoogleVoice? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1InworldVoice? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1RespeecherVoice? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1GenericVoice? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FallbackAgentGreeting? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FirstSpeakerSettingsUserGreeting? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FirstSpeakerSettingsAgentGreeting? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1HeaderApiKeyRequirement? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1HttpAuthRequirement? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1InworldVoiceDeliveryMode? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MimeTypeSet? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1QueryApiKeyRequirement? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1QueryCorpusRequest? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SecurityOptions? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SecurityRequirements>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SecurityRequirements? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SecurityRequirement? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Ultravox.UltravoxV1SecurityRequirement>? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1UltravoxCallTokenRequirement? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipFallbackHandlerResponse? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequest? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequest? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipRejection? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SourceStatsStatus? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequestInitialOutputMedium? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ToolOverrides? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequestRetentionPolicy? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequestAdmissionPreference? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestFirstSpeaker? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestInitialOutputMedium? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestRetentionPolicy? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestAdmissionPreference? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StaticParameterLocation? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TimedMessageEndBehavior? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AudioClipsCreateRequest? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsCreateRequest? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsTestCreateRequest? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesCreateRequest? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AccountsMeUsageConcurrencyRetrieveBucket? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AgentsScheduledBatchesScheduledCallsListStatus? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallsEventsListMinimumSeverity? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallsMessagesListMode? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SchemaRetrieveFormat? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SchemaRetrieveLang? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsListOwnership? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsListSortOrder? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListBillingStyle? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListOwnership? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.VoicesListProviderItem>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListProviderItem? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Account>? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AgentUsage>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallTool>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusQueryResult>? Type281 { get; set; }

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