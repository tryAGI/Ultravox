
#nullable enable

namespace Ultravox
{
    public sealed partial class UltravoxClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Ultravox.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "X-API-Key",
                Value = apiKey,
            });
        }
    }
}