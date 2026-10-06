using NUnit.Framework;
using Samsara.Net.PreventiveMaintenance;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreventiveMaintenance;

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
                  "currentEngineHours": 4120,
                  "currentOdometer": 120700800,
                  "dueInDays": 45,
                  "dueInEngineHours": 130,
                  "dueInOdometer": 4828032,
                  "lastResolvedAt": "2026-05-14T09:30:00Z",
                  "lastResolvedAtEngineHours": 4000,
                  "lastResolvedAtOdometer": 117482112,
                  "nextEngineHours": 4250,
                  "nextOdometer": 125528832,
                  "nextTime": "2026-10-11T09:30:00Z",
                  "schedule": {
                    "id": "281474976710656"
                  },
                  "status": "unknown",
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

        var response = await Client.PreventiveMaintenance.ListUpcomingPreventiveMaintenanceAsync(
            new ListUpcomingPreventiveMaintenanceRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
