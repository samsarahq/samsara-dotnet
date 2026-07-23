using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class CreatePartTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "partNumber": "12345"
            }
            """;

        const string mockResponse = """
            {
              "data": {
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/parts")
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

        var response = await Client.BetaApIs.CreatePartAsync(
            new EntityPartDefinitionsServiceCreatePartRequestBody { PartNumber = "12345" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
