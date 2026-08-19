using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class CancelSharedAssetsBatchTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "data": [
                {
                  "id": "12345"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "requestId": "1f7f5081-9f8e-4b68-8b85-97dbe4b46d7e",
              "responses": [
                {
                  "data": {
                    "createdAtTime": "2024-01-13T10:00:00Z",
                    "createdByUserId": "111",
                    "endTime": "2025-01-13T10:00:00Z",
                    "id": "11111111-1111-1111-1111-111111111111",
                    "providerAssetId": "1234567890",
                    "recipientAssetId": "9876543210",
                    "serial": "GVJC-3VX-XXX",
                    "startTime": "2024-01-13T10:00:00Z"
                  },
                  "message": "Shared asset not found.",
                  "status": 200
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/asset-sharing/agreements/assets/cancel/batch")
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

        var response = await Client.BetaApIs.CancelSharedAssetsBatchAsync(
            new AssetSharingAgreementsCancelSharedAssetsBatchRequestBody
            {
                Data = new List<IdReferenceObjectRequestBody>()
                {
                    new IdReferenceObjectRequestBody { Id = "12345" },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
