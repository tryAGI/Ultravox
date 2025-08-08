#nullable enable

namespace Ultravox
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Ultravox.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Webhook> WebhooksPartialUpdateAsync(
            global::System.Guid webhookId,
            global::Ultravox.PatchedWebhook request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="agentId">
        /// If set, this webhook will be limited to calls with this agent.
        /// </param>
        /// <param name="url"></param>
        /// <param name="secrets"></param>
        /// <param name="events"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Ultravox.Webhook> WebhooksPartialUpdateAsync(
            global::System.Guid webhookId,
            global::System.Guid? agentId = default,
            string? url = default,
            global::System.Collections.Generic.IList<string>? secrets = default,
            global::System.Collections.Generic.IList<global::Ultravox.EventsEnum>? events = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}