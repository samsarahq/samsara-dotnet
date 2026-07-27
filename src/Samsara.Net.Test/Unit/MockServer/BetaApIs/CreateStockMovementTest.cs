using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class CreateStockMovementTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "movementType": "12345",
              "partSamsaraId": "12345",
              "quantity": 123.45
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "destinationLocation": {
                  "aisle": "12345",
                  "availableQuantity": 123.45,
                  "bin": "12345",
                  "createdAtTime": "2019-06-13T19:08:25Z",
                  "currentQuantity": 123.45,
                  "id": "12345",
                  "isCostTracked": true,
                  "isLowStock": true,
                  "maxStockLevel": 123.45,
                  "minStockLevel": 123.45,
                  "partSamsara": "12345",
                  "place": "12345",
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
                },
                "sourceLocation": {
                  "aisle": "12345",
                  "availableQuantity": 123.45,
                  "bin": "12345",
                  "createdAtTime": "2019-06-13T19:08:25Z",
                  "currentQuantity": 123.45,
                  "id": "12345",
                  "isCostTracked": true,
                  "isLowStock": true,
                  "maxStockLevel": 123.45,
                  "minStockLevel": 123.45,
                  "partSamsara": "12345",
                  "place": "12345",
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
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/parts/stock-movements")
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

        var response = await Client.BetaApIs.CreateStockMovementAsync(
            new CreateStockMovementActionServiceCreateStockMovementRequestBody
            {
                MovementType = "12345",
                PartSamsaraId = "12345",
                Quantity = 123.45,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
