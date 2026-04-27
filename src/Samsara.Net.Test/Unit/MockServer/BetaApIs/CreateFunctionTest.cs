using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class CreateFunctionTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "config": {
                "handler": "index.handler"
              },
              "name": "my-function"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "codePackage": {
                  "downloadGetUrl": "https://example.com/download?token=...",
                  "status": "unknown"
                },
                "config": {
                  "handler": "index.handler",
                  "isScheduleEnabled": false,
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
                "updatedAtTime": "2021-01-01T00:00:00.000Z",
                "uploadPutUrl": "https://example.com/upload?token=..."
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/functions")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.CreateFunctionAsync(
            new FunctionsCreateFunctionRequestBody
            {
                Config = new CreateFunctionRequestConfigRequestBody { Handler = "index.handler" },
                Name = "my-function",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
