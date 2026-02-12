using NUnit.Framework;
using Samsara.Net.FuelAndEnergy;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.FuelAndEnergy;

[TestFixture]
public class GetFuelEnergyVehicleReportsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "vehicleReports": [
                  {
                    "distanceTraveledMeters": 1384000,
                    "efficiencyMpge": 21.4,
                    "energyUsedKwh": 73.2,
                    "engineIdleTimeDurationMs": 4320000,
                    "engineRunTimeDurationMs": 576000,
                    "estCarbonEmissionsKg": 22.7,
                    "estFuelEnergyCost": {
                      "amount": 94.01,
                      "currencyCode": "USD"
                    },
                    "fuelConsumedMl": 162773,
                    "vehicle": {
                      "energyType": "fuel",
                      "id": "494123",
                      "name": "Fleet Truck #1"
                    }
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
                    .WithPath("/fleet/reports/vehicles/fuel-energy")
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

        var response = await Client.FuelAndEnergy.GetFuelEnergyVehicleReportsAsync(
            new GetFuelEnergyVehicleReportsRequest { StartDate = "startDate", EndDate = "endDate" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
