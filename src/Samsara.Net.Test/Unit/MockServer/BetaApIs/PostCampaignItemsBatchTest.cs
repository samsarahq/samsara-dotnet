using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class PostCampaignItemsBatchTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "data": [
                {}
              ]
            }
            """;

        const string mockResponse = """
            {
              "requestId": "1f7f5081-9f8e-4b68-8b85-97dbe4b46d7e",
              "responses": [
                {
                  "assetId": "281474976710655",
                  "message": "No asset in your organization has this VIN.",
                  "result": "created",
                  "status": 200
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/campaigns/items/batch")
                    .WithParam("campaignId", "campaignId")
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

        var response = await Client.BetaApIs.PostCampaignItemsBatchAsync(
            new CampaignsPostCampaignItemsBatchRequestBody
            {
                CampaignId = "campaignId",
                Data = new List<CampaignItemIngestEntryObjectRequestBody>()
                {
                    new CampaignItemIngestEntryObjectRequestBody(),
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
