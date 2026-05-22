using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetPlacesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "address": "123 Main St",
                  "cameraRecordingModeType": "inherit",
                  "createdAtTime": "2019-06-13T19:08:25.000Z",
                  "geofence": [
                    {
                      "latitude": 37.7749,
                      "longitude": -122.4194
                    }
                  ],
                  "hubLocations": [
                    {
                      "displayName": "North entrance",
                      "externalId": "store-A",
                      "hubId": "550e8400-e29b-41d4-a716-446655440003",
                      "hubLocationId": "550e8400-e29b-41d4-a716-446655440002",
                      "isDepot": false,
                      "isIgnoreOrderServiceTimeEnabled": false,
                      "locationPositionType": "first",
                      "locationPriority": 3,
                      "orderServiceTime": {
                        "capacityServiceTimes": [
                          {
                            "capacityId": "550e8400-e29b-41d4-a716-446655440001",
                            "serviceTimeSeconds": 60,
                            "serviceTimeSecondsPerQuantityUnit": 0.5
                          }
                        ],
                        "fixedTimeSeconds": 120,
                        "modeType": "variable"
                      },
                      "plannerNotes": "Zone A preferred",
                      "requiredSkills": [
                        {
                          "id": "550e8400-e29b-41d4-a716-446655440000"
                        }
                      ],
                      "serviceTime": {
                        "additionalTimeMinutes": 5,
                        "isEnabled": true
                      },
                      "serviceWindows": [
                        {
                          "days": [
                            "Illum neque vitae assumenda perferendis.",
                            "Quo maiores minus.",
                            "Non ducimus eligendi in."
                          ],
                          "endTime": 57961,
                          "startTime": 57600
                        }
                      ],
                      "standardDriverInstructions": "Use lane 2"
                    }
                  ],
                  "id": "12345",
                  "iftaExemptionTypes": [
                    "Optio rerum.",
                    "Occaecati accusantium quia ea consequatur voluptas assumenda."
                  ],
                  "isAutoDismissRolledStopsEnabled": false,
                  "isShowAddressesEnabled": true,
                  "latitude": 37.7749,
                  "longitude": -122.4194,
                  "name": "Oakland Yard",
                  "navigation": {
                    "locations": [
                      {
                        "driverInstructions": "Check in at booth.",
                        "latitude": 37.7749,
                        "locationType": "entrance",
                        "longitude": -122.4194,
                        "name": "Main gate"
                      }
                    ]
                  },
                  "notes": "Receiving 6-2",
                  "placeTypes": [
                    "Possimus fugiat.",
                    "Veritatis repudiandae doloribus eos sunt blanditiis et."
                  ],
                  "radiusMeters": 150,
                  "safetyEventExclusions": [
                    "Deleniti in nihil ad odio aut.",
                    "Et quasi mollitia.",
                    "Ad rerum."
                  ],
                  "streetView": {
                    "heading": 90,
                    "isEnabled": true,
                    "latitude": 37.7749,
                    "longitude": -122.4194,
                    "pitch": 0,
                    "zoom": 1
                  },
                  "tags": [
                    {
                      "id": "1001",
                      "name": "Yard",
                      "parentTagId": "500"
                    }
                  ],
                  "updatedAtTime": "2019-06-13T19:08:25.000Z"
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/places").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetPlacesAsync(new GetPlacesRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
