using NUnit.Framework;
using Samsara.Net.Hubs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Hubs;

[TestFixture]
public class ListHubSkillsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAt": "2024-01-15T10:30:00.000Z",
                  "hubId": "650e8400-e29b-41d4-a716-446655440001",
                  "id": "750e8400-e29b-41d4-a716-446655440004",
                  "name": "Hazmat Certified",
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
                    .WithPath("/hub/skills")
                    .WithParam("hubId", "hubId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Hubs.ListHubSkillsAsync(
            new ListHubSkillsRequest { HubId = "hubId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
