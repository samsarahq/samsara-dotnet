using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.TachographEuOnly;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.TachographEuOnly;

[TestFixture]
public class GetDriverTachographActivityTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "activity": [
                    {
                      "endTime": "2020-01-03T16:04:05Z07:00",
                      "isManualEntry": false,
                      "startTime": "2020-01-02T15:04:05Z07:00"
                    }
                  ],
                  "driver": {
                    "id": "88668",
                    "name": "Susan Bob"
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
                    .WithPath("/fleet/drivers/tachograph-activity/history")
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

        var response = await Client.TachographEuOnly.GetDriverTachographActivityAsync(
            new GetDriverTachographActivityRequest { StartTime = "startTime", EndTime = "endTime" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<DriverTachographActivityResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
