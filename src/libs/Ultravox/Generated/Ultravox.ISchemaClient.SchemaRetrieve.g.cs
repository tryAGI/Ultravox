#nullable enable

namespace Ultravox
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// OpenApi3 schema for this API. Format can be selected via content negotiation.<br/>
        /// - YAML: application/vnd.oai.openapi<br/>
        /// - JSON: application/vnd.oai.openapi+json
        /// </summary>
        /// <param name="format"></param>
        /// <param name="lang"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SchemaRetrieveAsync(
            global::Ultravox.SchemaRetrieveFormat? format = default,
            global::Ultravox.SchemaRetrieveLang? lang = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}