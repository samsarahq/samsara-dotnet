using NUnit.Framework;
using Samsara.Net.Assets;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Assets;

[TestFixture]
public class V1GetAssetsReefersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "assetType": "Thermo King",
                  "id": 1,
                  "name": "Reefer 123",
                  "reeferStats": {
                    "ambientAirTemperature": [
                      {
                        "changedAtMs": 1453449599999,
                        "tempInMilliC": 31110
                      }
                    ],
                    "dischargeAirTemperature": [
                      {
                        "changedAtMs": 1453449599999,
                        "tempInMilliC": 31110
                      }
                    ],
                    "engineHours": [
                      {
                        "changedAtMs": 1453449599999,
                        "engineHours": 1200
                      }
                    ],
                    "fuelPercentage": [
                      {
                        "changedAtMs": 1453449599999,
                        "fuelPercentage": 99
                      }
                    ],
                    "powerStatus": [
                      {
                        "changedAtMs": 1453449599999
                      }
                    ],
                    "reeferAlarms": [
                      {
                        "alarms": [
                          {
                            "alarmCode": 102,
                            "description": "Check Return Air Sensor",
                            "operatorAction": "Check and repair at end of trip",
                            "severity": 1
                          }
                        ],
                        "changedAtMs": 1453449599999
                      }
                    ],
                    "returnAirTemperature": [
                      {
                        "changedAtMs": 1453449599999,
                        "tempInMilliC": 31110
                      }
                    ],
                    "setPoint": [
                      {
                        "changedAtMs": 1453449599999,
                        "tempInMilliC": 31110
                      }
                    ]
                  }
                }
              ],
              "pagination": {
                "endCursor": "MTU5MTEzNjA2OTU0MzQ3",
                "hasNextPage": true,
                "hasPrevPage": true,
                "startCursor": "MTU5MTEzNjA2OTU0MzQ3"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/assets/reefers")
                    .WithParam("startMs", "1000000")
                    .WithParam("endMs", "1000000")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Assets.V1GetAssetsReefersAsync(
            new V1GetAssetsReefersRequest { StartMs = 1000000, EndMs = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
