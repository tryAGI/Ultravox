#nullable enable

namespace Ultravox
{
    public partial interface IModelsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="baseModelName"></param>
        /// <param name="cursor"></param>
        /// <param name="pageSize"></param>
        /// <param name="purpose">
        /// Default Value: generation
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.PaginatedModelAliasList> ModelsListAsync(
            string? baseModelName = default,
            string? cursor = default,
            int? pageSize = default,
            global::Ultravox.ModelsListPurpose? purpose = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="baseModelName"></param>
        /// <param name="cursor"></param>
        /// <param name="pageSize"></param>
        /// <param name="purpose">
        /// Default Value: generation
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AutoSDKHttpResponse<global::Ultravox.PaginatedModelAliasList>> ModelsListAsResponseAsync(
            string? baseModelName = default,
            string? cursor = default,
            int? pageSize = default,
            global::Ultravox.ModelsListPurpose? purpose = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}