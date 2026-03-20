# List Models



This example assumes `using Ultravox;` is in scope and `apiKey` contains your Ultravox API key.

```csharp
using var client = new UltravoxClient(apiKey);

PaginatedModelAliasList models = await client.Models.ModelsListAsync();

foreach (var model in models.Results)
{
    Console.WriteLine($"Model: {model.Name}");
}
```