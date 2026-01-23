using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Maintenance;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Maintenance;

[TestFixture]
public class UpdateDvirDefectTest : BaseMockServerTest
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
                "comment": "Air Compressor not working",
                "createdAtTime": "2020-01-27T07:06:25.000Z",
                "defectType": "Air Compressor",
                "id": "18",
                "isResolved": true,
                "mechanicNotes": "Extremely large oddly shaped hole in passenger side window.",
                "mechanicNotesUpdatedAtTime": "2020-01-27T07:06:25.000Z",
                "resolvedAtTime": "2020-01-27T07:06:25.000Z",
                "resolvedBy": {
                  "id": "11",
                  "name": "Christopher 'The Handyman' Zhen",
                  "type": "driver"
                },
                "trailer": {
                  "id": "123456789",
                  "name": "Midwest Trailer #5"
                },
                "vehicle": {
                  "ExternalIds": {
                    "maintenanceId": "250020",
                    "payrollId": "ABFS18600"
                  },
                  "id": "123456789",
                  "name": "Midwest Truck #4"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/defects/id")
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

        var response = await Client.Maintenance.UpdateDvirDefectAsync(
            new DefectPatch { Id = "id" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<DefectResponse>(mockResponse)).UsingDefaults()
        );
    }
}
