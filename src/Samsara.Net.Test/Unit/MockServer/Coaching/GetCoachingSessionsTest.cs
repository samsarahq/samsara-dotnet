using System.Globalization;
using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Coaching;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Coaching;

[TestFixture]
public class GetCoachingSessionsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "assignedCoachId": "45646",
                  "behaviors": [
                    {
                      "coachableBehaviorType": "acceleration",
                      "coachableEvents": [
                        {
                          "id": "f5271458-21f9-4a9f-a290-780c6d8840ff"
                        }
                      ],
                      "id": "f5271458-21f9-4a9f-a290-780c6d8840ff",
                      "lastCoachedTime": "2019-06-13T19:08:25.000Z",
                      "note": "Need to wear seatbelt even for short trips.",
                      "updatedAtTime": "2019-06-13T19:08:25.000Z"
                    }
                  ],
                  "coachingType": "fullySharedWithManager",
                  "completedAtTime": "2019-06-13T19:08:25.000Z",
                  "completedCoachId": "45646",
                  "driver": {
                    "driverId": "0987"
                  },
                  "dueAtTime": "2019-06-13T19:08:25.000Z",
                  "id": "f5271458-21f9-4a9f-a290-780c6d8840ff",
                  "sessionNote": "Need to wear seatbelt even for short trips.",
                  "sessionStatus": "unknown",
                  "updatedAtTime": "2019-06-13T19:08:25.000Z"
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
                    .WithPath("/coaching/sessions/stream")
                    .WithParam("startTime", "2024-01-15T09:30:00.000Z")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Coaching.GetCoachingSessionsAsync(
            new GetCoachingSessionsRequest
            {
                StartTime = DateTime.Parse(
                    "2024-01-15T09:30:00.000Z",
                    null,
                    DateTimeStyles.AdjustToUniversal
                ),
            }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<CoachingSessionsGetCoachingSessionsResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
