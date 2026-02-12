using NUnit.Framework;
using Samsara.Net.Industrial;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Industrial;

[TestFixture]
public class V1GetMachinesHistoryTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "endMs": 1462881998034,
              "startMs": 1462878398034
            }
            """;

        const string mockResponse = """
            {
              "machines": [
                {
                  "id": 1,
                  "name": "1/3 HP Motor",
                  "vibrations": [
                    {
                      "X": 0.01,
                      "Y": 1.23,
                      "Z": 2.55,
                      "time": 1453449599999
                    }
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/machines/history")
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

        var response = await Client.Industrial.V1GetMachinesHistoryAsync(
            new InlineObject3 { EndMs = 1462881998034, StartMs = 1462878398034 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
