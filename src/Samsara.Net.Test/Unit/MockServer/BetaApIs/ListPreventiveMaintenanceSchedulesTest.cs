using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListPreventiveMaintenanceSchedulesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "dateIntervalMs": 12345,
                  "description": "12345",
                  "distanceInterval": 12345,
                  "engineHourInterval": 12345,
                  "id": "12345",
                  "linkedSchedules": [
                    {
                      "id": "281474976710656"
                    }
                  ],
                  "title": "12345",
                  "workOrderTemplateId": "12345"
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
                    .WithPath("/maintenance/preventive/schedules")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListPreventiveMaintenanceSchedulesAsync(
            new ListPreventiveMaintenanceSchedulesRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
