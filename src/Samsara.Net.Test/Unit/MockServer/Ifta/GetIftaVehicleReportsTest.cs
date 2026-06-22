using NUnit.Framework;
using Samsara.Net.Ifta;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Ifta;

[TestFixture]
public class GetIftaVehicleReportsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "month": "January",
                "quarter": "Q4",
                "troubleshooting": {
                  "noPurchasesFound": false,
                  "unassignedFuelTypePurchases": 200,
                  "unassignedFuelTypeVehicles": 2500,
                  "unassignedVehiclePurchases": 2500
                },
                "vehicleReports": [
                  {
                    "jurisdictions": [
                      {
                        "jurisdiction": "GA",
                        "taxPaidLiters": 25.5,
                        "taxableMeters": 2350,
                        "totalMeters": 2350
                      }
                    ],
                    "vehicle": {
                      "id": "494123",
                      "name": "Fleet Truck #1"
                    }
                  }
                ],
                "year": 2021
              },
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/reports/ifta/vehicle")
                    .WithParam("year", "1000000")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ifta.GetIftaVehicleReportsAsync(
            new GetIftaVehicleReportsRequest { Year = 1000000 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
