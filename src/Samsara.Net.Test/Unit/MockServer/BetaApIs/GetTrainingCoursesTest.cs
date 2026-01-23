using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetTrainingCoursesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "category": {
                    "id": "a4db8702-79d5-4396-a717-e301d52ecc11",
                    "name": "Samsara Driver App"
                  },
                  "description": "Training for how to operate a wheel loader.",
                  "estimatedTimeToCompleteMinutes": 30,
                  "id": "a4db8702-79d5-4396-a717-e301d52ecc11",
                  "labels": [
                    {
                      "name": "safety",
                      "type": "accel"
                    }
                  ],
                  "revisionId": "1214a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                  "status": "published",
                  "title": "Wheel Loader"
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
                WireMock.RequestBuilders.Request.Create().WithPath("/training-courses").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetTrainingCoursesAsync(
            new GetTrainingCoursesRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<TrainingCoursesGetTrainingCoursesResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
