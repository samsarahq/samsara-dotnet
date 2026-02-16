using NUnit.Framework;
using Samsara.Net.Attributes;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Attributes;

[TestFixture]
public class DeleteTest : BaseMockServerTest
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

        var response = await Client.Attributes.DeleteAsync(
            new DeleteAttributesRequest
            {
                Id = "id",
                EntityType = DeleteAttributesRequestEntityType.Driver,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
