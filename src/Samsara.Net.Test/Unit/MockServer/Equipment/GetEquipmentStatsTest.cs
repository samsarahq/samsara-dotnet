using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Equipment;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Equipment;

[TestFixture]
public class GetEquipmentStatsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "engineRpm": {
                    "time": "time",
                    "value": 1000000
                  },
                  "engineSeconds": {
                    "time": "time",
                    "value": 1000000
                  },
                  "engineState": {
                    "time": "time",
                    "value": "Off"
                  },
                  "engineTotalIdleTimeMinutes": {
                    "time": "time",
                    "value": 1000000
                  },
                  "fuelPercent": {
                    "time": "time",
                    "value": 1000000
                  },
                  "gatewayEngineSeconds": {
                    "time": "time",
                    "value": 1000000
                  },
                  "gatewayEngineState": {
                    "time": "time",
                    "value": "Off"
                  },
                  "gps": {
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
                  "gpsOdometerMeters": {
                    "time": "time",
                    "value": 1000000
                  },
                  "id": "id",
                  "name": "name",
                  "obdEngineSeconds": {
                    "time": "time",
                    "value": 1000000
                  },
                  "obdEngineState": {
                    "time": "time",
                    "value": "Off"
                  }
                },
                {
                  "engineRpm": {
                    "time": "time",
                    "value": 1000000
                  },
                  "engineSeconds": {
                    "time": "time",
                    "value": 1000000
                  },
                  "engineState": {
                    "time": "time",
                    "value": "Off"
                  },
                  "engineTotalIdleTimeMinutes": {
                    "time": "time",
                    "value": 1000000
                  },
                  "fuelPercent": {
                    "time": "time",
                    "value": 1000000
                  },
                  "gatewayEngineSeconds": {
                    "time": "time",
                    "value": 1000000
                  },
                  "gatewayEngineState": {
                    "time": "time",
                    "value": "Off"
                  },
                  "gps": {
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
                  "gpsOdometerMeters": {
                    "time": "time",
                    "value": 1000000
                  },
                  "id": "id",
                  "name": "name",
                  "obdEngineSeconds": {
                    "time": "time",
                    "value": 1000000
                  },
                  "obdEngineState": {
                    "time": "time",
                    "value": "Off"
                  }
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
                    .WithPath("/fleet/equipment/stats")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Equipment.GetEquipmentStatsAsync(
            new GetEquipmentStatsRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<EquipmentStatsResponse>(mockResponse)).UsingDefaults()
        );
    }
}
