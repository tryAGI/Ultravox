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
        global::System.Threading.Tasks.Task<global::Ultravox.UltravoxV1CorpusSource> CorporaSourcesCreateAsync(
            global::System.Guid corpusId,
            global::Ultravox.UltravoxV1CorpusSource request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="requestCorpusId">
        /// The id of this source's corpus.
        /// </param>
        /// <param name="sourceId">
        /// The unique ID of this source.
        /// </param>
        /// <param name="created">
        /// When this source was created.
        /// </param>
        /// <param name="name">
        /// The name of this source.
        /// </param>
        /// <param name="description">
        /// A description of this source.
        /// </param>
        /// <param name="stats">
        /// The current stats for this source.
        /// </param>
        /// <param name="loadSpec">
        /// How to load documents for this source.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.UltravoxV1CorpusSource> CorporaSourcesCreateAsync(
            global::System.Guid corpusId,
            string? requestCorpusId = default,
            string? sourceId = default,
            global::System.DateTime? created = default,
            string? name = default,
            string? description = default,
            global::Ultravox.UltravoxV1SourceStats? stats = default,
            global::Ultravox.UltravoxV1LoadSpec? loadSpec = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}