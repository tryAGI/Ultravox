namespace Ultravox.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task VoicesList()
    {
        using var client = GetAuthenticatedClient();

        PaginatedVoiceList list = await client.Voices.VoicesListAsync();

        foreach (Voice voice in list.Results)
        {
            Console.WriteLine($"{voice.Name} - {voice.Description}");
        }
    }
}
