/*
order: 50
title: Realtime Voice Call
slug: realtime-voice-call

Connect to the Ultravox real-time voice call WebSocket API for bidirectional voice/text communication.
*/

using Ultravox.Realtime;

namespace Ultravox.IntegrationTests;

public partial class Tests
{
    //// Start a voice call via the REST API and connect to the WebSocket for real-time interaction.

    [TestMethod]
    [TestCategory("Explicit")]
    public async Task Example_RealtimeVoiceCall()
    {
        using var client = GetAuthenticatedClient();

        //// Create a call using the REST API to get a joinUrl.
        var call = await client.Calls.CallsCreateAsync(new UltravoxV1StartCallRequest
        {
            SystemPrompt = "You are a helpful assistant. Respond briefly.",
        });

        call.Should().NotBeNull();
        call.JoinUrl.Should().NotBeNullOrEmpty();

        Console.WriteLine($"Call ID: {call.CallId}");

        //// Connect to the WebSocket using the joinUrl from the REST call.
        using var realtimeClient = new UltravoxRealtimeClient();
        await realtimeClient.ConnectAsync(new Uri(call.JoinUrl!));

        realtimeClient.IsConnected.Should().BeTrue();

        //// Send a text message to the agent.
        await realtimeClient.SendUserTextMessageAsync(new UserTextMessagePayload
        {
            Text = "Hello, how are you?",
        });

        //// Receive server events: state changes, transcripts, and tool invocations.
        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
        var receivedCallStarted = false;
        var receivedTranscript = false;

        await foreach (var serverEvent in realtimeClient.ReceiveUpdatesAsync(cts.Token))
        {
            if (serverEvent.IsCallStarted)
            {
                receivedCallStarted = true;
                Console.WriteLine($"Call started: {serverEvent.CallStarted?.CallId}");
            }
            else if (serverEvent.IsState)
            {
                Console.WriteLine($"Agent state: {serverEvent.State?.State}");
            }
            else if (serverEvent.IsTranscript)
            {
                var transcript = serverEvent.Transcript!;
                Console.Write(transcript.Delta ?? transcript.Text);

                if (transcript.Final == true && transcript.Role == TranscriptPayloadRole.Agent)
                {
                    receivedTranscript = true;
                    Console.WriteLine();
                    break;
                }
            }
            else if (serverEvent.IsClientToolInvocation)
            {
                //// Respond to client tool invocations.
                var invocation = serverEvent.ClientToolInvocation!;
                await realtimeClient.SendClientToolResultAsync(new ClientToolResultPayload
                {
                    InvocationId = invocation.InvocationId,
                    Result = "Tool executed successfully.",
                });
            }
            else if (serverEvent.IsDebug)
            {
                Console.WriteLine($"Debug: {serverEvent.Debug?.Message}");
            }
        }

        //// Hang up the call.
        await realtimeClient.SendHangUpAsync(new HangUpPayload
        {
            Message = "Goodbye!",
        });

        receivedCallStarted.Should().BeTrue();
        receivedTranscript.Should().BeTrue();
    }
}
