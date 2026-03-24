using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class PatchFunctionTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "lastUpdateTimestampMs": 1609459200000
            }
            """;

        const string mockResponse = """
            {
              "data": {
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
                    .WithPath("/functions/name")
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

        var response = await Client.BetaApIs.PatchFunctionAsync(
            new FunctionsPatchFunctionRequestBody
            {
                Name = "name",
                LastUpdateTimestampMs = 1609459200000,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
