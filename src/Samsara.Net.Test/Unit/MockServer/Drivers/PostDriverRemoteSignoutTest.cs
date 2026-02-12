using NUnit.Framework;
using Samsara.Net.Drivers;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

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
        JsonAssert.AreEqual(response, mockResponse);
    }
}
