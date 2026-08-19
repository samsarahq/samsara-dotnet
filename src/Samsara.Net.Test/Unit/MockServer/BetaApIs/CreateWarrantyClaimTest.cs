using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class CreateWarrantyClaimTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "assetId": "281474976710656"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "asset": {
                  "id": "281474976710656"
                },
                "cause": "12345",
                "claimEngineHours": 12345,
                "claimOdometerMeters": 12345,
                "claimStatus": "12345",
                "componentInstanceIds": [
                  "12345",
                  "12345",
                  "12345",
                  "12345"
                ],
                "concern": "12345",
                "correction": "12345",
                "createdAtTime": "2019-06-13T19:08:25Z",
                "externalIds": [
                  {
                    "key": "12345",
                    "value": "12345"
                  }
                ],
                "id": "12345",
                "labor": [
                  {
                    "description": "12345",
                    "serviceTaskId": "12345",
                    "sourceWorkOrderId": "12345",
                    "vmrsCode": "12345"
                  }
                ],
                "linkedWarranty": {
                  "id": "281474976710656"
                },
                "linkedWorkOrderIds": [
                  "12345",
                  "12345",
                  "12345"
                ],
                "mediaItemIds": [
                  "12345",
                  "12345",
                  "12345",
                  "12345"
                ],
                "otherCost": {
                  "amount": "12345",
                  "currency": "12345"
                },
                "parts": [
                  {
                    "description": "12345",
                    "partDefinitionId": "12345",
                    "partId": "12345",
                    "quantity": 12345,
                    "serviceTaskId": "12345",
                    "sourceWorkOrderId": "12345",
                    "vmrsCode": "12345"
                  }
                ],
                "reimbursedAtTime": "2019-06-13T19:08:25Z",
                "reimbursements": [
                  {
                    "workOrderId": "12345"
                  }
                ],
                "repairCompletedAtTime": "2019-06-13T19:08:25Z",
                "resolutionAtTime": "2019-06-13T19:08:25Z",
                "statusHistory": [
                  {
                    "happenedAtTime": "2019-06-13T19:08:25Z",
                    "status": "12345",
                    "userId": "12345"
                  }
                ],
                "submittedAtTime": "2019-06-13T19:08:25Z",
                "updatedAtTime": "2019-06-13T19:08:25Z",
                "warrantyVendor": {
                  "id": "281474976710656"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/warranty-claims")
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

        var response = await Client.BetaApIs.CreateWarrantyClaimAsync(
            new EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBody
            {
                AssetId = "281474976710656",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
