#nullable enable

namespace Ultravox
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Test a tool by executing it with the provided parameters.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ToolsTestCreateAsync(
            global::System.Guid toolId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}