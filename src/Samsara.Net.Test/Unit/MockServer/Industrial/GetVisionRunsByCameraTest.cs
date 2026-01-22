using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Industrial;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Industrial;

[TestFixture]
public class GetVisionRunsByCameraTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            [
              {
                "deviceId": 1234512345123,
                "endedAtMs": 0,
                "program": {
                  "id": 1,
                  "name": "Barcode verification program"
                },
                "reportMetadata": {
                  "itemsPerMinute": 0.1,
                  "noReadCount": 0,
                  "rejectCount": 0,
                  "successCount": 181
                },
                "startedAtMs": 1553808606097
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/industrial/vision/runs/1000000")
                    .WithParam("durationMs", "1000000")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Industrial.GetVisionRunsByCameraAsync(
            new GetVisionRunsByCameraRequest { CameraId = 1000000, DurationMs = 1000000 }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<IEnumerable<V1VisionRunsByCameraResponseItem>>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
