using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.LocationAndSpeed;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.LocationAndSpeed;

[TestFixture]
public class GetLocationAndSpeedTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "asset": {
                    "id": "12345"
                  },
                  "happenedAtTime": "2020-01-27T07:06:25.000Z",
                  "location": {
                    "accuracyMeters": 5.801,
                    "headingDegrees": 120,
                    "latitude": 37.7749,
                    "longitude": 137.2719
                  },
                  "speed": {
                    "ecuSpeedMetersPerSecond": 30.2,
                    "gpsSpeedMetersPerSecond": 30.2
                  }
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
                    .WithPath("/assets/location-and-speed/stream")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.LocationAndSpeed.GetLocationAndSpeedAsync(
            new GetLocationAndSpeedRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<LocationAndSpeedGetLocationAndSpeedResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
