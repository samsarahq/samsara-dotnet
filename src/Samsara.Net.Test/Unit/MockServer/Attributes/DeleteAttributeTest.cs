using NUnit.Framework;
using Samsara.Net.Attributes;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Attributes;

[TestFixture]
public class DeleteAttributeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            ""
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/attributes/id")
                    .WithParam("entityType", "driver")
                    .UsingDelete()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Attributes.DeleteAttributeAsync(
            new DeleteAttributeRequest
            {
                Id = "id",
                EntityType = DeleteAttributeRequestEntityType.Driver,
            }
        );
        Assert.That(response, Is.EqualTo(JsonUtils.Deserialize<string>(mockResponse)));
    }
}
