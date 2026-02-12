using NUnit.Framework;
using Samsara.Net.FuelAndEnergy;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.FuelAndEnergy;

[TestFixture]
public class GetFuelEnergyDriverReportsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "driverReports": [
                  {
                    "distanceTraveledMeters": 1384000,
                    "driver": {
                      "id": "45646",
                      "name": "Driver Bob"
                    },
                    "efficiencyMpge": 21.4,
                    "energyUsedKwh": 73.2,
                    "engineIdleTimeDurationMs": 4320000,
                    "engineRunTimeDurationMs": 576000,
                    "estCarbonEmissionsKg": 22.7,
                    "estFuelEnergyCost": {
                      "amount": 94.01,
                      "currencyCode": "USD"
                    },
                    "fuelConsumedMl": 162773
                  }
                ]
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
                    .WithPath("/fleet/reports/drivers/fuel-energy")
                    .WithParam("startDate", "startDate")
                    .WithParam("endDate", "endDate")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.FuelAndEnergy.GetFuelEnergyDriverReportsAsync(
            new GetFuelEnergyDriverReportsRequest { StartDate = "startDate", EndDate = "endDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
