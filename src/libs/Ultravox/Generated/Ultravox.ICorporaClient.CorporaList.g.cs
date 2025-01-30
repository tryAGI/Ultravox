#nullable enable

namespace Ultravox
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.PaginatedultravoxV1CorpusList> CorporaListAsync(
            string? cursor = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}