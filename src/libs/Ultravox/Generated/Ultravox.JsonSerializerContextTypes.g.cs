
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
        public global::Ultravox.CallMediumRestriction? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallMediumRestrictionAllowedMedium>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallMediumRestrictionAllowedMedium? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMedium? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.OneOf<global::Ultravox.RetentionPolicyEnum?, global::Ultravox.NullEnum?>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.RetentionPolicyEnum? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.OneOf<global::Ultravox.AdmissionPreferenceEnum?, global::Ultravox.NullEnum?>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ExternalVoice? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1VadSettings? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionConfig? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Callbacks? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallSipDetails? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BackgroundAudio? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallEvent? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SeverityEnum? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.OneOf<global::Ultravox.TerminationReasonEnum?, global::Ultravox.NullEnum?>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.TerminationReasonEnum? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallStage? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallStatistics? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallThrottle? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallThrottleRule>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallThrottleRule? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallTombstone? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallTool? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTool? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallUsage? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.DailyCallStatistics>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.DailyCallStatistics? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.HourlyCallStatistics>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.HourlyCallStatistics? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ConcurrencyBucket? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ConcurrencyResponse? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ConcurrencyBucket>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CorpusUploadsRequest? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CorpusUploadsResponse? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.EventsEnum? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.FallbackHandler? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Invoice? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.InvoiceStatusEnum? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ModelAlias? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedAPIKeyList? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.APIKey>? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedAgentList? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Agent>? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedAudioClipList? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AudioClip>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallEventList? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallEvent>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallList? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Call>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallStageList? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallStage>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallThrottleList? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallThrottle>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallTombstoneList? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallTombstone>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedInvoiceList? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Invoice>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedModelAliasList? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ModelAlias>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedScheduledCallBatchList? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ScheduledCallBatch>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ScheduledCallBatch? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedScheduledCallList? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ScheduledCall>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ScheduledCall? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedSipRegistrationList? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.SipRegistration>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SipRegistration? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedToolHistoryList? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ToolHistory>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolHistory? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedToolList? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Tool>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Tool? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedVoiceList? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Voice>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Voice? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedWebhookList? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Webhook>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Webhook? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1CorpusDocumentList? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusDocument>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusDocument? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1CorpusList? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Corpus>? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Corpus? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1CorpusSourceList? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusSource>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusSource? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1MessageList? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Message>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Message? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAPIKey? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAccountTelephonyConfig? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAgent? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAudioClip? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedCallThrottle? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedPlivoConfig? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedScheduledCallBatch? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedSetTtsApiKeysRequest? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedSipConfig? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AgentAllowance>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedSipRegistration? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedTelnyxConfig? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedTwilioConfig? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedVoice? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedWebhook? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.EventsEnum>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.WebhookStatusEnum? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.WebhookFailure>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.WebhookFailure? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ScheduledCallStatusEnum? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SendCallDataMessage? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SipConfig? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseToolDefinition? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UsageResponse? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.BillingUsageDay>? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplateInitialOutputMedium? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SelectedTool>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SelectedTool? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplateRetentionPolicy? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplateAdmissionPreference? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MediumRestriction? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusStats? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusDocumentMetadata? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusQueryResult? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusQueryResultCitation? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SourceStats? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CrawlSpec? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1UploadSpec? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AdvancedSpec? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MessageRole? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MessageMedium? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1InCallTimespan? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.GoogleProtobufValue? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AutomaticParameter? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AutomaticParameterLocation? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AutomaticParameterKnownValue? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseClientToolDetails? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseDataConnectionToolDetails? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseHttpToolDetails? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1DynamicParameter>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DynamicParameter? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1StaticParameter>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StaticParameter? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AutomaticParameter>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ToolRequirements? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StaticToolResponse? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumWebRtcMedium? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumTwilioMedium? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumWebSocketMedium? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumTelnyxMedium? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumPlivoMedium? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumExotelMedium? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumSipMedium? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumDtmfHandling? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessage? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessageUrgency? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1PlivoMediumOutgoingRequestParams? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipMediumSipIncoming? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipMediumSipOutgoing? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TelnyxMediumOutgoingRequestParams? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TwilioMediumOutgoingRequestParams? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1EnabledDataMessages? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1HttpCallToolDetails? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ClientCallToolDetails? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionCallToolDetails? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallToolDefaultReaction? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Callback? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CartesiaVoice? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CartesiaVoiceCartesiaGenerationConfig? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusStatsStatus? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MimeTypeFilter? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionAudioConfig? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DynamicParameterLocation? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ElevenLabsVoice? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1LmntVoice? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1GoogleVoice? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1InworldVoice? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1RespeecherVoice? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1GenericVoice? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FallbackAgentGreeting? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FirstSpeakerSettingsUserGreeting? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FirstSpeakerSettingsAgentGreeting? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1HeaderApiKeyRequirement? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1HttpAuthRequirement? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1InworldVoiceDeliveryMode? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1MediumRestrictionAllowedMedium>? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MediumRestrictionAllowedMedium? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MimeTypeSet? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1QueryApiKeyRequirement? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1QueryCorpusRequest? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SecurityOptions? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SecurityRequirements>? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SecurityRequirements? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SecurityRequirement? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Ultravox.UltravoxV1SecurityRequirement>? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1UltravoxCallTokenRequirement? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipFallbackHandlerResponse? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequest? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequest? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipRejection? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SourceStatsStatus? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequestInitialOutputMedium? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ToolOverrides? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequestRetentionPolicy? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequestAdmissionPreference? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestFirstSpeaker? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestInitialOutputMedium? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestRetentionPolicy? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestAdmissionPreference? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StaticParameterLocation? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TimedMessageEndBehavior? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AudioClipsCreateRequest? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsCreateRequest? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsTestCreateRequest? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesCreateRequest? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AccountsMeUsageConcurrencyRetrieveBucket? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AgentsScheduledBatchesScheduledCallsListStatus? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallsEventsListMinimumSeverity? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallsMessagesListMode? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ModelsListPurpose? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SchemaRetrieveFormat? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SchemaRetrieveLang? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsListOwnership? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsListSortOrder? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListBillingStyle? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListOwnership? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.VoicesListProviderItem>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListProviderItem? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListReplacementStatus? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Account>? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AgentUsage>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallTool>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusQueryResult>? Type289 { get; set; }

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
        public global::System.Collections.Generic.List<global::Ultravox.CallMediumRestrictionAllowedMedium>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.CallThrottleRule>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.DailyCallStatistics>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.HourlyCallStatistics>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ConcurrencyBucket>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.APIKey>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Agent>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.AudioClip>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.CallEvent>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Call>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.CallStage>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.CallThrottle>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.CallTombstone>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Invoice>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ModelAlias>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ScheduledCallBatch>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ScheduledCall>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.SipRegistration>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ToolHistory>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Tool>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Voice>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Webhook>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1CorpusDocument>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1Corpus>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1CorpusSource>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1Message>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.AgentAllowance>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.EventsEnum>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.WebhookFailure>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.BillingUsageDay>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1SelectedTool>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1DynamicParameter>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1StaticParameter>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1AutomaticParameter>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1MediumRestrictionAllowedMedium>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1SecurityRequirements>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.VoicesListProviderItem>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Account>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.AgentUsage>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.CallTool>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1CorpusQueryResult>? ListType46 { get; set; }
    }
}