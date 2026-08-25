#nullable enable

namespace Ultravox
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Test a tool by executing it with the provided parameters.<br/>
        /// Every property other than `authTokens` is treated as a value for one of the tool's dynamic parameters, matched by parameter name and sent in whichever location that parameter declares (query, path, header, or body). Properties that don't match a dynamic parameter are ignored. The tool's static and automatic parameters are filled in automatically, so they should not be supplied here.<br/>
        /// Only HTTP tools can be tested. Tools requiring an Ultravox call token are rejected, since no call exists to issue one against.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ToolsTestCreateAsync(
            global::System.Guid toolId,

            global::Ultravox.ToolsTestCreateRequest request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test a tool by executing it with the provided parameters.<br/>
        /// Every property other than `authTokens` is treated as a value for one of the tool's dynamic parameters, matched by parameter name and sent in whichever location that parameter declares (query, path, header, or body). Properties that don't match a dynamic parameter are ignored. The tool's static and automatic parameters are filled in automatically, so they should not be supplied here.<br/>
        /// Only HTTP tools can be tested. Tools requiring an Ultravox call token are rejected, since no call exists to issue one against.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> ToolsTestCreateAsStreamAsync(
            global::System.Guid toolId,

            global::Ultravox.ToolsTestCreateRequest request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test a tool by executing it with the provided parameters.<br/>
        /// Every property other than `authTokens` is treated as a value for one of the tool's dynamic parameters, matched by parameter name and sent in whichever location that parameter declares (query, path, header, or body). Properties that don't match a dynamic parameter are ignored. The tool's static and automatic parameters are filled in automatically, so they should not be supplied here.<br/>
        /// Only HTTP tools can be tested. Tools requiring an Ultravox call token are rejected, since no call exists to issue one against.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.AutoSDKHttpResponse<byte[]>> ToolsTestCreateAsResponseAsync(
            global::System.Guid toolId,

            global::Ultravox.ToolsTestCreateRequest request,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test a tool by executing it with the provided parameters.<br/>
        /// Every property other than `authTokens` is treated as a value for one of the tool's dynamic parameters, matched by parameter name and sent in whichever location that parameter declares (query, path, header, or body). Properties that don't match a dynamic parameter are ignored. The tool's static and automatic parameters are filled in automatically, so they should not be supplied here.<br/>
        /// Only HTTP tools can be tested. Tools requiring an Ultravox call token are rejected, since no call exists to issue one against.
        /// </summary>
        /// <param name="toolId"></param>
        /// <param name="authTokens">
        /// Values satisfying the tool's security requirements, keyed by requirement name. Applied the same way as for a real call: a headerApiKey requirement sends its value as the named header, a queryApiKey requirement as the named query parameter, and an httpAuth requirement as an Authorization header prefixed with the requirement's scheme.<br/>
        /// Example: {"myServiceApiKey":"my-secret-value"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> ToolsTestCreateAsync(
            global::System.Guid toolId,
            global::System.Collections.Generic.Dictionary<string, string>? authTokens = default,
            global::Ultravox.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}