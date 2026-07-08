using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetPlaceGeofenceTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "areaSquareMeters": 1240.5,
                  "geofence": {
                    "circle": {
                      "latitude": 37.7749,
                      "longitude": -122.4194,
                      "radiusMeters": 150
                    },
                    "polygon": {
                      "vertices": [
                        {
                          "latitude": 37.7749,
                          "longitude": -122.4194
                        }
                      ]
                    },
                    "type": "circle"
                  },
                  "name": "Oakland Warehouse",
                  "type": "building"
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              },
              "recommended": {
                "areaSquareMeters": 1240.5,
                "geofence": {
                  "circle": {
                    "latitude": 37.7749,
                    "longitude": -122.4194,
                    "radiusMeters": 150
                  },
                  "polygon": {
                    "vertices": [
                      {
                        "latitude": 37.7749,
                        "longitude": -122.4194
                      }
                    ]
                  },
                  "type": "circle"
                },
                "name": "Oakland Warehouse",
                "type": "building"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/places/geofence")
                    .WithParam("latitude", "1.1")
                    .WithParam("longitude", "1.1")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetPlaceGeofenceAsync(
            new GetPlaceGeofenceRequest { Latitude = 1.1, Longitude = 1.1 }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
