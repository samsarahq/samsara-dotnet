using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class UpdateWatchpointTest : BaseMockServerTest
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
                "createdAtTime": "2026-07-15T10:00:00Z",
                "id": "2eb0e68c-d728-4d2f-b9a0-8bc6ded86422",
                "lastObservationTime": "2019-06-13T19:08:25Z",
                "location": {
                  "latitude": 37.7749,
                  "longitude": -122.4194
                },
                "mode": "unknown",
                "monitoringEndTime": "2026-08-14T10:00:00Z",
                "monitoringStartTime": "2026-07-15T10:00:00Z",
                "name": "Market Street watchpoint",
                "note": "Monitor the intersection for road defects.",
                "observationCount": 1,
                "observationType": "unknown",
                "samsaraDashboardUrl": "https://cloud.samsara.com/o/123456/fleet/ground-intelligence?tab=monitors&monitorId=2eb0e68c-d728-4d2f-b9a0-8bc6ded86422",
                "status": "unknown",
                "updatedAtTime": "2026-07-15T10:00:01Z"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/ground-intelligence/watchpoints")
                    .WithParam("id", "id")
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

        var response = await Client.BetaApIs.UpdateWatchpointAsync(
            new EntityWatchpointsServiceUpdateWatchpointRequestBody { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
