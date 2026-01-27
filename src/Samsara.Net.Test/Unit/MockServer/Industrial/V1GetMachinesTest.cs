using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Industrial;

[TestFixture]
public class V1GetMachinesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "machines": [
                {
                  "id": 123,
                  "name": "Freezer ABC",
                  "notes": "This is in the left hallway behind the conveyor belt"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/v1/machines/list").UsingPost()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Industrial.V1GetMachinesAsync();
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<InlineResponse2008>(mockResponse)).UsingDefaults()
        );
    }
}
