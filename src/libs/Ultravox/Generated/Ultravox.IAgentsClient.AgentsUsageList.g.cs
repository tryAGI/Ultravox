#nullable enable

namespace Ultravox
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentIds"></param>
        /// <param name="durationMax"></param>
        /// <param name="durationMin"></param>
        /// <param name="fromDate"></param>
        /// <param name="metadata"></param>
        /// <param name="search"></param>
        /// <param name="timeOfDayEnd">
        /// Default Value: 23:59:59.999999
        /// </param>
        /// <param name="timeOfDayStart">
        /// Default Value: 00:00:00
        /// </param>
        /// <param name="toDate"></param>
        /// <param name="voiceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Ultravox.AgentUsage>> AgentsUsageListAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? agentIds = default,
            string? durationMax = default,
            string? durationMin = default,
            global::System.DateTime? fromDate = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? search = default,
            string? timeOfDayEnd = default,
            string? timeOfDayStart = default,
            global::System.DateTime? toDate = default,
            global::System.Guid? voiceId = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}