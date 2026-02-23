using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

[TestFixture]
public class CreateDriverAuthTokenTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "code": "dp[gZc1wAigz4uGa0Hh"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "expirationTime": 1710000000000,
                "token": "ZmFrZVRva2VuXzMyQnl0ZXNMb25nRm9yVGVzdA"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/preview/fleet/drivers/create-auth-token")
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

        var response = await Client.PreviewApIs.CreateDriverAuthTokenAsync(
            new DriversAuthTokenCreateDriverAuthTokenRequestBody { Code = "dp[gZc1wAigz4uGa0Hh" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
