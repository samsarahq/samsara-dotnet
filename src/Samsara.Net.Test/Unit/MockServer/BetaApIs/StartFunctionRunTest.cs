using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

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

        var response = await Client.BetaApIs.StartFunctionRunAsync(
            new FunctionsStartFunctionRunRequestBody
            {
                Name = "name",
                ParamsOverride = new FunctionsStartFunctionRunRequestBodyParamsOverride(),
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<FunctionsStartFunctionRunResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
