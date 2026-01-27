using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Safety;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Safety;

[TestFixture]
public class V1GetVehicleSafetyScoreTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "crashCount": 0,
              "harshAccelCount": 1,
              "harshBrakingCount": 2,
              "harshEvents": [
                {
                  "harshEventType": "Harsh Braking",
                  "timestampMs": 1535590776000,
                  "vehicleId": 212014918086169
                }
              ],
              "harshTurningCount": 0,
              "safetyScore": 97,
              "safetyScoreRank": "26",
              "timeOverSpeedLimitMs": 3769,
              "totalDistanceDrivenMeters": 291836,
              "totalHarshEventCount": 3,
              "totalTimeDrivenMs": 19708293,
              "vehicleId": 4321
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/vehicles/1000000/safety/score")
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

        var response = await Client.Safety.V1GetVehicleSafetyScoreAsync(
            new V1GetVehicleSafetyScoreRequest
            {
                VehicleId = 1000000,
                StartMs = 1000000,
                EndMs = 1000000,
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<V1VehicleSafetyScoreResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
