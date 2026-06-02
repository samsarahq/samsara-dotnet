using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetVoiceSessionsStreamTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "agentId": "agentId",
                  "agentName": "agentName",
                  "durationMilliseconds": 1000000,
                  "happenedAtTime": "2024-01-15T09:30:00.000Z",
                  "id": "id",
                  "recipient": "recipient",
                  "sessionStatus": "completed",
                  "triggerType": "triggerType",
                  "updatedAtTime": "2024-01-15T09:30:00.000Z"
                },
                {
                  "agentId": "agentId",
                  "agentName": "agentName",
                  "durationMilliseconds": 1000000,
                  "happenedAtTime": "2024-01-15T09:30:00.000Z",
                  "id": "id",
                  "recipient": "recipient",
                  "sessionStatus": "completed",
                  "triggerType": "triggerType",
                  "updatedAtTime": "2024-01-15T09:30:00.000Z"
                }
              ],
              "pagination": {
                "endCursor": "endCursor",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/agent-studio/voice-sessions/stream")
                    .WithParam("startTime", "startTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetVoiceSessionsStreamAsync(
            new GetVoiceSessionsStreamRequest { StartTime = "startTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
