using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class CreateSharedAssetsBatchTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "data": [
                {
                  "serial": "GVJC3VXXXX"
                }
              ]
            }
            """;

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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/asset-sharing/agreements/assets/batch")
                    .WithParam("dsaId", "dsaId")
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

        var response = await Client.BetaApIs.CreateSharedAssetsBatchAsync(
            new AssetSharingAgreementsCreateSharedAssetsBatchRequestBody
            {
                DsaId = "dsaId",
                Data = new List<CreateSharedAssetRequestObjectRequestBody>()
                {
                    new CreateSharedAssetRequestObjectRequestBody { Serial = "GVJC3VXXXX" },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
