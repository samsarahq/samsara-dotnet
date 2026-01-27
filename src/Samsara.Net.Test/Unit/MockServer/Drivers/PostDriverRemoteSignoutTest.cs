using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Drivers;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Drivers;

[TestFixture]
public class PostDriverRemoteSignoutTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "driverId": "12434"
            }
            """;

        const string mockResponse = """
            {
              "driverName": "Michael"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/drivers/remote-sign-out")
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

        var response = await Client.Drivers.PostDriverRemoteSignoutAsync(
            new DriverRemoteSignoutPostDriverRemoteSignoutRequestBody { DriverId = "12434" }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<DriverRemoteSignoutPostDriverRemoteSignoutResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
