#nullable enable

namespace Ultravox
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Request a presigned URL for uploading a document.
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.CorpusUploadsResponse> CorporaUploadsCreateAsync(
            global::System.Guid corpusId,

            global::Ultravox.CorpusUploadsRequest request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request a presigned URL for uploading a document.
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AutoSDKHttpResponse<global::Ultravox.CorpusUploadsResponse>> CorporaUploadsCreateAsResponseAsync(
            global::System.Guid corpusId,

            global::Ultravox.CorpusUploadsRequest request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request a presigned URL for uploading a document.
        /// </summary>
        /// <param name="corpusId"></param>
        /// <param name="mimeType">
        /// The MIME type of the file to be uploaded.
        /// </param>
        /// <param name="fileName">
        /// The name of the file to be uploaded.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.CorpusUploadsResponse> CorporaUploadsCreateAsync(
            global::System.Guid corpusId,
            string mimeType,
            string? fileName = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}