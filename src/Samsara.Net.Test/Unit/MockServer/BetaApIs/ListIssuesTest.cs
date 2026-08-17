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
                  "createdAtTime": "2026-08-06T08:00:00Z",
                  "dashboardUrl": "https://cloud.samsara.com/o/123456/ground-intelligence/issues/5267696d-a9f9-4031-bdf4-6fbc9ec64e57",
                  "firstSeenTime": "2026-08-06T08:00:00Z",
                  "id": "5267696d-a9f9-4031-bdf4-6fbc9ec64e57",
                  "lastSeenTime": "2026-08-06T09:00:00Z",
                  "location": {
                    "type": "point"
                  },
                  "observationCount": 3,
                  "roadSegment": {
                    "roadName": "Market Street"
                  },
                  "severity": "high",
                  "status": "dismissed",
                  "type": "pothole",
                  "updatedAtTime": "2026-08-06T10:00:00Z"
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
