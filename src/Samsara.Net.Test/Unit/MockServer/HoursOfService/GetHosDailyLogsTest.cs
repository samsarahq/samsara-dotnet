using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.HoursOfService;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.HoursOfService;

[TestFixture]
public class GetHosDailyLogsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "distanceTraveled": {
                    "driveDistanceMeters": 796625,
                    "personalConveyanceDistanceMeters": 27358,
                    "yardMoveDistanceMeters": 1287
                  },
                  "driver": {
                    "id": "45646",
                    "name": "Driver Bob",
                    "timezone": "America/Los_Angeles"
                  },
                  "dutyStatusDurations": {
                    "activeDurationMs": 38825000,
                    "driveDurationMs": 31970000,
                    "offDutyDurationMs": 20555000,
                    "onDutyDurationMs": 5423000,
                    "personalConveyanceDurationMs": 4358000,
                    "sleeperBerthDurationMs": 27020000,
                    "waitingTimeDurationMs": 1560000,
                    "yardMoveDurationMs": 1432000
                  },
                  "endTime": "2019-06-20T19:08:25.000Z",
                  "logMetaData": {
                    "adverseDrivingClaimed": false,
                    "bigDayClaimed": true,
                    "carrierFormattedAddress": "1990 Alameda Street, San Francisco, CA 94103",
                    "carrierName": "Carrier Name",
                    "carrierUsDotNumber": 1234,
                    "certifiedAtTime": "2020-01-01T06:00:00.000Z",
                    "homeTerminalFormattedAddress": "1990 Alameda Street, San Francisco, CA 94103",
                    "homeTerminalName": "Home Terminal Name",
                    "isCertified": false,
                    "isUsShortHaulActive": false,
                    "shippingDocs": "Delivery 123, chips and soda",
                    "trailerNames": [
                      "10293",
                      "Trailer ID 1"
                    ]
                  },
                  "pendingDutyStatusDurations": {
                    "activeDurationMs": 38825000,
                    "driveDurationMs": 31970000,
                    "offDutyDurationMs": 20555000,
                    "onDutyDurationMs": 5423000,
                    "personalConveyanceDurationMs": 4358000,
                    "sleeperBerthDurationMs": 27020000,
                    "waitingTimeDurationMs": 1560000,
                    "yardMoveDurationMs": 1432000
                  },
                  "startTime": "2019-06-13T19:08:25.000Z"
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
                    .WithPath("/fleet/hos/daily-logs")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.HoursOfService.GetHosDailyLogsAsync(
            new GetHosDailyLogsRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<HosDailyLogsGetHosDailyLogsResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
