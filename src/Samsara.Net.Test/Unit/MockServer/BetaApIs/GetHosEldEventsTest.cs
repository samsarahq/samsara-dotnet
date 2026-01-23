using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetHosEldEventsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "driverActivationStatus": "active",
                  "eldEvents": [
                    {
                      "accumulatedVehicleMeters": 106,
                      "elapsedEngineHours": 284.1,
                      "eldEventCode": 3,
                      "eldEventRecordOrigin": 2,
                      "eldEventRecordStatus": 2,
                      "eldEventType": 6,
                      "remark": {
                        "comment": "Pre-Trip Inspection",
                        "locationDescription": "Near San Francisco",
                        "time": "2019-06-13T19:08:25.000Z"
                      },
                      "time": "2019-06-13T19:08:25.000Z",
                      "totalEngineHours": 2894.1,
                      "totalVehicleMeters": 1004566
                    }
                  ],
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "494123",
                  "name": "Joe Driver"
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
                    .WithPath("/beta/fleet/hos/drivers/eld-events")
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

        var response = await Client.BetaApIs.GetHosEldEventsAsync(
            new GetHosEldEventsRequest { StartTime = "startTime", EndTime = "endTime" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<HosEldEventsGetHosEldEventsResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
