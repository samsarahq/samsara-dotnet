using NUnit.Framework;
using Samsara.Net.BetaApis;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApis;

[TestFixture]
public class ListReadingsDefinitionsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "category": "smartTrailer",
                  "description": "Engine Speed",
                  "entityType": "sensor",
                  "enumValues": [
                    {
                      "label": "Critically High",
                      "symbol": "criticallyHigh"
                    }
                  ],
                  "ingestionEnabled": true,
                  "label": "engineRpm",
                  "readingId": "12345",
                  "type": {
                    "key": "value"
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
                    .WithPath("/readings/definitions")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApis.ListReadingsDefinitionsAsync(
            new ListReadingsDefinitionsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
