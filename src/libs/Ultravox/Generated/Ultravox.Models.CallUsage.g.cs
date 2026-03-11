
#nullable enable

namespace Ultravox
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallUsage
    {
        /// <summary>
        /// All-time call usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Ultravox.CallStatistics AllTime { get; set; } = default!;

        /// <summary>
        /// Call usage per day
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Ultravox.DailyCallStatistics> Daily { get; set; } = default!;

        /// <summary>
        /// Call counts by date and hour
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hourly")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Ultravox.HourlyCallStatistics> Hourly { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallUsage" /> class.
        /// </summary>
        /// <param name="allTime">
        /// All-time call usage
        /// </param>
        /// <param name="daily">
        /// Call usage per day
        /// </param>
        /// <param name="hourly">
        /// Call counts by date and hour
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallUsage(
            global::Ultravox.CallStatistics allTime,
            global::System.Collections.Generic.IList<global::Ultravox.DailyCallStatistics> daily,
            global::System.Collections.Generic.IList<global::Ultravox.HourlyCallStatistics> hourly)
        {
            this.AllTime = allTime ?? throw new global::System.ArgumentNullException(nameof(allTime));
            this.Daily = daily ?? throw new global::System.ArgumentNullException(nameof(daily));
            this.Hourly = hourly ?? throw new global::System.ArgumentNullException(nameof(hourly));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallUsage" /> class.
        /// </summary>
        public CallUsage()
        {
        }
    }
}