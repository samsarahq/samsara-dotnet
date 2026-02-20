using NUnit.Framework;
using Samsara.Net.BetaApis;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApis;

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

        var response = await Client.BetaApis.GetDriverSafetyScoresAsync(
            new GetDriverSafetyScoresRequest { EndTime = "endTime", StartTime = "startTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
