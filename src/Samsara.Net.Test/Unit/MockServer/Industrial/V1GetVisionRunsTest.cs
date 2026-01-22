using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Industrial;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Industrial;

[TestFixture]
public class V1GetVisionRunsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "visionRuns": [
                {
                  "deviceId": 1234512345123,
                  "endedAtMs": 0,
                  "programId": 1,
                  "reportMetadata": {
                    "itemsPerMinute": 0.1,
                    "noReadCount": 181,
                    "rejectCount": 0,
                    "successCount": 181
                  },
                  "startedAtMs": 1553808606097
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/industrial/vision/runs")
                    .WithParam("durationMs", "1000000")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Industrial.V1GetVisionRunsAsync(
            new V1GetVisionRunsRequest { DurationMs = 1000000 }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<V1VisionRunsResponse>(mockResponse)).UsingDefaults()
        );
    }
}
