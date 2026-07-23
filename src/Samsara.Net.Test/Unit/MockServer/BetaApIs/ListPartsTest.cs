using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListPartsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "archivedAtTime": "2019-06-13T19:08:25Z",
                  "barcodeString": "12345",
                  "category": "12345",
                  "createdAtTime": "2019-06-13T19:08:25Z",
                  "deletedAtTime": "2019-06-13T19:08:25Z",
                  "description": "12345",
                  "id": "12345",
                  "isInventoryTracked": true,
                  "manufacturerPartNumber": "12345",
                  "name": "12345",
                  "partNumber": "12345",
                  "partStatus": "12345",
                  "subcategory": "12345",
                  "unitCost": {
                    "amount": "12345",
                    "currency": "12345"
                  },
                  "unitOfMeasureType": "12345",
                  "updatedAtTime": "2019-06-13T19:08:25Z",
                  "vmrsCode": "12345"
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
                WireMock.RequestBuilders.Request.Create().WithPath("/maintenance/parts").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListPartsAsync(new ListPartsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
