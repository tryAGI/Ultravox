
#nullable enable

namespace Ultravox.Realtime
{
    public sealed partial class UltravoxRealtimeClient
    {
        /// <summary>
        /// Instruct the agent to end the call.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendHangUpAsync(
            global::Ultravox.Realtime.HangUpPayload message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Ultravox.Realtime.HangUpPayload), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}