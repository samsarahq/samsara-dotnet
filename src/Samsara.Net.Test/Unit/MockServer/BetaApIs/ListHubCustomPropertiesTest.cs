using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListHubCustomPropertiesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAt": "2024-01-15T10:30:00.000Z",
                  "csvColumns": "customer_type,customerType",
                  "hubId": "650e8400-e29b-41d4-a716-446655440001",
                  "id": "750e8400-e29b-41d4-a716-446655440004",
                  "name": "CustomerType",
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
                    .WithPath("/hub/customProperties")
                    .WithParam("hubId", "hubId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListHubCustomPropertiesAsync(
            new ListHubCustomPropertiesRequest { HubId = "hubId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
