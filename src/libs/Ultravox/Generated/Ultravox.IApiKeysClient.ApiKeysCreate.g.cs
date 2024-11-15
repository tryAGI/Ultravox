#nullable enable

namespace Ultravox
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Creates a new API key.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.APIKeyCreate> ApiKeysCreateAsync(
            global::Ultravox.APIKeyCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new API key.
        /// </summary>
        /// <param name="name">
        /// A free-form name for the API key. Need not be unique. 50 characters max.
        /// </param>
        /// <param name="expiryDate">
        /// Once API key expires, clients cannot use it anymore.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.APIKeyCreate> ApiKeysCreateAsync(
            string name,
            global::System.DateTime? expiryDate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}