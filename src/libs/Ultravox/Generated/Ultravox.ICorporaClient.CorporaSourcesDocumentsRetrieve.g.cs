#nullable enable

namespace Ultravox
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="documentId"></param>
        /// <param name="sourceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.UltravoxV1CorpusDocument> CorporaSourcesDocumentsRetrieveAsync(
            global::System.Guid corpusId,
            global::System.Guid documentId,
            global::System.Guid sourceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}