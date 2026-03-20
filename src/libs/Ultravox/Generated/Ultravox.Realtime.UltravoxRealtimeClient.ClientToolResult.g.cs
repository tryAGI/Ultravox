
#nullable enable

namespace Ultravox.Realtime
{
    public sealed partial class UltravoxRealtimeClient
    {
        /// <summary>
        /// Send a client tool execution result.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendClientToolResultAsync(
            global::Ultravox.Realtime.ClientToolResultPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Ultravox.Realtime.ClientToolResultPayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}