using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class PostPlaceTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "address": "123 Main St, Oakland, CA",
              "geofence": {},
              "name": "Oakland Yard"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "address": "123 Main St",
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
                  "Error voluptate.",
                  "Doloribus velit.",
                  "Repellat placeat sit."
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
                  "Voluptatem sequi maiores quidem sunt laborum voluptas.",
                  "Quasi debitis dignissimos quibusdam.",
                  "Quae aspernatur beatae cum sint cum corrupti.",
                  "Iusto aut molestias alias dolores doloribus."
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
                        "quantityUnitPerServiceTime": 0.5,
                        "serviceTimeSeconds": 60
                      },
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
                          "Sed dolorum hic.",
                          "Itaque assumenda possimus placeat.",
                          "Excepturi ratione facilis.",
                          "Officia autem id natus."
                        ],
                        "endTime": "17:00:01",
                        "startTime": "09:00:00"
                      }
                    ]
                  }
                ],
                "safetyEventExclusions": [
                  "Rerum atque et corrupti.",
                  "Distinctio aspernatur.",
                  "Dolorum omnis qui consequatur odio."
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/places")
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

        var response = await Client.BetaApIs.PostPlaceAsync(
            new PlacesPostPlaceRequestBody
            {
                Address = "123 Main St, Oakland, CA",
                Geofence = new PlaceGeofenceInputRequestBody(),
                Name = "Oakland Yard",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
