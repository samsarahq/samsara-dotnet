using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetShopsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
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
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/maintenance/shops").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetShopsAsync(new GetShopsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
