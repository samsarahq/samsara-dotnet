using NUnit.Framework;
using Samsara.Net.PreventiveMaintenance;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreventiveMaintenance;

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
                  "dateIntervalMs": 7776000000,
                  "description": "Replace engine oil and oil filter, then inspect belts and hoses.",
                  "distanceInterval": 8046720,
                  "engineHourInterval": 250,
                  "id": "281474976710656",
                  "linkedSchedules": [
                    {
                      "id": "281474976710656"
                    }
                  ],
                  "title": "Engine oil and filter change",
                  "workOrderTemplateId": "281474976710656"
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
                    .WithParam("ids", "281474976710656")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreventiveMaintenance.ListPreventiveMaintenanceSchedulesAsync(
            new ListPreventiveMaintenanceSchedulesRequest { Ids = "281474976710656" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
