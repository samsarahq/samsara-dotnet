using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.LegacyApIs;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.LegacyApIs;

[TestFixture]
public class GetVehicleIdlingReportsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "address": {
                    "formatted": "123 Main Street Atlanta, GA 30307",
                    "latitude": 34.654567,
                    "longitude": 34.654567
                  },
                  "durationMs": 860000,
                  "endTime": "2019-06-13T19:08:25.000Z",
                  "fuelConsumptionMl": 2500,
                  "isPtoActive": false,
                  "startTime": "2019-06-13T19:08:25.000Z",
                  "vehicle": {
                    "id": "494123",
                    "name": "Fleet Truck #1"
                  }
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              },
              "requestEndTime": "2019-06-13T19:08:25.000Z",
              "requestStartTime": "2019-06-13T19:08:25.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/reports/vehicle/idling")
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

        var response = await Client.LegacyApIs.GetVehicleIdlingReportsAsync(
            new GetVehicleIdlingReportsRequest { StartTime = "startTime", EndTime = "endTime" }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<IdlingReportsGetVehicleIdlingReportsResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
