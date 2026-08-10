using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class CreatePurchaseOrderTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "orderStatus": "draft",
              "vendorId": "281474976710656"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "createdAtTime": "2019-06-13T19:08:25Z",
                "creationSource": "12345",
                "deliveryAtTime": "2019-06-13T19:08:25Z",
                "firstReceivedAtTime": "2019-06-13T19:08:25Z",
                "fullyReceivedAtTime": "2019-06-13T19:08:25Z",
                "glCode": "GL-4000",
                "id": "12345",
                "invoiceNumber": "INV-12345",
                "mediaItemIds": [
                  "12345",
                  "12345",
                  "12345",
                  "12345"
                ],
                "notes": "Deliver to maintenance shop.",
                "orderStatus": "draft",
                "otherCost": {
                  "amount": "24.50",
                  "currency": "usd"
                },
                "parts": [
                  {
                    "batchNumber": "LOT-42",
                    "description": "Oil filter",
                    "lineItemId": "12345",
                    "partSamsara": {
                      "id": "281474976710656"
                    },
                    "place": {
                      "id": "281474976710656"
                    },
                    "quantityOrdered": 10,
                    "quantityReceived": 123.45,
                    "unitOfMeasureType": "each"
                  }
                ],
                "poNumber": "12345",
                "poNumberPrefix": "PO",
                "poNumberSuffix": "A",
                "sentAtTime": "2019-06-13T19:08:25Z",
                "trackingNumber": "1Z999AA10123456784",
                "updatedAtTime": "2019-06-13T19:08:25Z",
                "vendor": {
                  "id": "281474976710656"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/purchase-orders")
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

        var response = await Client.BetaApIs.CreatePurchaseOrderAsync(
            new EntityPurchaseOrdersServiceCreatePurchaseOrderRequestBody
            {
                OrderStatus = "draft",
                VendorId = "281474976710656",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
