#nullable enable

namespace Ultravox
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Gets an API key.
        /// </summary>
        /// <param name="apiKeyPrefix"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.APIKey> ApiKeysRetrieveAsync(
            string apiKeyPrefix,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}