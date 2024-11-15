#nullable enable

namespace Ultravox
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Updates an API key.
        /// </summary>
        /// <param name="apiKeyPrefix"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.APIKey> ApiKeysPartialUpdateAsync(
            string apiKeyPrefix,
            global::Ultravox.PatchedAPIKey request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an API key.
        /// </summary>
        /// <param name="apiKeyPrefix"></param>
        /// <param name="revoked">
        /// If the API key is revoked, clients cannot use it anymore. (This cannot be undone.)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.APIKey> ApiKeysPartialUpdateAsync(
            string apiKeyPrefix,
            bool? revoked = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}