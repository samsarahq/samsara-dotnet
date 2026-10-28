using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetCampaignItemsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "assetId": "281474976710655",
                  "campaignId": "2d0e5e9b-4b2a-4e4e-9b8e-6c3f8a7d1e2f",
                  "completedAtTime": "2026-02-10T09:30:00.000Z",
                  "createdAtTime": "2026-01-20T15:04:05.000Z",
                  "dismissedReason": "Vehicle sold",
                  "effectiveState": "pending",
                  "id": "9b2f6c0e-3d57-4c1a-8a41-5a3f0c7d2b10",
                  "linkedWorkOrderId": "1234567",
                  "sourceBasis": "api",
                  "sourceRef": "recall-feed-2026-02-01:row-1042",
                  "state": "pending",
                  "stateSinceTime": "2026-01-20T15:04:05.000Z",
                  "vin": "1FUJGHDV0CLBP8834"
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
                    .WithPath("/maintenance/campaigns/items")
                    .WithParam("campaignId", "campaignId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetCampaignItemsAsync(
            new GetCampaignItemsRequest { CampaignId = "campaignId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
