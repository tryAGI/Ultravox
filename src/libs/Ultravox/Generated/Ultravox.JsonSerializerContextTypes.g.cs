
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
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

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
        public global::Ultravox.UltravoxV1TranscriptionSettings? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMedium? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.OneOf<global::Ultravox.RetentionPolicyEnum?, global::Ultravox.NullEnum?>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.RetentionPolicyEnum? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.OneOf<global::Ultravox.AdmissionPreferenceEnum?, global::Ultravox.NullEnum?>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ExternalVoice? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1VadSettings? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionConfig? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Callbacks? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallSipDetails? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BackgroundAudio? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallEvent? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SeverityEnum? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.OneOf<global::Ultravox.TerminationReasonEnum?, global::Ultravox.NullEnum?>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.TerminationReasonEnum? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallStage? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallStatistics? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallThrottle? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallThrottleRule>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallThrottleRule? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallTombstone? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallTool? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTool? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallTrigger? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Trigger? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallUsage? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.DailyCallStatistics>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.DailyCallStatistics? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.HourlyCallStatistics>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.HourlyCallStatistics? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ConcurrencyBucket? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ConcurrencyResponse? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ConcurrencyBucket>? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CorpusUploadsRequest? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CorpusUploadsResponse? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.EventsEnum? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.FallbackHandler? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.IncomingHandoff? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Invoice? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.InvoiceStatusEnum? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ModelAlias? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedAPIKeyList? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.APIKey>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedAgentList? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Agent>? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedAudioClipList? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AudioClip>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallEventList? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallEvent>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallList? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Call>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallStageList? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallStage>? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallThrottleList? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallThrottle>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallTombstoneList? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallTombstone>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallTriggerList? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallTrigger>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedIncomingHandoffList? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.IncomingHandoff>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedInvoiceList? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Invoice>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedModelAliasList? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ModelAlias>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedScheduledCallBatchList? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ScheduledCallBatch>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ScheduledCallBatch? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedScheduledCallList? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ScheduledCall>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ScheduledCall? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedSipRegistrationList? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.SipRegistration>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SipRegistration? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedToolHistoryList? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ToolHistory>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolHistory? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedToolList? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Tool>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Tool? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedTriggerList? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Trigger>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Trigger? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedVoiceList? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Voice>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Voice? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedWebhookList? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Webhook>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Webhook? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1CorpusDocumentList? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusDocument>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusDocument? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1CorpusList? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Corpus>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Corpus? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1CorpusSourceList? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusSource>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusSource? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1MessageList? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Message>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Message? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAPIKey? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAccountTelephonyConfig? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAgent? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAudioClip? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedCallThrottle? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedPlivoConfig? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedScheduledCallBatch? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedSetTtsApiKeysRequest? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedSipConfig? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AgentAllowance>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedSipRegistration? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedTelnyxConfig? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedTwilioConfig? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedVoice? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedWebhook? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.EventsEnum>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.WebhookStatusEnum? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.WebhookFailure>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.WebhookFailure? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ScheduledCallStatusEnum? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SendCallDataMessage? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SipConfig? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseToolDefinition? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UsageResponse? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.BillingUsageDay>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplateInitialOutputMedium? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SelectedTool>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SelectedTool? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplateRetentionPolicy? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplateAdmissionPreference? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MediumRestriction? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SelectedTrigger>? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SelectedTrigger? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Handoff>? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Handoff? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusStats? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusDocumentMetadata? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusQueryResult? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusQueryResultCitation? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SourceStats? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CrawlSpec? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1UploadSpec? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AdvancedSpec? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MessageRole? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MessageMedium? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1InCallTimespan? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.GoogleProtobufValue? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AutomaticParameter? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AutomaticParameterLocation? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AutomaticParameterKnownValue? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseClientToolDetails? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseDataConnectionToolDetails? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseHttpToolDetails? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1DynamicParameter>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DynamicParameter? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1StaticParameter>? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StaticParameter? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AutomaticParameter>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ToolRequirements? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StaticToolResponse? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumWebRtcMedium? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumTwilioMedium? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumWebSocketMedium? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumTelnyxMedium? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumPlivoMedium? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumExotelMedium? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumSipMedium? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumDtmfHandling? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessage? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessageUrgency? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1PlivoMediumOutgoingRequestParams? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipMediumSipIncoming? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipMediumSipOutgoing? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TelnyxMediumOutgoingRequestParams? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TwilioMediumOutgoingRequestParams? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1EnabledDataMessages? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1HttpCallToolDetails? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ClientCallToolDetails? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionCallToolDetails? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallToolDefaultReaction? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Callback? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CartesiaVoice? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CartesiaVoiceCartesiaGenerationConfig? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusStatsStatus? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MimeTypeFilter? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionAudioConfig? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DynamicParameterLocation? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ElevenLabsVoice? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1LmntVoice? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1GoogleVoice? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1InworldVoice? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1RespeecherVoice? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1GenericVoice? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FallbackAgentGreeting? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FirstSpeakerSettingsUserGreeting? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FirstSpeakerSettingsAgentGreeting? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ReplacementConversationHistory? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1HeaderApiKeyRequirement? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1HttpAuthRequirement? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1InworldVoiceDeliveryMode? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1MediumRestrictionAllowedMedium>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MediumRestrictionAllowedMedium? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MimeTypeSet? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1QueryApiKeyRequirement? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1QueryCorpusRequest? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ReplacementConversationHistoryMessageSegments? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1ReplacementConversationHistoryMessagesSegment>? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ReplacementConversationHistoryMessagesSegment? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ReplacementConversationHistoryMessagesTemplate? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ReplacementConversationHistoryMessagesSlice? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SecurityOptions? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SecurityRequirements>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SecurityRequirements? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SecurityRequirement? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Ultravox.UltravoxV1SecurityRequirement>? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1UltravoxCallTokenRequirement? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipFallbackHandlerResponse? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequest? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequest? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipRejection? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SourceStatsStatus? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequestInitialOutputMedium? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ToolOverrides? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequestRetentionPolicy? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequestAdmissionPreference? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerOverrides? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestFirstSpeaker? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestInitialOutputMedium? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestRetentionPolicy? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestAdmissionPreference? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StaticParameterLocation? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TimedMessageEndBehavior? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerEvent? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerCondition? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TriggerAction>? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerAction? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerActionTernary? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerActionSetLocalVariable? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerActionIncrementLocalVariable? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerActionStartTimer? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerActionCancelTimer? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerActionSetSharedVariable? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerActionIncrementSharedVariable? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerConditionOperator? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TriggerCondition>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AudioClipsCreateRequest? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsCreateRequest? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsTestCreateRequest? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesCreateRequest? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AccountsMeUsageConcurrencyRetrieveBucket? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AgentsScheduledBatchesScheduledCallsListStatus? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallsEventsListMinimumSeverity? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallsMessagesListMode? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ModelsListPurpose? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SchemaRetrieveFormat? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SchemaRetrieveLang? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsListOwnership? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsListSortOrder? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListBillingStyle? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListOwnership? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.VoicesListProviderItem>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListProviderItem? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListReplacementStatus? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Account>? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AgentUsage>? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallTool>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusQueryResult>? Type324 { get; set; }

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
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.CallThrottleRule>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.DailyCallStatistics>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.HourlyCallStatistics>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ConcurrencyBucket>? ListType7 { get; set; }
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
        public global::System.Collections.Generic.List<global::Ultravox.CallTrigger>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.IncomingHandoff>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Invoice>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ModelAlias>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ScheduledCallBatch>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ScheduledCall>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.SipRegistration>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ToolHistory>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Tool>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Trigger>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Voice>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Webhook>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1CorpusDocument>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1Corpus>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1CorpusSource>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1Message>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.AgentAllowance>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.EventsEnum>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.WebhookFailure>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.BillingUsageDay>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1SelectedTool>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1SelectedTrigger>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1Handoff>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1DynamicParameter>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1StaticParameter>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1AutomaticParameter>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1MediumRestrictionAllowedMedium>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1ReplacementConversationHistoryMessagesSegment>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1SecurityRequirements>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1TriggerAction>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1TriggerCondition>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.VoicesListProviderItem>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Account>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.AgentUsage>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.CallTool>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1CorpusQueryResult>? ListType54 { get; set; }
    }
}