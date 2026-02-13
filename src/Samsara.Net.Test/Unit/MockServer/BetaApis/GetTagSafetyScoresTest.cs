using NUnit.Framework;
using Samsara.Net.BetaApis;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApis;

[TestFixture]
public class GetTagSafetyScoresTest : BaseMockServerTest
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
                  "speeding": [
                    {
                      "durationMilliseconds": 178773,
                      "scoreImpact": -0.13049340306587562,
                      "speedingType": "light"
                    }
                  ],
                  "tagId": "5678",
                  "tagScore": 92
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
                    .WithPath("/safety-scores/tags")
                    .WithParam("endTime", "endTime")
                    .WithParam("startTime", "startTime")
                    .WithParam("scoreType", "driver")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApis.GetTagSafetyScoresAsync(
            new GetTagSafetyScoresRequest
            {
                EndTime = "endTime",
                StartTime = "startTime",
                ScoreType = GetTagSafetyScoresRequestScoreType.Driver,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
