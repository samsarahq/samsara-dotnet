using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class CreateMaintenanceEstimatesBatchTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "estimates": [
                {
                  "lineItems": [
                    {
                      "amount": {
                        "amount": "640.20",
                        "currency": "usd"
                      },
                      "description": "Expected repair cost"
                    }
                  ],
                  "tax": {
                    "amount": "0.00",
                    "currency": "usd"
                  },
                  "vendorId": "a81e26e6-50cd-4ae2-85b9-132c493c0871",
                  "workOrderId": "464"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "requestId": "672c7c45-1826-4162-8940-8ff9bd2a328b",
              "responses": [
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
                  },
                  "message": "An open estimate already exists for this vendor and work order.",
                  "status": 200
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/estimates/batch")
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

        var response = await Client.BetaApIs.CreateMaintenanceEstimatesBatchAsync(
            new MaintenanceEstimatesCreateMaintenanceEstimatesBatchRequestBody
            {
                Estimates = new List<MaintenanceEstimateBatchCreateInputRequestBody>()
                {
                    new MaintenanceEstimateBatchCreateInputRequestBody
                    {
                        LineItems = new List<MaintenanceEstimateLineInputRequestBody>()
                        {
                            new MaintenanceEstimateLineInputRequestBody
                            {
                                Amount = new MaintenanceEstimateMoneyRequestBody
                                {
                                    Amount = "640.20",
                                    Currency = MaintenanceEstimateMoneyRequestBodyCurrency.Usd,
                                },
                                Description = "Expected repair cost",
                            },
                        },
                        Tax = new MaintenanceEstimateMoneyRequestBody
                        {
                            Amount = "0.00",
                            Currency = MaintenanceEstimateMoneyRequestBodyCurrency.Usd,
                        },
                        VendorId = "a81e26e6-50cd-4ae2-85b9-132c493c0871",
                        WorkOrderId = "464",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
