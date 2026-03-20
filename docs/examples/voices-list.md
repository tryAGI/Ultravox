# Voices List



This example assumes `using Ultravox;` is in scope and `apiKey` contains your Ultravox API key.

```csharp
using var client = new UltravoxClient(apiKey);

PaginatedVoiceList list = await client.Voices.VoicesListAsync();

foreach (Voice voice in list.Results)
{
    Console.WriteLine($"{voice.Name} - {voice.Description}");
}
```