#nullable enable

namespace Ultravox
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusQueryResult>> CorporaQueryAsync(
            global::System.Guid corpusId,
            global::Ultravox.UltravoxV1QueryCorpusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="query">
        /// The query to run.
        /// </param>
        /// <param name="maxResults">
        /// The maximum number of results to return.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Ultravox.UltravoxV1CorpusQueryResult>> CorporaQueryAsync(
            global::System.Guid corpusId,
            string? query = default,
            int? maxResults = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}