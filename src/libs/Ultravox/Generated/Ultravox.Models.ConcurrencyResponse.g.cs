
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConcurrencyResponse
    {
        /// <summary>
        /// Concurrency over time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeSeries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Ultravox.ConcurrencyBucket> TimeSeries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyResponse" /> class.
        /// </summary>
        /// <param name="timeSeries">
        /// Concurrency over time
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConcurrencyResponse(
            global::System.Collections.Generic.IList<global::Ultravox.ConcurrencyBucket> timeSeries)
        {
            this.TimeSeries = timeSeries ?? throw new global::System.ArgumentNullException(nameof(timeSeries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcurrencyResponse" /> class.
        /// </summary>
        public ConcurrencyResponse()
        {
        }

    }
}