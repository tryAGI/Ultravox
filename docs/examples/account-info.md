# Account Info



This example assumes `using Ultravox;` is in scope and `apiKey` contains your Ultravox API key.

```csharp
using var client = new UltravoxClient(apiKey);

Account account = await client.Accounts.AccountsMeRetrieveAsync();

Console.WriteLine($"Account ID: {account.AccountId}");
Console.WriteLine($"Name: {account.Name}");
```