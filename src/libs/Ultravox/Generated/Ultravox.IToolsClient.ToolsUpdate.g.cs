#nullable enable

namespace Ultravox
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Tool> ToolsUpdateAsync(
            global::System.Guid toolId,
            global::Ultravox.Tool request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="name"></param>
        /// <param name="definition">
        /// The base definition of a tool that can be used during a call. Exactly one<br/>
        ///  implementation (http or client) should be set.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Tool> ToolsUpdateAsync(
            global::System.Guid toolId,
            string name,
            global::Ultravox.UltravoxV1BaseToolDefinition definition,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}