using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetDriverSafetyScoresTest : BaseMockServerTest
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
                      "count": 5,
                      "scoreImpact": -18.91020325321117
                    }
                  ],
                  "driveDistanceMeters": 2207296,
                  "driveTimeMilliseconds": 136997730,
                  "driverId": "1234",
                  "driverScore": 92,
                  "speeding": [
                    {
                      "durationMilliseconds": 178773,
                      "scoreImpact": -0.13049340306587562,
                      "speedingType": "light"
                    }
                  ]
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
                    .WithPath("/safety-scores/drivers")
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

        var response = await Client.BetaApIs.GetDriverSafetyScoresAsync(
            new GetDriverSafetyScoresRequest { EndTime = "endTime", StartTime = "startTime" }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<SafetyScoresGetDriverSafetyScoresResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
