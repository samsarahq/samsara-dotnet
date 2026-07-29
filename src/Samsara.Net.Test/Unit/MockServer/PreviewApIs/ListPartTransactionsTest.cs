using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

[TestFixture]
public class ListPartTransactionsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "batch": "12345",
                  "createdAtTime": "2019-06-13T19:08:25Z",
                  "createdByUserId": "12345",
                  "fromPlaceId": "12345",
                  "happenedAtTime": "2019-06-13T19:08:25Z",
                  "id": "12345",
                  "notes": "12345",
                  "part": {
                    "id": "281474976710656"
                  },
                  "placeId": "12345",
                  "purchaseOrder": "12345",
                  "quantity": 123.45,
                  "resultingQuantity": 123.45,
                  "toPlaceId": "12345",
                  "transactionType": "12345",
                  "unitCost": 123.45,
                  "vendorId": "12345",
                  "workOrder": {
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
                    .WithPath("/preview/maintenance/parts/transactions")
                    .WithParam("happenedAtTimeStart", "happenedAtTimeStart")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreviewApIs.ListPartTransactionsAsync(
            new ListPartTransactionsRequest { HappenedAtTimeStart = "happenedAtTimeStart" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
