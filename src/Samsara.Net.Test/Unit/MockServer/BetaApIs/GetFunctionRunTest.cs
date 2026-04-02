using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetFunctionRunTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "completedAtTime": "2021-01-01T00:00:30.000Z",
                "context": {
                  "requestId": "req-550e8400-e29b-41d4-a716-446655440000",
                  "requestPayload": {
                    "key": "value"
                  },
                  "responsePayload": {
                    "key": "value"
                  }
                },
                "correlationId": "550e8400-e29b-41d4-a716-446655440000",
                "name": "my-function",
                "startedAtTime": "2021-01-01T00:00:00.000Z",
                "status": "started"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/functions/name/runs/correlationId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetFunctionRunAsync(
            new GetFunctionRunRequest { Name = "name", CorrelationId = "correlationId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
