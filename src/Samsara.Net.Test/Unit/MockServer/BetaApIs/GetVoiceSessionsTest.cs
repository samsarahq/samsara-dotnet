using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetVoiceSessionsTest : BaseMockServerTest
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
                  "callEvents": [
                    {
                      "happenedAtTime": "2024-01-15T09:30:00.000Z",
                      "type": "type"
                    },
                    {
                      "happenedAtTime": "2024-01-15T09:30:00.000Z",
                      "type": "type"
                    }
                  ],
                  "durationMilliseconds": 1000000,
                  "happenedAtTime": "2024-01-15T09:30:00.000Z",
                  "id": "id",
                  "recipient": "recipient",
                  "recordingUrl": "recordingUrl",
                  "recordingUrlExpiresAtTime": "recordingUrlExpiresAtTime",
                  "sessionStatus": "completed",
                  "toolCalls": [
                    {
                      "arguments": "arguments",
                      "durationMilliseconds": 1000000,
                      "name": "name",
                      "output": "output",
                      "startMilliseconds": 1000000,
                      "status": "success"
                    },
                    {
                      "arguments": "arguments",
                      "durationMilliseconds": 1000000,
                      "name": "name",
                      "output": "output",
                      "startMilliseconds": 1000000,
                      "status": "success"
                    }
                  ],
                  "transcript": [
                    {
                      "endMilliseconds": 1000000,
                      "speakerType": "agent",
                      "startMilliseconds": 1000000,
                      "text": "text"
                    },
                    {
                      "endMilliseconds": 1000000,
                      "speakerType": "agent",
                      "startMilliseconds": 1000000,
                      "text": "text"
                    }
                  ],
                  "triggerType": "triggerType",
                  "updatedAtTime": "2024-01-15T09:30:00.000Z"
                },
                {
                  "agentId": "agentId",
                  "agentName": "agentName",
                  "callEvents": [
                    {
                      "happenedAtTime": "2024-01-15T09:30:00.000Z",
                      "type": "type"
                    },
                    {
                      "happenedAtTime": "2024-01-15T09:30:00.000Z",
                      "type": "type"
                    }
                  ],
                  "durationMilliseconds": 1000000,
                  "happenedAtTime": "2024-01-15T09:30:00.000Z",
                  "id": "id",
                  "recipient": "recipient",
                  "recordingUrl": "recordingUrl",
                  "recordingUrlExpiresAtTime": "recordingUrlExpiresAtTime",
                  "sessionStatus": "completed",
                  "toolCalls": [
                    {
                      "arguments": "arguments",
                      "durationMilliseconds": 1000000,
                      "name": "name",
                      "output": "output",
                      "startMilliseconds": 1000000,
                      "status": "success"
                    },
                    {
                      "arguments": "arguments",
                      "durationMilliseconds": 1000000,
                      "name": "name",
                      "output": "output",
                      "startMilliseconds": 1000000,
                      "status": "success"
                    }
                  ],
                  "transcript": [
                    {
                      "endMilliseconds": 1000000,
                      "speakerType": "agent",
                      "startMilliseconds": 1000000,
                      "text": "text"
                    },
                    {
                      "endMilliseconds": 1000000,
                      "speakerType": "agent",
                      "startMilliseconds": 1000000,
                      "text": "text"
                    }
                  ],
                  "triggerType": "triggerType",
                  "updatedAtTime": "2024-01-15T09:30:00.000Z"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/agent-studio/voice-sessions")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetVoiceSessionsAsync(new GetVoiceSessionsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
