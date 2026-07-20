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
                  "businessContacts": {
                    "email": [
                      "warehouse@example.com"
                    ],
                    "phoneNumbers": [
                      "+14155551234"
                    ]
                  },
                  "cameraRecordingModeType": "inherit",
                  "createdAtTime": "2019-06-13T19:08:25.000Z",
                  "geofence": {
                    "circle": {
                      "latitude": 37.7749,
                      "longitude": -122.4194,
                      "radiusMeters": 150
                    },
                    "polygon": {
                      "vertices": [
                        {
                          "latitude": 37.7749,
                          "longitude": -122.4194
                        }
                      ]
                    },
                    "type": "circle"
                  },
                  "id": "12345",
                  "iftaExemptionTypes": [
                    "Dolores architecto velit dolorem.",
                    "Blanditiis deserunt velit voluptatem atque deserunt.",
                    "Sed veniam magnam molestiae."
                  ],
                  "isAutoDismissRolledStopsEnabled": false,
                  "isShowAddressesEnabled": true,
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
                    "Quia eos.",
                    "In adipisci sunt.",
                    "Explicabo amet eum exercitationem dignissimos quaerat debitis.",
                    "Dolorem quo enim voluptas saepe."
                  ],
                  "routing": [
                    {
                      "driverInstructions": "Use lane 2",
                      "hubId": "550e8400-e29b-41d4-a716-446655440003",
                      "hubNotes": "Zone A preferred",
                      "isDepot": false,
                      "orderServiceTime": {
                        "capacityServiceTime": {
                          "capacityId": "550e8400-e29b-41d4-a716-446655440001",
                          "quantityPerServiceTime": 0.5,
                          "serviceTimeSeconds": 60
                        },
                        "fixedServiceTimeSeconds": 300,
                        "isEnabled": true,
                        "modeType": "variable"
                      },
                      "position": "first",
                      "priority": 3,
                      "requiredSkills": [
                        {
                          "id": "550e8400-e29b-41d4-a716-446655440000",
                          "name": "Refrigerated"
                        }
                      ],
                      "routingExternalId": "store-A",
                      "serviceTime": {
                        "isEnabled": true,
                        "serviceTimeMinutes": 5
                      },
                      "serviceWindows": [
                        {
                          "days": [
                            "Ut sed.",
                            "Est quo quidem quae.",
                            "Ut voluptas et accusantium est labore.",
                            "Magni sint quia."
                          ],
                          "endTime": "17:00:01",
                          "startTime": "09:00:00"
                        }
                      ]
                    }
                  ],
                  "safetyEventExclusions": [
                    "Beatae tenetur nobis ut voluptate et ut.",
                    "Id rem unde earum quia libero.",
                    "Dolor suscipit explicabo esse labore."
                  ],
                  "streetView": {
                    "headingDegrees": 90,
                    "isEnabled": true,
                    "latitude": 37.7749,
                    "longitude": -122.4194,
                    "pitchDegrees": 0,
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
