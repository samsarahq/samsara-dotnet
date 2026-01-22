using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Hubs;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Hubs;

[TestFixture]
public class ListHubLocationsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "address": "123 Industrial Blvd, Los Angeles, CA 90210, US",
                  "createdAt": "2024-01-15T10:30:00.000Z",
                  "customerLocationId": "LOC-123",
                  "driverInstructions": "sample instructions",
                  "hubId": "550e8400-e29b-41d4-a716-446655440000",
                  "id": "750e8400-e29b-41d4-a716-446655440002",
                  "isDepot": false,
                  "latitude": 34.0522,
                  "longitude": -118.2437,
                  "name": "Customer ABC Warehouse",
                  "plannerNotes": "sample note",
                  "serviceTimeSeconds": 1800,
                  "serviceWindows": [
                    {
                      "daysOfWeek": [
                        "monday",
                        "monday",
                        "monday",
                        "monday"
                      ],
                      "endTime": "17:00:00",
                      "startTime": "08:00:00"
                    }
                  ],
                  "skillsRequired": [
                    {
                      "id": "650e8400-e29b-41d4-a716-446655440001",
                      "name": "Heavy Lifting"
                    }
                  ],
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
                    .WithPath("/hub/locations")
                    .WithParam("hubId", "hubId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Hubs.ListHubLocationsAsync(
            new ListHubLocationsRequest { HubId = "hubId" }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<HubLocationsListHubLocationsResponseBody>(mockResponse)
                )
                .UsingDefaults()
        );
    }
}
