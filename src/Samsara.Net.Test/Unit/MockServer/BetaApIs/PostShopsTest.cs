using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class PostShopsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "name": "Main Shop"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "id": "8f3c2a10-6b4e-4d2a-9c11-0a7e5b1d4c88",
                "inventoryLocations": [
                  {
                    "id": "281474993384538"
                  }
                ],
                "name": "Main Shop",
                "places": [
                  {
                    "id": "281474993384538"
                  }
                ],
                "tags": [
                  {
                    "id": "4815",
                    "name": "East Coast",
                    "parentTagId": "100"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/shops")
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

        var response = await Client.BetaApIs.PostShopsAsync(
            new ShopsPostShopsRequestBody { Name = "Main Shop" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
