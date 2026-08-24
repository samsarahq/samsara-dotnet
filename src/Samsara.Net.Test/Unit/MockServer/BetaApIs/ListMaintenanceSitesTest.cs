using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListMaintenanceSitesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "archivedAt": "2019-06-13T19:08:25Z",
                  "createdAt": "2019-06-13T19:08:25Z",
                  "customAddress": {
                    "formattedAddress": "12345",
                    "latitude": 123.45,
                    "longitude": 123.45
                  },
                  "description": "12345",
                  "externalIds": [
                    {
                      "key": "12345",
                      "value": "12345"
                    }
                  ],
                  "id": "12345",
                  "isArchived": true,
                  "name": "12345",
                  "places": [
                    {
                      "id": "281474976710656"
                    }
                  ],
                  "siteCode": "12345",
                  "siteType": "Unknown",
                  "updatedAt": "2019-06-13T19:08:25Z"
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/maintenance/sites").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListMaintenanceSitesAsync(
            new ListMaintenanceSitesRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
