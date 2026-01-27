using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetReadingsHistoryTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "entityId": "123456",
                  "externalIds": {
                    "key": "value"
                  },
                  "happenedAtTime": "2020-01-27T07:06:25.000Z",
                  "value": {
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
                    .WithPath("/readings/history")
                    .WithParam("readingId", "readingId")
                    .WithParam("entityType", "entityType")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetReadingsHistoryAsync(
            new GetReadingsHistoryRequest { ReadingId = "readingId", EntityType = "entityType" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ReadingsGetReadingsHistoryResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
