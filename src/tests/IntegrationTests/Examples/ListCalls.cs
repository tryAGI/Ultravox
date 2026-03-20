/*
order: 30
title: List Calls
slug: list-calls
*/

namespace Ultravox.IntegrationTests;

public partial class Tests
{
    //// Retrieve a paginated list of voice calls made through the Ultravox platform.

    [TestMethod]
    public async Task Example_ListCalls()
    {
        using var client = GetAuthenticatedClient();

        PaginatedCallList calls = await client.Calls.CallsListAsync();

        calls.Should().NotBeNull();

        foreach (var call in calls.Results)
        {
            Console.WriteLine($"Call ID: {call.CallId}");
            Console.WriteLine($"  Created: {call.Created}");
            Console.WriteLine($"  Ended: {call.Ended}");
            Console.WriteLine();
        }
    }
}
