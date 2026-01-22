using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Hubs;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Hubs;

[TestFixture]
public class ListHubsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAt": "2024-01-15T10:30:00.000Z",
                  "id": "550e8400-e29b-41d4-a716-446655440000",
                  "name": "West Coast Distribution Center",
                  "timeZone": "America/Los_Angeles",
                  "updatedAt": "2024-01-15T10:30:00.000Z"
                }
              ],
              "pagination": {
                "endCursor": "YXJyYXljb25uZWN0aW9uOjEwMA==",
                "hasNextPage": false
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/hubs").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Hubs.ListHubsAsync(new ListHubsRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<HubsListHubsResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
