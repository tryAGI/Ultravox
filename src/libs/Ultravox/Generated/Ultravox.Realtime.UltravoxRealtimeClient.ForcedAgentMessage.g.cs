
#nullable enable

namespace Ultravox.Realtime
{
    public sealed partial class UltravoxRealtimeClient
    {
        /// <summary>
        /// Force the agent to say specific text or invoke tools.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendForcedAgentMessageAsync(
            global::Ultravox.Realtime.ForcedAgentMessagePayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Ultravox.Realtime.ForcedAgentMessagePayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}