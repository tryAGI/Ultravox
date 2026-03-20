
#nullable enable

namespace Ultravox.Realtime
{
    public sealed partial class UltravoxRealtimeClient
    {
        /// <summary>
        /// Send a ping to measure round-trip latency.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendPingAsync(
            global::Ultravox.Realtime.PingPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Ultravox.Realtime.PingPayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}