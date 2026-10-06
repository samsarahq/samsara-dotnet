using NUnit.Framework;
using Samsara.Net.Maintenance;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Maintenance;

[TestFixture]
public class ListWarrantyAssetAssignmentsTest : BaseMockServerTest
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
                  "createdAtTime": "2019-06-13T19:08:25Z",
                  "id": "12345",
                  "startEngineHours": 12345,
                  "startOdometerMeters": 12345,
                  "startTime": "2019-06-13T19:08:25Z",
                  "updatedAtTime": "2019-06-13T19:08:25Z",
                  "warranty": {
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
                    .WithPath("/maintenance/warranties/assets")
                    .WithParam("warrantyId", "warrantyId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Maintenance.ListWarrantyAssetAssignmentsAsync(
            new ListWarrantyAssetAssignmentsRequest { WarrantyId = "warrantyId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
