using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetTagGroupSafetyScoresTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "behaviors": [
                  {
                    "behaviorType": "acceleration",
                    "count": 5,
                    "scoreImpact": -18.91020325321117
                  }
                ],
                "combinedScore": 92,
                "driveDistanceMeters": 2207296,
                "driveTimeMilliseconds": 136997730,
                "speeding": [
                  {
                    "durationMilliseconds": 178773,
                    "scoreImpact": -0.13049340306587562,
                    "speedingType": "light"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/safety-scores/tag-group")
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

        var response = await Client.BetaApIs.GetTagGroupSafetyScoresAsync(
            new GetTagGroupSafetyScoresRequest
            {
                EndTime = "endTime",
                StartTime = "startTime",
                ScoreType = GetTagGroupSafetyScoresRequestScoreType.Driver,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
