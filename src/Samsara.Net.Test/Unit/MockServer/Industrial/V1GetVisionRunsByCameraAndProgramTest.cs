using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Industrial;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Industrial;

[TestFixture]
public class V1GetVisionRunsByCameraAndProgramTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "deviceId": 1234512345123,
              "endedAtMs": 0,
              "programId": 1,
              "reportMetadata": {
                "itemsPerMinute": 0.1,
                "noReadCount": 0,
                "rejectCount": 0,
                "successCount": 181
              },
              "results": [
                {
                  "captureAtMs": 1553811994730,
                  "result": "PASS",
                  "stepResults": [
                    {
                      "name": "Chicken Caesar Label",
                      "result": "PASS"
                    }
                  ]
                }
              ],
              "startedAtMs": 1553808606097
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/industrial/vision/runs/1000000/1000000/1000000")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Industrial.V1GetVisionRunsByCameraAndProgramAsync(
            new V1GetVisionRunsByCameraAndProgramRequest
            {
                CameraId = 1000000,
                ProgramId = 1000000,
                StartedAtMs = 1000000,
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<V1VisionRunsByCameraAndProgramResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
