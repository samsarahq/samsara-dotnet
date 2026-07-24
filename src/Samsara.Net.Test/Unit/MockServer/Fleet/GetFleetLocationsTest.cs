using NUnit.Framework;
using Samsara.Net.Fleet;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Fleet;

[TestFixture]
public class GetFleetLocationsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "pagination": {
                "endCursor": "MTA1MDc5MB==",
                "hasNextPage": true
              },
              "vehicles": [
                {
                  "driverId": 1,
                  "heading": 246.42,
                  "id": 112,
                  "latitude": 123.456,
                  "location": "1 Main St, Dallas, TX",
                  "longitude": 32.897,
                  "name": "Truck A7",
                  "odometerMeters": 71774705,
                  "odometerType": "GPS",
                  "onTrip": true,
                  "routeIds": [
                    2244514,
                    2311654
                  ],
                  "speed": 64.37,
                  "time": 1462881998034,
                  "vin": "JTNBB46KX73011966"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/v1/fleet/locations").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Fleet.GetFleetLocationsAsync(new GetFleetLocationsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
