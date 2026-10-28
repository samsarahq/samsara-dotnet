using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetCampaignRollupsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "agingItemCount": 7,
                "campaignId": "2d0e5e9b-4b2a-4e4e-9b8e-6c3f8a7d1e2f",
                "itemCountsByState": [
                  {
                    "count": 42,
                    "state": "pending"
                  }
                ],
                "totalItemCount": 120
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/campaigns/rollups")
                    .WithParam("campaignId", "campaignId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetCampaignRollupsAsync(
            new GetCampaignRollupsRequest { CampaignId = "campaignId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
