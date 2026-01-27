using NUnit.Framework;
using Samsara.Net.DriverQrCodes;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.DriverQrCodes;

[TestFixture]
public class DeleteDriverQrCodeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {
              "driverId": 494123
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/drivers/qr-codes")
                    .WithHeader("Content-Type", "application/json")
                    .UsingDelete()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.DriverQrCodes.DeleteDriverQrCodeAsync(
                new DriverQrCodesDeleteDriverQrCodeRequestBody { DriverId = 494123 }
            )
        );
    }
}
