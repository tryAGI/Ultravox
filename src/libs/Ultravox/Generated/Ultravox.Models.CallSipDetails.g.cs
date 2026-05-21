
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallSipDetails
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billedDuration")]
        public string? BilledDuration { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminationReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Ultravox.JsonConverters.OneOfJsonConverter<global::Ultravox.TerminationReasonEnum?, global::Ultravox.NullEnum?>))]
        public global::Ultravox.OneOf<global::Ultravox.TerminationReasonEnum?, global::Ultravox.NullEnum?>? TerminationReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallSipDetails" /> class.
        /// </summary>
        /// <param name="billedDuration">
        /// Included only in responses
        /// </param>
        /// <param name="terminationReason">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallSipDetails(
            string? billedDuration,
            global::Ultravox.OneOf<global::Ultravox.TerminationReasonEnum?, global::Ultravox.NullEnum?>? terminationReason)
        {
            this.BilledDuration = billedDuration;
            this.TerminationReason = terminationReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallSipDetails" /> class.
        /// </summary>
        public CallSipDetails()
        {
        }

    }
}