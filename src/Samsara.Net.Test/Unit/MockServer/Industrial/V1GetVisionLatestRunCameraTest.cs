using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Industrial;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Industrial;

[TestFixture]
public class V1GetVisionLatestRunCameraTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "cameraId": 1234512345123,
              "endedAtMs": 0,
              "inspectionResults": [
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
              "isOngoing": true,
              "program": {
                "id": 1,
                "name": "Barcode verification program"
              },
              "runSummary": {
                "itemsPerMinute": 0.1,
                "noReadCount": 0,
                "rejectCount": 0,
                "successCount": 181
              },
              "startedAtMs": 1553808606097
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/industrial/vision/run/camera/1000000")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Industrial.V1GetVisionLatestRunCameraAsync(
            new V1GetVisionLatestRunCameraRequest { CameraId = 1000000 }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<V1VisionRunByCameraResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
