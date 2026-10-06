using NUnit.Framework;
using Samsara.Net.PreventiveMaintenance;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreventiveMaintenance;

[TestFixture]
public class UpdateUpcomingPreventiveMaintenanceTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "data": {
                "asset": {
                  "id": "281474976710656"
                },
                "currentEngineHours": 4120,
                "currentOdometer": 120700800,
                "currentOdometerMiles": 75000,
                "dueInDays": 45,
                "dueInEngineHours": 130,
                "dueInOdometer": 4828032,
                "dueInOdometerMiles": 3000,
                "lastResolvedAt": "2026-05-14T09:30:00Z",
                "lastResolvedAtEngineHours": 4000,
                "lastResolvedAtOdometer": 117482112,
                "nextEngineHours": 4250,
                "nextOdometer": 125528832,
                "nextOdometerMiles": 78000,
                "nextTime": "2026-10-11T09:30:00Z",
                "priority": 45,
                "schedule": {
                  "id": "281474976710656"
                },
                "status": "unknown",
                "workOrder": {
                  "id": "281474976710656"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/preventive/upcoming")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreventiveMaintenance.UpdateUpcomingPreventiveMaintenanceAsync(
            new EntityUpcomingPreventativeMaintenancesServiceUpdateUpcomingPreventiveMaintenanceRequestBody()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
