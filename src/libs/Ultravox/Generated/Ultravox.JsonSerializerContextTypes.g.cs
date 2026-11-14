
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
        public global::Ultravox.Invoice? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.InvoiceStatusEnum? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ModelAlias? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedAPIKeyList? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.APIKey>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedAgentList? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Agent>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedAudioClipList? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AudioClip>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallEventList? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallEvent>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallList? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Call>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallStageList? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallStage>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallThrottleList? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallThrottle>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallTombstoneList? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallTombstone>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedCallTriggerList? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallTrigger>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedInvoiceList? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Invoice>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedModelAliasList? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ModelAlias>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedScheduledCallBatchList? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ScheduledCallBatch>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ScheduledCallBatch? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedScheduledCallList? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ScheduledCall>? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ScheduledCall? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedSipRegistrationList? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.SipRegistration>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SipRegistration? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedToolHistoryList? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.ToolHistory>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolHistory? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedToolList? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Tool>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Tool? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedTriggerList? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Trigger>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Trigger? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedVoiceList? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Voice>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Voice? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedWebhookList? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Webhook>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.Webhook? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1CorpusDocumentList? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusDocument>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusDocument? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1CorpusList? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Corpus>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Corpus? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1CorpusSourceList? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusSource>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusSource? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PaginatedultravoxV1MessageList? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1Message>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Message? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAPIKey? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAccountTelephonyConfig? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAgent? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedAudioClip? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedCallThrottle? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedPlivoConfig? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Guid>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedScheduledCallBatch? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedSetTtsApiKeysRequest? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedSipConfig? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AgentAllowance>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedSipRegistration? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedTelnyxConfig? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedTwilioConfig? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedVoice? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.PatchedWebhook? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.EventsEnum>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.WebhookStatusEnum? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.WebhookFailure>? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.WebhookFailure? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ScheduledCallStatusEnum? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SendCallDataMessage? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SipConfig? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseToolDefinition? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UsageResponse? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.BillingUsageDay>? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplateInitialOutputMedium? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SelectedTool>? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SelectedTool? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplateRetentionPolicy? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallTemplateAdmissionPreference? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MediumRestriction? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SelectedTrigger>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SelectedTrigger? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusStats? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusDocumentMetadata? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusQueryResult? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusQueryResultCitation? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SourceStats? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CrawlSpec? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1UploadSpec? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AdvancedSpec? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MessageRole? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MessageMedium? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1InCallTimespan? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.GoogleProtobufValue? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails>? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AutomaticParameter? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AutomaticParameterLocation? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1AutomaticParameterKnownValue? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseClientToolDetails? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseDataConnectionToolDetails? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseHttpToolDetails? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1DynamicParameter>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DynamicParameter? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1StaticParameter>? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StaticParameter? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1AutomaticParameter>? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ToolRequirements? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1BaseToolDefinitionDefaultReaction? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StaticToolResponse? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumWebRtcMedium? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumTwilioMedium? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumWebSocketMedium? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumTelnyxMedium? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumPlivoMedium? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumExotelMedium? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumSipMedium? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumDtmfHandling? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessage? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallMediumDtmfUserTextMessageUrgency? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1PlivoMediumOutgoingRequestParams? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipMediumSipIncoming? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipMediumSipOutgoing? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TelnyxMediumOutgoingRequestParams? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TwilioMediumOutgoingRequestParams? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1EnabledDataMessages? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1HttpCallToolDetails? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ClientCallToolDetails? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionCallToolDetails? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CallToolDefaultReaction? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1Callback? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CartesiaVoice? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CartesiaVoiceCartesiaGenerationConfig? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1CorpusStatsStatus? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MimeTypeFilter? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionAudioConfig? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DataConnectionAudioConfigChannelMode? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1DynamicParameterLocation? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ElevenLabsVoice? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1LmntVoice? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1GoogleVoice? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1InworldVoice? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1RespeecherVoice? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1GenericVoice? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FallbackAgentGreeting? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FirstSpeakerSettingsUserGreeting? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1FirstSpeakerSettingsAgentGreeting? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1GenericVoiceJsonByteEncoding? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1HeaderApiKeyRequirement? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1HttpAuthRequirement? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1InworldVoiceDeliveryMode? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1MediumRestrictionAllowedMedium>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MediumRestrictionAllowedMedium? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1MimeTypeSet? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1QueryApiKeyRequirement? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1QueryCorpusRequest? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SecurityOptions? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1SecurityRequirements>? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SecurityRequirements? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SecurityRequirement? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Ultravox.UltravoxV1SecurityRequirement>? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1UltravoxCallTokenRequirement? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipFallbackHandlerResponse? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequest? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequest? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SipRejection? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1SourceStatsStatus? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequestInitialOutputMedium? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1ToolOverrides? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequestRetentionPolicy? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartAgentCallRequestAdmissionPreference? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerOverrides? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestFirstSpeaker? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestInitialOutputMedium? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestRetentionPolicy? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StartCallRequestAdmissionPreference? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1StaticParameterLocation? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TimedMessageEndBehavior? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerEvent? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerCondition? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TriggerAction>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerAction? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerActionTernary? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerActionSetLocalVariable? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerActionIncrementLocalVariable? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerActionStartTimer? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerActionCancelTimer? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.UltravoxV1TriggerConditionOperator? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1TriggerCondition>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AudioClipsCreateRequest? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsCreateRequest? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsTestCreateRequest? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesCreateRequest? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AccountsMeUsageConcurrencyRetrieveBucket? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.AgentsScheduledBatchesScheduledCallsListStatus? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallsEventsListMinimumSeverity? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.CallsMessagesListMode? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ModelsListPurpose? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SchemaRetrieveFormat? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.SchemaRetrieveLang? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsListOwnership? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.ToolsListSortOrder? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListBillingStyle? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListOwnership? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.VoicesListProviderItem>? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListProviderItem? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Ultravox.VoicesListReplacementStatus? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.Account>? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.AgentUsage>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.CallTool>? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusQueryResult>? Type311 { get; set; }

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
        public global::System.Collections.Generic.List<global::Ultravox.Invoice>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ModelAlias>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ScheduledCallBatch>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ScheduledCall>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.SipRegistration>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.ToolHistory>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Tool>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Trigger>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Voice>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Webhook>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1CorpusDocument>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1Corpus>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1CorpusSource>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1Message>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Guid>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.AgentAllowance>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.EventsEnum>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.WebhookFailure>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.BillingUsageDay>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1SelectedTool>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1SelectedTrigger>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1AdvancedSpecDocumentDetails>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1DynamicParameter>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1StaticParameter>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1AutomaticParameter>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1ElevenLabsVoicePronunciationDictionaryReference>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1MediumRestrictionAllowedMedium>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1SecurityRequirements>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1TriggerAction>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1TriggerCondition>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.VoicesListProviderItem>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.Account>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.AgentUsage>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.CallTool>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Ultravox.UltravoxV1CorpusQueryResult>? ListType51 { get; set; }
    }
}