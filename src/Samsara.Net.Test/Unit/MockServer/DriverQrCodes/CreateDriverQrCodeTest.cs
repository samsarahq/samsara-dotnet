using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.DriverQrCodes;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.DriverQrCodes;

[TestFixture]
public class CreateDriverQrCodeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "driverId": 494123
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "driverId": 494123,
                "qrCodeLink": "https://cloud.samsara.com/qr_code/18979ef6-663e-446b-8d5a-0ff0781b8bab"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/drivers/qr-codes")
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

        var response = await Client.DriverQrCodes.CreateDriverQrCodeAsync(
            new DriverQrCodesCreateDriverQrCodeRequestBody { DriverId = 494123 }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<DriverQrCodesCreateDriverQrCodeResponseBody>(mockResponse)
                )
                .UsingDefaults()
        );
    }
}
