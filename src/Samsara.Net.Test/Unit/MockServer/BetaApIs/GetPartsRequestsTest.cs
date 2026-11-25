using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetPartsRequestsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "fulfillmentMethod": "stock",
                  "id": "1042-3",
                  "lineId": "3",
                  "linkedPurchaseOrderLines": [
                    {
                      "orderedQuantity": 4,
                      "partSamsaraId": "6f1c2b3a-9d8e-4f00-a1b2-c3d4e5f60718",
                      "purchaseOrderNumber": "PO-1001",
                      "receivedQuantity": 2
                    }
                  ],
                  "maintenanceSiteId": "2d0e5e9b-4b2a-4e4e-9b8e-6c3f8a7d1e2f",
                  "needByTime": "2026-03-01T00:00:00.000Z",
                  "partSamsaraId": "6f1c2b3a-9d8e-4f00-a1b2-c3d4e5f60718",
                  "partsRequestId": "1042",
                  "priority": "low",
                  "requestedQuantity": 4,
                  "reservedQuantity": 2,
                  "status": "draft",
                  "submittedAtTime": "2026-02-20T15:04:05.000Z",
                  "workOrderId": "1234567"
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
                    .WithPath("/maintenance/parts-requests")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetPartsRequestsAsync(new GetPartsRequestsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
