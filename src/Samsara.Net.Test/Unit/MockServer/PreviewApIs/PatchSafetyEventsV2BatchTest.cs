using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

[TestFixture]
public class PatchSafetyEventsV2BatchTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "safetyEventIds": [
                "bb2ff5ab-30ad-49ec-9d2d-55ec30bbf590",
                "bb2ff5ab-30ad-49ec-9d2d-55ec30bbf590"
              ]
            }
            """;

        const string mockResponse = """
            {
              "requestId": "a1b2c3d4-e5f6-7890-abcd-ef1234567890",
              "responses": [
                {
                  "data": {
                    "safetyEventId": "bb2ff5ab-30ad-49ec-9d2d-55ec30bbf590"
                  },
                  "status": 202
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/preview/safety-events/batch")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreviewApIs.PatchSafetyEventsV2BatchAsync(
            new SafetyEventsV2PatchSafetyEventsV2BatchRequestBody
            {
                SafetyEventIds = new List<string>()
                {
                    "bb2ff5ab-30ad-49ec-9d2d-55ec30bbf590",
                    "bb2ff5ab-30ad-49ec-9d2d-55ec30bbf590",
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
