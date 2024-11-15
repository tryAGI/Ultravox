namespace Ultravox.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static UltravoxClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ULTRAVOX_API_KEY") ??
            throw new AssertInconclusiveException("ULTRAVOX_API_KEY environment variable is not found.");

        var client = new UltravoxClient(apiKey);
        
        return client;
    }
}
