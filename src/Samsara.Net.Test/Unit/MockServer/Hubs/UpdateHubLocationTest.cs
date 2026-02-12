using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Hubs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Hubs;

[TestFixture]
public class UpdateHubLocationTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "data": {
                "address": "123 Industrial Blvd, Los Angeles, CA 90210, US",
                "customerLocationId": "LOC-123",
                "driverInstructions": "sample instructions",
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
                      "tuesday",
                      "wednesday",
                      "thursday",
                      "friday"
                    ],
                    "endTime": "17:00:00",
                    "startTime": "08:00:00"
                  }
                ],
                "skillsRequired": [
                  "650e8400-e29b-41d4-a716-446655440001"
                ]
              }
            }
            """;

        const string mockResponse = """
            {
              "data": {
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/hub/location/id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Hubs.UpdateHubLocationAsync(
            "id",
            new HubLocationsUpdateHubLocationRequestBody
            {
                Data = new UpdateHubLocationRequestBodyRequestBody
                {
                    Address = "123 Industrial Blvd, Los Angeles, CA 90210, US",
                    CustomerLocationId = "LOC-123",
                    DriverInstructions = "sample instructions",
                    IsDepot = false,
                    Latitude = 34.0522,
                    Longitude = -118.2437,
                    Name = "Customer ABC Warehouse",
                    PlannerNotes = "sample note",
                    ServiceTimeSeconds = 1800,
                    ServiceWindows = new List<HubLocationServiceWindowInputRequestBody>()
                    {
                        new HubLocationServiceWindowInputRequestBody
                        {
                            DaysOfWeek = new List<string>()
                            {
                                "monday",
                                "tuesday",
                                "wednesday",
                                "thursday",
                                "friday",
                            },
                            EndTime = "17:00:00",
                            StartTime = "08:00:00",
                        },
                    },
                    SkillsRequired = new List<string>() { "650e8400-e29b-41d4-a716-446655440001" },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
