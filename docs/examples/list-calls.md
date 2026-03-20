# List Calls



This example assumes `using Ultravox;` is in scope and `apiKey` contains your Ultravox API key.

```csharp
using var client = new UltravoxClient(apiKey);

PaginatedCallList calls = await client.Calls.CallsListAsync();

foreach (var call in calls.Results)
{
    Console.WriteLine($"Call ID: {call.CallId}");
    Console.WriteLine($"  Created: {call.Created}");
    Console.WriteLine($"  Ended: {call.Ended}");
    Console.WriteLine();
}
```