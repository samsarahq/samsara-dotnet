using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListUpcomingPreventiveMaintenanceTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "asset": {
                    "id": "281474976710656"
                  },
                  "currentEngineHours": 12345,
                  "currentOdometer": 12345,
                  "dueInDays": 12345,
                  "dueInEngineHours": 12345,
                  "dueInOdometer": 12345,
                  "lastResolvedAt": "2019-06-13T19:08:25Z",
                  "lastResolvedAtEngineHours": 12345,
                  "lastResolvedAtOdometer": 12345,
                  "nextEngineHours": 12345,
                  "nextOdometer": 12345,
                  "nextTime": "2019-06-13T19:08:25Z",
                  "preventativeMaintenanceSchedule": {
                    "id": "281474976710656"
                  },
                  "status": "12345",
                  "workOrder": {
                    "id": "281474976710656"
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
                    .WithPath("/maintenance/preventive/upcoming")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListUpcomingPreventiveMaintenanceAsync(
            new ListUpcomingPreventiveMaintenanceRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
