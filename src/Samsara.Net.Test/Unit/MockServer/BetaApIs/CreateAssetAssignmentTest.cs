using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class CreateAssetAssignmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "assetId": "281474978683353",
              "assigneeId": "494123",
              "assigneeType": "driver"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "asset": {
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "12345"
                },
                "assignee": {
                  "assigneeType": "unknown",
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "494123"
                },
                "endTime": "2024-09-01T13:00:00.000Z",
                "startTime": "2024-09-01T12:00:00.000Z"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/assets/assignments")
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

        var response = await Client.BetaApIs.CreateAssetAssignmentAsync(
            new AssetAssignmentsCreateAssetAssignmentRequestBody
            {
                AssetId = "281474978683353",
                AssigneeId = "494123",
                AssigneeType = AssetAssignmentsCreateAssetAssignmentRequestBodyAssigneeType.Driver,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
