using NUnit.Framework;
using Samsara.Net.LegacyApis;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.LegacyApis;

[TestFixture]
public class GetSafetyActivityEventFeedTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "id": "1622151765-212014918174029-1550954461759",
                  "safetyEvent": {
                    "id": "212014918174029-1550954461759",
                    "time": "2019-06-13T19:08:25.455Z"
                  },
                  "time": "2019-10-12T07:20:50.52Z",
                  "type": "BehaviorLabelActivityType"
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
                    .WithPath("/fleet/safety-events/audit-logs/feed")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.LegacyApis.GetSafetyActivityEventFeedAsync(
            new GetSafetyActivityEventFeedRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
