using NUnit.Framework;
using Samsara.Net.LegacyApis;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.LegacyApis;

[TestFixture]
public class GetDvirDefectsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "comment": "Air Compressor not working",
                  "createdAtTime": "2020-01-27T07:06:25Z",
                  "defectType": "Air Compressor",
                  "id": "18",
                  "isResolved": true,
                  "mechanicNotes": "Extremely large oddly shaped hole in passenger side window.",
                  "mechanicNotesUpdatedAtTime": "2020-01-27T07:06:25Z",
                  "resolvedAtTime": "2020-01-27T07:06:25Z",
                  "resolvedBy": {
                    "id": "11",
                    "name": "Christopher 'The Handyman' Zhen"
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
                    .WithPath("/fleet/defects/history")
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

        var response = await Client.LegacyApis.GetDvirDefectsAsync(
            new GetDvirDefectsRequest { StartTime = "startTime", EndTime = "endTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
