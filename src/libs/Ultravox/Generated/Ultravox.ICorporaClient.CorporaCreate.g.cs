#nullable enable

namespace Ultravox
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.UltravoxV1Corpus> CorporaCreateAsync(
            global::Ultravox.UltravoxV1Corpus request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="corpusId">
        /// The unique ID of this corpus.
        /// </param>
        /// <param name="created">
        /// When this corpus was created.
        /// </param>
        /// <param name="name">
        /// The name of this corpus.
        /// </param>
        /// <param name="description">
        /// A description of this corpus.
        /// </param>
        /// <param name="stats">
        /// The current stats for this corpus.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.UltravoxV1Corpus> CorporaCreateAsync(
            string? corpusId = default,
            global::System.DateTime? created = default,
            string? name = default,
            string? description = default,
            global::Ultravox.UltravoxV1CorpusStats? stats = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}