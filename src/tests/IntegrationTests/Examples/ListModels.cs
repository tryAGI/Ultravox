/*
order: 40
title: List Models
slug: list-models
*/

namespace Ultravox.IntegrationTests;

public partial class Tests
{
    //// Retrieve the list of available voice AI models in the Ultravox platform.

    [TestMethod]
    public async Task Example_ListModels()
    {
        using var client = GetAuthenticatedClient();

        PaginatedModelAliasList models = await client.Models.ModelsListAsync();

        models.Should().NotBeNull();

        foreach (var model in models.Results)
        {
            Console.WriteLine($"Model: {model.Name}");
        }
    }
}
