using NUnit.Framework;
using Samsara.Net.Equipment;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Equipment;

[TestFixture]
public class GetEquipmentStatsHistoryTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "engineRpm": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "engineSeconds": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "engineStates": [
                    {
                      "time": "time",
                      "value": "Off"
                    },
                    {
                      "time": "time",
                      "value": "Off"
                    }
                  ],
                  "engineTotalIdleTimeMinutes": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "fuelPercents": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "gatewayEngineSeconds": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "gatewayEngineStates": [
                    {
                      "time": "time",
                      "value": "Off"
                    },
                    {
                      "time": "time",
                      "value": "Off"
                    }
                  ],
                  "gatewayJ1939EngineSeconds": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "gps": [
                    {
                      "address": {
                        "id": "id",
                        "name": "name"
                      },
                      "headingDegrees": 1.1,
                      "latitude": 1.1,
                      "longitude": 1.1,
                      "reverseGeo": {
                        "formattedLocation": "formattedLocation"
                      },
                      "speedMilesPerHour": 1.1,
                      "time": "time"
                    },
                    {
                      "address": {
                        "id": "id",
                        "name": "name"
                      },
                      "headingDegrees": 1.1,
                      "latitude": 1.1,
                      "longitude": 1.1,
                      "reverseGeo": {
                        "formattedLocation": "formattedLocation"
                      },
                      "speedMilesPerHour": 1.1,
                      "time": "time"
                    }
                  ],
                  "gpsOdometerMeters": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "id": "id",
                  "name": "name",
                  "obdEngineSeconds": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "obdEngineStates": [
                    {
                      "time": "time",
                      "value": "Off"
                    },
                    {
                      "time": "time",
                      "value": "Off"
                    }
                  ]
                },
                {
                  "engineRpm": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "engineSeconds": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "engineStates": [
                    {
                      "time": "time",
                      "value": "Off"
                    },
                    {
                      "time": "time",
                      "value": "Off"
                    }
                  ],
                  "engineTotalIdleTimeMinutes": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "fuelPercents": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "gatewayEngineSeconds": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "gatewayEngineStates": [
                    {
                      "time": "time",
                      "value": "Off"
                    },
                    {
                      "time": "time",
                      "value": "Off"
                    }
                  ],
                  "gatewayJ1939EngineSeconds": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "gps": [
                    {
                      "address": {
                        "id": "id",
                        "name": "name"
                      },
                      "headingDegrees": 1.1,
                      "latitude": 1.1,
                      "longitude": 1.1,
                      "reverseGeo": {
                        "formattedLocation": "formattedLocation"
                      },
                      "speedMilesPerHour": 1.1,
                      "time": "time"
                    },
                    {
                      "address": {
                        "id": "id",
                        "name": "name"
                      },
                      "headingDegrees": 1.1,
                      "latitude": 1.1,
                      "longitude": 1.1,
                      "reverseGeo": {
                        "formattedLocation": "formattedLocation"
                      },
                      "speedMilesPerHour": 1.1,
                      "time": "time"
                    }
                  ],
                  "gpsOdometerMeters": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "id": "id",
                  "name": "name",
                  "obdEngineSeconds": [
                    {
                      "time": "time",
                      "value": 1000000
                    },
                    {
                      "time": "time",
                      "value": 1000000
                    }
                  ],
                  "obdEngineStates": [
                    {
                      "time": "time",
                      "value": "Off"
                    },
                    {
                      "time": "time",
                      "value": "Off"
                    }
                  ]
                }
              ],
              "pagination": {
                "endCursor": "endCursor",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/equipment/stats/history")
                    .WithParam("startTime", "startTime")
                    .WithParam("endTime", "endTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Equipment.GetEquipmentStatsHistoryAsync(
            new GetEquipmentStatsHistoryRequest { StartTime = "startTime", EndTime = "endTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
