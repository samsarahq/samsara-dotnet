using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListHubRouteTemplatesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAtTime": "2024-01-15T10:30:00.000Z",
                  "defaultDepotEnd": {
                    "externalId": "DEPOT-001",
                    "formattedAddress": "123 Industrial Blvd, Los Angeles, CA 90210, US",
                    "id": "750e8400-e29b-41d4-a716-446655440002",
                    "latitude": 34.0522,
                    "longitude": -118.2437,
                    "name": "Main Warehouse"
                  },
                  "defaultDepotStart": {
                    "externalId": "DEPOT-001",
                    "formattedAddress": "123 Industrial Blvd, Los Angeles, CA 90210, US",
                    "id": "750e8400-e29b-41d4-a716-446655440002",
                    "latitude": 34.0522,
                    "longitude": -118.2437,
                    "name": "Main Warehouse"
                  },
                  "distanceMeters": 15000,
                  "durationSeconds": 3600,
                  "earliestStartTime": "08:00",
                  "hubId": "550e8400-e29b-41d4-a716-446655440000",
                  "hubTimezone": "America/Los_Angeles",
                  "id": "660e8400-e29b-41d4-a716-446655440001",
                  "locations": [
                    {
                      "externalId": "LOC-123",
                      "formattedAddress": "456 Main St, Los Angeles, CA 90210, US",
                      "id": "850e8400-e29b-41d4-a716-446655440003",
                      "latitude": 34.0522,
                      "longitude": -118.2437,
                      "name": "Customer ABC Warehouse",
                      "position": 1
                    }
                  ],
                  "name": "Downtown Delivery Route",
                  "updatedAtTime": "2024-01-15T12:00:00.000Z"
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
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/hub/route-templates")
                    .WithParam("hubId", "hubId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListHubRouteTemplatesAsync(
            new ListHubRouteTemplatesRequest { HubId = "hubId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
