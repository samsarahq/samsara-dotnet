using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;
using Samsara.Net.TrainingAssignments;

namespace Samsara.Net.Test.Unit.MockServer.TrainingAssignments;

[TestFixture]
public class GetTrainingAssignmentsStreamTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "completedAtTime": "2019-06-13T19:08:25.000Z",
                  "course": {
                    "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                    "revisionId": "1214a1fa-f0c6-408b-bf85-51dc3bc71ac7"
                  },
                  "createdAtTime": "2019-06-13T19:08:25.000Z",
                  "createdById": "user-4392",
                  "deletedAtTime": "2019-06-13T19:08:25.000Z",
                  "dueAtTime": "2019-06-13T19:08:25.000Z",
                  "durationMinutes": 3319834036943304700,
                  "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                  "isCompletedLate": true,
                  "isOverdue": true,
                  "learner": {
                    "id": "938172",
                    "type": "driver"
                  },
                  "scorePercent": 0.3749615068819778,
                  "startedAtTime": "2019-06-13T19:08:25.000Z",
                  "status": "notStarted",
                  "updatedAtTime": "2019-06-13T19:08:25.000Z",
                  "updatedById": "user-3112"
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
                    .WithPath("/training-assignments/stream")
                    .WithParam("startTime", "startTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.TrainingAssignments.GetTrainingAssignmentsStreamAsync(
            new GetTrainingAssignmentsStreamRequest { StartTime = "startTime" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
