using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetVehicleSafetyScoreTripsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "behaviors": [
                    {
                      "behaviorType": "acceleration",
                      "count": 1000000,
                      "scoreImpact": 1.1
                    },
                    {
                      "behaviorType": "acceleration",
                      "count": 1000000,
                      "scoreImpact": 1.1
                    }
                  ],
                  "driveDistanceMeters": 1000000,
                  "driverId": "driverId",
                  "speeding": [
                    {
                      "durationMilliseconds": 1000000,
                      "scoreImpact": 1.1,
                      "speedingType": "light"
                    },
                    {
                      "durationMilliseconds": 1000000,
                      "scoreImpact": 1.1,
                      "speedingType": "light"
                    }
                  ],
                  "tripEndTime": "tripEndTime",
                  "tripScoreImpact": 1.1,
                  "tripStartTime": "tripStartTime",
                  "vehicleId": "vehicleId"
                },
                {
                  "behaviors": [
                    {
                      "behaviorType": "acceleration",
                      "count": 1000000,
                      "scoreImpact": 1.1
                    },
                    {
                      "behaviorType": "acceleration",
                      "count": 1000000,
                      "scoreImpact": 1.1
                    }
                  ],
                  "driveDistanceMeters": 1000000,
                  "driverId": "driverId",
                  "speeding": [
                    {
                      "durationMilliseconds": 1000000,
                      "scoreImpact": 1.1,
                      "speedingType": "light"
                    },
                    {
                      "durationMilliseconds": 1000000,
                      "scoreImpact": 1.1,
                      "speedingType": "light"
                    }
                  ],
                  "tripEndTime": "tripEndTime",
                  "tripScoreImpact": 1.1,
                  "tripStartTime": "tripStartTime",
                  "vehicleId": "vehicleId"
                }
              ],
              "pagination": {
                "endCursor": "endCursor",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/safety-scores/vehicles/trips")
                    .WithParam("endTime", "endTime")
                    .WithParam("startTime", "startTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetVehicleSafetyScoreTripsAsync(
            new GetVehicleSafetyScoreTripsRequest { EndTime = "endTime", StartTime = "startTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
