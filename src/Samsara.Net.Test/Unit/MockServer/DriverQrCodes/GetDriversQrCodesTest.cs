using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.DriverQrCodes;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.DriverQrCodes;

[TestFixture]
public class GetDriversQrCodesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "driverId": 1000000,
                  "qrCodeLink": "qrCodeLink"
                },
                {
                  "driverId": 1000000,
                  "qrCodeLink": "qrCodeLink"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/drivers/qr-codes").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.DriverQrCodes.GetDriversQrCodesAsync(
            new GetDriversQrCodesRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<DriverQrCodesGetDriversQrCodesResponseBody>(mockResponse)
                )
                .UsingDefaults()
        );
    }
}
