```csharp
using var client = new UltravoxClient(apiKey);

PaginatedVoiceList list = await client.Voices.VoicesListAsync();

foreach (Voice voice in list.Results)
{
    Console.WriteLine($"{voice.Name} - {voice.Description}");
}
```