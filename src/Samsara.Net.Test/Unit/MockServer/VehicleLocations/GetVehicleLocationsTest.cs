using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.VehicleLocations;

namespace Samsara.Net.Test.Unit.MockServer.VehicleLocations;

[TestFixture]
public class GetVehicleLocationsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "id": "112",
                  "location": {
                    "heading": 120,
                    "latitude": 122.142,
                    "longitude": -93.343,
                    "speed": 48.3,
                    "time": "2020-01-27T07:06:25.000Z"
                  },
                  "name": "Truck A7"
                }
              ],
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
                    .WithPath("/fleet/vehicles/locations")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.VehicleLocations.GetVehicleLocationsAsync(
            new GetVehicleLocationsRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<VehicleLocationsResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
