using NUnit.Framework;
using Samsara.Net.Industrial;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

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
            1000000,
            1000000,
            1000000,
            new V1GetVisionRunsByCameraAndProgramRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
