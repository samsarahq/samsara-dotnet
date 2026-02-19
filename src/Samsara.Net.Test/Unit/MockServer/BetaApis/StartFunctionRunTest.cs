using NUnit.Framework;
using Samsara.Net.BetaApis;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApis;

[TestFixture]
public class StartFunctionRunTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "paramsOverride": {}
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "correlationId": "550e8400-e29b-41d4-a716-446655440000"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/functions/name/runs")
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

        var response = await Client.BetaApis.StartFunctionRunAsync(
            "name",
            new FunctionsStartFunctionRunRequestBody
            {
                ParamsOverride = new FunctionsStartFunctionRunRequestBodyParamsOverride(),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
