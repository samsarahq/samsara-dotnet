using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class UpdateShippingDocsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "shippingDocs": "ShippingID1, ShippingID2"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "adverseDrivingClaimed": false,
                "bigDayClaimed": true,
                "carrierFormattedAddress": "1990 Alameda Street, San Francisco, CA 94103",
                "carrierName": "Carrier Name",
                "carrierUsDotNumber": 1234,
                "homeTerminalFormattedAddress": "1990 Alameda Street, San Francisco, CA 94103",
                "homeTerminalName": "Home Terminal Name",
                "isCertified": true,
                "isUsShortHaulActive": true,
                "trailerNames": [
                  "10293",
                  "Trailer ID 1"
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/hos/daily-logs/log-meta-data")
                    .WithParam("hosDate", "hosDate")
                    .WithParam("driverID", "driverID")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.UpdateShippingDocsAsync(
            new HosDailyLogsUpdateShippingDocsRequestBody
            {
                HosDate = "hosDate",
                DriverId = "driverID",
                ShippingDocs = "ShippingID1, ShippingID2",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<HosDailyLogsUpdateShippingDocsResponseBody>(mockResponse)
                )
                .UsingDefaults()
        );
    }
}
