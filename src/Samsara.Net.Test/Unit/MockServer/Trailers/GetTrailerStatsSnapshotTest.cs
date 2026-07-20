using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;
using Samsara.Net.Trailers;

namespace Samsara.Net.Test.Unit.MockServer.Trailers;

[TestFixture]
public class GetTrailerStatsSnapshotTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "carrierReeferState": {
                    "substateValue": "`Pretrip`, `Defrost`",
                    "time": "2020-01-27T07:06:25Z",
                    "value": "`Off`, `On`"
                  },
                  "externalIds": {
                    "key": "value"
                  },
                  "gps": {
                    "headingDegrees": 1348357598549803500,
                    "latitude": 0.3208945264214625,
                    "longitude": 0.8332374583113843,
                    "speedMilesPerHour": 6002318122880536000,
                    "time": "2020-01-27T07:06:25Z"
                  },
                  "gpsOdometerMeters": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": 50
                  },
                  "id": "1234",
                  "name": "Trailer-123",
                  "reeferAlarms": {
                    "alarms": [
                      {
                        "alarmCode": "3",
                        "description": "Test alarm",
                        "operatorAction": "Manually disable alarm",
                        "severity": 4445609573684309000
                      }
                    ],
                    "time": "2020-01-27T07:06:25Z"
                  },
                  "reeferAmbientAirTemperatureMilliC": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": 50
                  },
                  "reeferDoorStateZone1": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": "open"
                  },
                  "reeferDoorStateZone2": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": "open"
                  },
                  "reeferDoorStateZone3": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": "open"
                  },
                  "reeferFuelPercent": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": 50
                  },
                  "reeferObdEngineSeconds": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": 50
                  },
                  "reeferReturnAirTemperatureMilliCZone1": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": 50
                  },
                  "reeferReturnAirTemperatureMilliCZone2": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": 50
                  },
                  "reeferReturnAirTemperatureMilliCZone3": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": 50
                  },
                  "reeferRunMode": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": "`Start/Stop`,`Continuous`"
                  },
                  "reeferSetPointTemperatureMilliCZone1": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": 50
                  },
                  "reeferSetPointTemperatureMilliCZone2": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": 50
                  },
                  "reeferSetPointTemperatureMilliCZone3": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": 50
                  },
                  "reeferStateZone1": {
                    "substateValue": "`Pretrip`, `Defrost`",
                    "time": "2020-01-27T07:06:25Z",
                    "value": "`Off`, `On`"
                  },
                  "reeferStateZone2": {
                    "substateValue": "`Pretrip`, `Defrost`",
                    "time": "2020-01-27T07:06:25Z",
                    "value": "`Off`, `On`"
                  },
                  "reeferStateZone3": {
                    "substateValue": "`Pretrip`, `Defrost`",
                    "time": "2020-01-27T07:06:25Z",
                    "value": "`Off`, `On`"
                  },
                  "reeferSupplyAirTemperatureMilliCZone1": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": 50
                  },
                  "reeferSupplyAirTemperatureMilliCZone2": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": 50
                  },
                  "reeferSupplyAirTemperatureMilliCZone3": {
                    "time": "2020-01-27T07:06:25Z",
                    "value": 50
                  }
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
                    .WithPath("/fleet/trailers/stats")
                    .WithParam("types", "types")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Trailers.GetTrailerStatsSnapshotAsync(
            new GetTrailerStatsSnapshotRequest { Types = "types" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
