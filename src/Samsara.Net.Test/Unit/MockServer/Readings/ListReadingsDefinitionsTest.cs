using NUnit.Framework;
using Samsara.Net.Readings;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Readings;

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

        var response = await Client.Readings.ListReadingsDefinitionsAsync(
            new ListReadingsDefinitionsRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
