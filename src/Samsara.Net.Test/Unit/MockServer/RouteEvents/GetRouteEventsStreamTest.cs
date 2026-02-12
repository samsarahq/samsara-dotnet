using NUnit.Framework;
using Samsara.Net.RouteEvents;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.RouteEvents;

[TestFixture]
public class GetRouteEventsStreamTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "eventDetails": {
                    "stopEtaUpdated": {
                      "etaMs": "1640995200000",
                      "etaUpdatedAtMs": "1640995100000"
                    },
                    "stopTaskCompleted": {
                      "taskId": "789",
                      "taskType": "form"
                    },
                    "stopTaskSkipped": {
                      "taskId": "789",
                      "taskType": "form"
                    }
                  },
                  "eventTime": "2019-06-13T19:08:25.000Z",
                  "eventType": "stopArrived",
                  "happenedAtTime": "2019-06-13T19:08:25.000Z",
                  "id": "550e8400-e29b-41d4-a716-446655440000",
                  "route": {
                    "id": "494123"
                  },
                  "stop": {
                    "id": "141414"
                  }
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
                    .WithPath("/route-events/stream")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.RouteEvents.GetRouteEventsStreamAsync(
            new GetRouteEventsStreamRequest()
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
