/*
order: 20
title: Account Info
slug: account-info
*/

namespace Ultravox.IntegrationTests;

public partial class Tests
{
    //// Retrieve information about the current Ultravox account.

    [TestMethod]
    public async Task Example_AccountInfo()
    {
        using var client = GetAuthenticatedClient();

        Account account = await client.Accounts.AccountsMeRetrieveAsync();

        account.Should().NotBeNull();

        Console.WriteLine($"Account ID: {account.AccountId}");
        Console.WriteLine($"Name: {account.Name}");
    }
}
