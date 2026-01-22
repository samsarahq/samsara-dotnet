using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Trips;

namespace Samsara.Net.Test.Unit.MockServer.Trips;

[TestFixture]
public class V1GetFleetTripsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "trips": [
                {
                  "assetIds": [
                    122
                  ],
                  "codriverIds": [
                    122
                  ],
                  "distanceMeters": 2500,
                  "driverId": 719,
                  "endAddress": {
                    "address": "123 Main St, Sunnyvale, CA 94089",
                    "id": 581,
                    "name": "Ramen Tatsunoya"
                  },
                  "endCoordinates": {
                    "latitude": 23.413702345,
                    "longitude": -91.502888123
                  },
                  "endLocation": "571 S Lake Ave, Pasadena, CA 91101",
                  "endMs": 1462881998034,
                  "endOdometer": 210430500,
                  "fuelConsumedMl": 75700,
                  "startAddress": {
                    "address": "123 Main St, Sunnyvale, CA 94089",
                    "id": 581,
                    "name": "Ramen Tatsunoya"
                  },
                  "startCoordinates": {
                    "latitude": 29.443702345,
                    "longitude": -98.502888123
                  },
                  "startLocation": "16 N Fair Oaks Ave, Pasadena, CA 91103",
                  "startMs": 1462878398034,
                  "startOdometer": 210430450,
                  "tollMeters": 32000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/trips")
                    .WithParam("vehicleId", "1000000")
                    .WithParam("startMs", "1000000")
                    .WithParam("endMs", "1000000")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Trips.V1GetFleetTripsAsync(
            new V1GetFleetTripsRequest
            {
                VehicleId = 1000000,
                StartMs = 1000000,
                EndMs = 1000000,
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<V1TripResponse>(mockResponse)).UsingDefaults()
        );
    }
}
