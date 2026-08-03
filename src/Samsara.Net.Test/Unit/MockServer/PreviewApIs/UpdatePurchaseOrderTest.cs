using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

[TestFixture]
public class UpdatePurchaseOrderTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "data": {
                "createdAtTime": "2019-06-13T19:08:25Z",
                "creationSource": "12345",
                "deliveryAtTime": "2019-06-13T19:08:25Z",
                "firstReceivedAtTime": "2019-06-13T19:08:25Z",
                "fullyReceivedAtTime": "2019-06-13T19:08:25Z",
                "glCode": "12345",
                "id": "12345",
                "invoiceNumber": "12345",
                "mediaItemIds": [
                  "12345",
                  "12345",
                  "12345"
                ],
                "notes": "12345",
                "orderStatus": "12345",
                "otherCost": {
                  "amount": "12345",
                  "currency": "12345"
                },
                "parts": [
                  {
                    "batchNumber": "12345",
                    "description": "12345",
                    "lineItemId": "12345",
                    "partSamsara": {
                      "id": "281474976710656"
                    },
                    "place": {
                      "id": "281474976710656"
                    },
                    "quantityOrdered": 123.45,
                    "quantityReceived": 123.45,
                    "unitOfMeasureType": "12345"
                  }
                ],
                "poNumber": "12345",
                "poNumberPrefix": "12345",
                "poNumberSuffix": "12345",
                "sentAtTime": "2019-06-13T19:08:25Z",
                "trackingNumber": "12345",
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
                    .WithPath("/preview/maintenance/purchase-orders")
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

        var response = await Client.PreviewApIs.UpdatePurchaseOrderAsync(
            new EntityPurchaseOrdersServiceUpdatePurchaseOrderRequestBody { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
