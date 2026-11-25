using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListAssetStatusChangeEventsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "actor": {
                    "actorId": "12345"
                  },
                  "asset": {
                    "id": "281474976710656"
                  },
                  "changeUuid": "12345",
                  "comment": "12345",
                  "isImported": true,
                  "newStatus": {
                    "name": "12345",
                    "statusUuid": "12345"
                  },
                  "occurredAtTime": "2019-06-13T19:08:25Z",
                  "previousStatus": {
                    "name": "12345",
                    "statusUuid": "12345"
                  },
                  "source": "unknown",
                  "sourceEntity": {
                    "sourceEntityId": "12345"
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
                    .WithPath("/maintenance/asset-status-changes")
                    .WithParam("assetIds", "assetIds")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListAssetStatusChangeEventsAsync(
            new ListAssetStatusChangeEventsRequest { AssetIds = "assetIds" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
