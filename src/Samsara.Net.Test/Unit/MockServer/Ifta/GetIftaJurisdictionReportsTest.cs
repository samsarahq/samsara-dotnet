using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Ifta;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Ifta;

[TestFixture]
public class GetIftaJurisdictionReportsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "jurisdictionReports": [
                  {
                    "jurisdiction": "GA",
                    "taxPaidLiters": 25.5,
                    "taxableMeters": 2350,
                    "totalMeters": 2350
                  }
                ],
                "month": "January",
                "quarter": "Q4",
                "troubleshooting": {
                  "noPurchasesFound": false,
                  "unassignedFuelTypePurchases": 200,
                  "unassignedFuelTypeVehicles": 2500,
                  "unassignedVehiclePurchases": 2500
                },
                "year": 2021
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/reports/ifta/jurisdiction")
                    .WithParam("year", "1000000")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ifta.GetIftaJurisdictionReportsAsync(
            new GetIftaJurisdictionReportsRequest { Year = 1000000 }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<IftaGetIftaJurisdictionReportsResponseBody>(mockResponse)
                )
                .UsingDefaults()
        );
    }
}
