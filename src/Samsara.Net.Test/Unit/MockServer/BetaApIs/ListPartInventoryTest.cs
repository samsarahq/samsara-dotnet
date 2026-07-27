using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListPartInventoryTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "aisle": "12345",
                  "availableQuantity": 123.45,
                  "bin": "12345",
                  "createdAtTime": "2019-06-13T19:08:25Z",
                  "currentQuantity": 123.45,
                  "isCostTracked": true,
                  "isLowStock": true,
                  "maxStockLevel": 123.45,
                  "minStockLevel": 123.45,
                  "partSamsara": {
                    "id": "281474976710656"
                  },
                  "place": {
                    "id": "281474976710656"
                  },
                  "reorderQuantity": 123.45,
                  "reorderThreshold": 123.45,
                  "reservedQuantity": 123.45,
                  "row": "12345",
                  "unitCost": {
                    "amount": "12345",
                    "currency": "12345"
                  },
                  "unitOfMeasureType": "12345",
                  "updatedAtTime": "2019-06-13T19:08:25Z"
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
                    .WithPath("/maintenance/parts/inventory-location")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListPartInventoryAsync(new ListPartInventoryRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
