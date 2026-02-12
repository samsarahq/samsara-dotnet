using NUnit.Framework;
using Samsara.Net.Hubs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Hubs;

[TestFixture]
public class ListHubCapacitiesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAt": "2024-01-15T10:30:00.000Z",
                  "hubId": "550e8400-e29b-41d4-a716-446655440000",
                  "id": "850e8400-e29b-41d4-a716-446655440003",
                  "name": "Weight",
                  "unit": "kg",
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
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/hub/capacities")
                    .WithParam("hubId", "hubId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Hubs.ListHubCapacitiesAsync(
            new ListHubCapacitiesRequest { HubId = "hubId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
