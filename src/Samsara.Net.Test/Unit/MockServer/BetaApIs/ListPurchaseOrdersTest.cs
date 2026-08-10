using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListPurchaseOrdersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAtTime": "2019-06-13T19:08:25Z",
                  "creationSource": "12345",
                  "deliveryAtTime": "2019-06-13T19:08:25Z",
                  "firstReceivedAtTime": "2019-06-13T19:08:25Z",
                  "fullyReceivedAtTime": "2019-06-13T19:08:25Z",
                  "glCode": "12345",
                  "id": "281474976710656",
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
                  "poNumber": "PO-1001",
                  "poNumberPrefix": "12345",
                  "poNumberSuffix": "12345",
                  "sentAtTime": "2019-06-13T19:08:25Z",
                  "trackingNumber": "12345",
                  "updatedAtTime": "2019-06-13T19:08:25Z",
                  "vendor": {
                    "id": "281474976710656"
                  }
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
                    .WithPath("/maintenance/purchase-orders")
                    .WithParam("ids", "281474976710656")
                    .WithParam("poNumbers", "PO-1001")
                    .WithParam("vendorIds", "281474976710656")
                    .WithParam("endTime", "2026-07-31T00:00:00Z")
                    .WithParam("startTime", "2026-07-01T00:00:00Z")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListPurchaseOrdersAsync(
            new ListPurchaseOrdersRequest
            {
                Ids = "281474976710656",
                PoNumbers = "PO-1001",
                VendorIds = "281474976710656",
                EndTime = "2026-07-31T00:00:00Z",
                StartTime = "2026-07-01T00:00:00Z",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
