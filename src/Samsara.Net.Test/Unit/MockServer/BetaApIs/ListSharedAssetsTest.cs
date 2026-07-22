using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListSharedAssetsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAtTime": "2024-01-13T10:00:00Z",
                  "createdByUserId": "111",
                  "endTime": "2025-01-13T10:00:00Z",
                  "id": "11111111-1111-1111-1111-111111111111",
                  "providerAssetId": "1234567890",
                  "recipientAssetId": "9876543210",
                  "serial": "GVJC-3VX-XXX",
                  "startTime": "2024-01-13T10:00:00Z"
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
                    .WithPath("/fleet/asset-sharing/agreements/assets")
                    .WithParam("dsaId", "dsaId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListSharedAssetsAsync(
            new ListSharedAssetsRequest { DsaId = "dsaId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
