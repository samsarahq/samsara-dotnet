using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetFunctionTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "codePackage": {
                  "downloadGetUrl": "https://example.com/download?token=...",
                  "status": "unknown"
                },
                "config": {
                  "handler": "index.handler",
                  "isScheduleEnabled": true,
                  "params": {},
                  "schedule": {
                    "entries": [
                      {
                        "daysOfWeek": [
                          false,
                          true,
                          true,
                          true,
                          true,
                          true,
                          false
                        ],
                        "timeSinceMidnightMs": 32400000
                      }
                    ],
                    "timezone": "America/Los_Angeles"
                  },
                  "secrets": {}
                },
                "createdAtTime": "2021-01-01T00:00:00.000Z",
                "description": "Processes incoming telemetry data.",
                "effects": {
                  "nextScheduledAtTime": "2021-01-01T00:00:00.000Z"
                },
                "lastUpdateTimestampMs": 1609459200000,
                "name": "my-function",
                "updatedAtTime": "2021-01-01T00:00:00.000Z"
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/functions/name").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetFunctionAsync(
            new GetFunctionRequest { Name = "name" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
