#nullable enable

namespace Ultravox
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List tools available to your account.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="ownership"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="sortOrder">
        /// Default Value: default
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.PaginatedToolList> ToolsListAsync(
            string? cursor = default,
            global::Ultravox.ToolsListOwnership? ownership = default,
            int? pageSize = default,
            string? search = default,
            global::Ultravox.ToolsListSortOrder? sortOrder = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List tools available to your account.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="ownership"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="sortOrder">
        /// Default Value: default
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AutoSDKHttpResponse<global::Ultravox.PaginatedToolList>> ToolsListAsResponseAsync(
            string? cursor = default,
            global::Ultravox.ToolsListOwnership? ownership = default,
            int? pageSize = default,
            string? search = default,
            global::Ultravox.ToolsListSortOrder? sortOrder = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}