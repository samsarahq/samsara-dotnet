using NUnit.Framework;
using Samsara.Net.BetaApis;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApis;

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

        var response = await Client.BetaApis.UpdateShippingDocsAsync(
            new HosDailyLogsUpdateShippingDocsRequestBody
            {
                HosDate = "hosDate",
                DriverId = "driverID",
                ShippingDocs = "ShippingID1, ShippingID2",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
