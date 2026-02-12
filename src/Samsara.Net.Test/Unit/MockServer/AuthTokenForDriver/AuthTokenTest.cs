using NUnit.Framework;
using Samsara.Net.AuthTokenForDriver;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.AuthTokenForDriver;

[TestFixture]
public class AuthTokenTest : BaseMockServerTest
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
                    .WithPath("/fleet/drivers/auth-token")
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

        var response = await Client.AuthTokenForDriver.AuthTokenAsync(
            new AuthTokenAuthTokenRequestBody { Code = "dp[gZc1wAigz4uGa0Hh" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
