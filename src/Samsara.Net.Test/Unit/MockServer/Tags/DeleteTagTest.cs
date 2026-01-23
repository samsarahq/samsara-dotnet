using NUnit.Framework;
using Samsara.Net.Core;
using Samsara.Net.Tags;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Tags;

[TestFixture]
public class DeleteTagTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            ""
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/tags/id").UsingDelete())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Tags.DeleteTagAsync(new DeleteTagRequest { Id = "id" });
        Assert.That(response, Is.EqualTo(JsonUtils.Deserialize<string>(mockResponse)));
    }
}
