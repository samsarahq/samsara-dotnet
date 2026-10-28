using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class PatchMaintenanceEstimateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "lineItems": [
                {
                  "amount": {
                    "amount": "640.20",
                    "currency": "usd"
                  },
                  "description": "Replace turbocharger",
                  "id": "8ea6ff70-1e60-4ed9-9c68-a00d72cb720e"
                }
              ],
              "tax": {
                "amount": "64.02",
                "currency": "usd"
              }
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "approvalSource": "unknown",
                "approvalStatus": "unknown",
                "attachments": [
                  {
                    "createdAtTime": "2026-10-07T15:00:00.000Z",
                    "id": "a81e26e6-50cd-4ae2-85b9-132c493c0871",
                    "name": "repair-quote.pdf",
                    "processingStatus": "unknown",
                    "updatedAtTime": "2026-10-07T15:00:00.000Z",
                    "url": "https://example.com/file",
                    "urlExpiresAt": "2026-10-07T15:00:00.000Z"
                  }
                ],
                "createdAtTime": "2026-10-07T15:00:00.000Z",
                "estimateType": "unknown",
                "externalIds": {
                  "repairSystem": "quote-123"
                },
                "externalRequest": {
                  "actionUrl": "https://example.com/requests/AI-563-1",
                  "externalRequestId": "AI-563-1",
                  "externalSystem": "Auto Integrate",
                  "message": "Review quote in Auto Integrate"
                },
                "id": "a81e26e6-50cd-4ae2-85b9-132c493c0871",
                "isAwarded": false,
                "lineItems": [
                  {
                    "amount": {
                      "amount": "640.2",
                      "currency": "usd"
                    },
                    "description": "Replace turbocharger",
                    "id": "a81e26e6-50cd-4ae2-85b9-132c493c0871",
                    "quantity": 2,
                    "serviceTaskId": "a81e26e6-50cd-4ae2-85b9-132c493c0871",
                    "unitRate": {
                      "amount": "95.005",
                      "currency": "usd"
                    }
                  }
                ],
                "notes": "Contact shop before starting work.",
                "quotedAtTime": "2026-10-07T15:00:00.000Z",
                "subtotal": {
                  "amount": "640.2",
                  "currency": "usd"
                },
                "supersededByEstimateId": "a81e26e6-50cd-4ae2-85b9-132c493c0871",
                "supersedesEstimateId": "a81e26e6-50cd-4ae2-85b9-132c493c0871",
                "tax": {
                  "amount": "640.2",
                  "currency": "usd"
                },
                "total": {
                  "amount": "640.2",
                  "currency": "usd"
                },
                "updatedAtTime": "2026-10-07T15:00:00.000Z",
                "vendorId": "a81e26e6-50cd-4ae2-85b9-132c493c0871",
                "version": 1,
                "workOrderId": "464"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/estimates")
                    .WithParam("id", "id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.PatchMaintenanceEstimateAsync(
            new MaintenanceEstimatesPatchMaintenanceEstimateRequestBody
            {
                Id = "id",
                LineItems = new List<MaintenanceEstimateLineInputRequestBody>()
                {
                    new MaintenanceEstimateLineInputRequestBody
                    {
                        Amount = new MaintenanceEstimateMoneyRequestBody
                        {
                            Amount = "640.20",
                            Currency = MaintenanceEstimateMoneyRequestBodyCurrency.Usd,
                        },
                        Description = "Replace turbocharger",
                        Id = "8ea6ff70-1e60-4ed9-9c68-a00d72cb720e",
                    },
                },
                Tax = new MaintenanceEstimateMoneyRequestBody
                {
                    Amount = "64.02",
                    Currency = MaintenanceEstimateMoneyRequestBodyCurrency.Usd,
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
