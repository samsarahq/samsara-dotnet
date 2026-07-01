using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class CreateHubRouteTemplateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "hubId": "550e8400-e29b-41d4-a716-446655440000",
              "name": "Downtown Delivery Route"
            }
            """;

        const string mockResponse = """
            {
              "data": {
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
                "defaultStartTimeOfDay": "08:00",
                "distanceMeters": 15000,
                "durationSeconds": 3600,
                "hubId": "550e8400-e29b-41d4-a716-446655440000",
                "id": "660e8400-e29b-41d4-a716-446655440001",
                "locations": [
                  {
                    "externalId": "LOC-123",
                    "formattedAddress": "456 Main St, Los Angeles, CA 90210, US",
                    "latitude": 34.0522,
                    "longitude": -118.2437,
                    "name": "Customer ABC Warehouse",
                    "position": 1
                  }
                ],
                "name": "Downtown Delivery Route",
                "updatedAtTime": "2024-01-15T12:00:00.000Z"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/hub/route-templates")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.CreateHubRouteTemplateAsync(
            new HubRouteTemplatesCreateHubRouteTemplateRequestBody
            {
                HubId = "550e8400-e29b-41d4-a716-446655440000",
                Name = "Downtown Delivery Route",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
