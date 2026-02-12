using NUnit.Framework;
using Samsara.Net.Routes;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Routes;

[TestFixture]
public class ListHubPlanRoutesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "cost": 125.5,
                  "createdAt": "2024-04-10T10:30:00.000Z",
                  "dispatchRouteId": "123456",
                  "distanceMeters": 15420,
                  "durationSeconds": 3600,
                  "hubId": "550e8400-e29b-41d4-a716-446655440000",
                  "id": "950e8400-e29b-41d4-a716-446655440005",
                  "isEdited": false,
                  "isPinned": false,
                  "name": "Route 1",
                  "orgLocationTimezone": "America/Los_Angeles",
                  "planId": "850e8400-e29b-41d4-a716-446655440003",
                  "quantities": [
                    {
                      "capacityId": "f1e2d3c4-b5a6-9870-fedc-ba0987654321",
                      "quantity": 750
                    }
                  ],
                  "scheduledRouteEndTime": "2019-06-13T19:08:25.000Z",
                  "scheduledRouteStartTime": "2024-04-10T08:00:00.000Z",
                  "stops": [
                    {
                      "hubLocationId": "d4e5f6a7-b8c9-0123-defa-456789012345",
                      "id": "c3d4e5f6-a7b8-9012-cdef-345678901234",
                      "name": "Stop 1",
                      "notes": "",
                      "orders": [
                        {
                          "customProperties": [
                            {
                              "id": "b2c3d4e5-f6a7-8901-bcde-f23456789012",
                              "name": "CustomerType",
                              "value": "Premium"
                            }
                          ],
                          "id": "e5f6a7b8-c9d0-1234-efab-567890123456",
                          "quantities": [
                            {
                              "capacityId": "f1e2d3c4-b5a6-9870-fedc-ba0987654321",
                              "quantity": 750
                            }
                          ],
                          "requiredSkills": [
                            {
                              "id": "a1b2c3d4-e5f6-7890-abcd-ef1234567890",
                              "name": "Forklift Operation"
                            }
                          ],
                          "serviceWindow": "9:00AM - 5:00PM",
                          "type": "pickup"
                        }
                      ],
                      "scheduledArrivalTime": "2024-04-10T09:00:00.000Z",
                      "scheduledDepartureTime": "2024-04-10T09:30:00.000Z",
                      "singleUseLocation": {
                        "address": "1234 Main St, San Jose, CA",
                        "latitude": 123.456,
                        "longitude": 37.459
                      }
                    }
                  ],
                  "type": "dynamic",
                  "updatedAt": "2024-04-10T10:30:00.000Z"
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
                    .WithPath("/hub/plan/routes")
                    .WithParam("planId", "planId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Routes.ListHubPlanRoutesAsync(
            new ListHubPlanRoutesRequest { PlanId = "planId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
