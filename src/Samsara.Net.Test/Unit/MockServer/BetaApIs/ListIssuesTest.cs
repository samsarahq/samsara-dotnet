using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class ListIssuesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAtTime": "2019-06-13T19:08:25Z",
                  "dashboardUrl": "https://cloud.samsara.com/o/123456/ground-intelligence/issues/123e4567-e89b-12d3-a456-426614174000",
                  "firstSeenTime": "2019-06-13T19:08:25Z",
                  "id": "123e4567-e89b-12d3-a456-426614174000",
                  "lastSeenTime": "2019-06-13T19:08:25Z",
                  "location": {
                    "type": "point"
                  },
                  "observationCount": 3,
                  "roadSegment": {
                    "roadName": "Market Street"
                  },
                  "severity": "high",
                  "status": "needsReview",
                  "type": "pothole",
                  "updatedAtTime": "2019-06-13T19:08:25Z"
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
                    .WithPath("/ground-intelligence/issues")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.ListIssuesAsync(new ListIssuesRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
