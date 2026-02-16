using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApis;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApis;

[TestFixture]
public class PostReadingsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {
              "data": [
                {
                  "entityId": "123451234512345",
                  "entityType": "asset",
                  "happenedAtTime": "2023-10-27T10:00:00Z",
                  "readingId": "airInletPressure",
                  "value": {
                    "key": "value"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/readings")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.BetaApis.PostReadingsAsync(
                new ReadingsPostReadingsRequestBody
                {
                    Data = new List<ReadingDatapointRequestBody>()
                    {
                        new ReadingDatapointRequestBody
                        {
                            EntityId = "123451234512345",
                            EntityType = "asset",
                            HappenedAtTime = "2023-10-27T10:00:00Z",
                            ReadingId = "airInletPressure",
                            Value = new Dictionary<string, object?>() { { "key", "value" } },
                        },
                    },
                }
            )
        );
    }
}
