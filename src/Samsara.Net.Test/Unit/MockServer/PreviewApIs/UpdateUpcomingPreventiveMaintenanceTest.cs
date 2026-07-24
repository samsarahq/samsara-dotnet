using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

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
                "currentEngineHours": 12345,
                "currentOdometer": 12345,
                "currentOdometerMiles": 12345,
                "dueInDays": 12345,
                "dueInEngineHours": 12345,
                "dueInOdometer": 12345,
                "dueInOdometerMiles": 12345,
                "lastResolvedAt": "2019-06-13T19:08:25Z",
                "lastResolvedAtEngineHours": 12345,
                "lastResolvedAtOdometer": 12345,
                "nextEngineHours": 12345,
                "nextOdometer": 12345,
                "nextOdometerMiles": 12345,
                "nextTime": "2019-06-13T19:08:25Z",
                "priority": 12345,
                "schedule": {
                  "id": "281474976710656"
                },
                "status": "12345",
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
                    .WithPath("/preview/maintenance/preventive/upcoming")
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

        var response = await Client.PreviewApIs.UpdateUpcomingPreventiveMaintenanceAsync(
            new EntityUpcomingPreventativeMaintenancesServiceUpdateUpcomingPreventiveMaintenanceRequestBody()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
