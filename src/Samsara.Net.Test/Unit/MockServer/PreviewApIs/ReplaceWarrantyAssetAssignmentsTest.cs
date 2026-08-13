using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

[TestFixture]
public class ReplaceWarrantyAssetAssignmentsTest : BaseMockServerTest
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
                "data": [
                  {
                    "assetId": "12345",
                    "createdAtTime": "2019-06-13T19:08:25Z",
                    "id": "12345",
                    "startEngineHours": 12345,
                    "startOdometerMeters": 12345,
                    "startTime": "2019-06-13T19:08:25Z",
                    "updatedAtTime": "2019-06-13T19:08:25Z",
                    "warrantyId": "12345"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/preview/maintenance/warranties/assets/replace")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreviewApIs.ReplaceWarrantyAssetAssignmentsAsync(
            new ReplaceWarrantyAssetAssignmentsActionServiceReplaceWarrantyAssetAssignmentsRequestBody()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
