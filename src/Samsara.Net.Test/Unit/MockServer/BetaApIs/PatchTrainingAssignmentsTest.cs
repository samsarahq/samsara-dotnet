using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class PatchTrainingAssignmentsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "completedAtTime": "2024-01-15T09:30:00.000Z",
                  "course": {
                    "id": "id",
                    "revisionId": "revisionId"
                  },
                  "createdAtTime": "2024-01-15T09:30:00.000Z",
                  "createdById": "createdById",
                  "deletedAtTime": "2024-01-15T09:30:00.000Z",
                  "dueAtTime": "2024-01-15T09:30:00.000Z",
                  "durationMinutes": 1000000,
                  "id": "id",
                  "isCompletedLate": true,
                  "isOverdue": true,
                  "learner": {
                    "id": "id",
                    "type": "driver"
                  },
                  "scorePercent": 1.1,
                  "startedAtTime": "2024-01-15T09:30:00.000Z",
                  "status": "notStarted",
                  "updatedAtTime": "2024-01-15T09:30:00.000Z",
                  "updatedById": "updatedById"
                },
                {
                  "completedAtTime": "2024-01-15T09:30:00.000Z",
                  "course": {
                    "id": "id",
                    "revisionId": "revisionId"
                  },
                  "createdAtTime": "2024-01-15T09:30:00.000Z",
                  "createdById": "createdById",
                  "deletedAtTime": "2024-01-15T09:30:00.000Z",
                  "dueAtTime": "2024-01-15T09:30:00.000Z",
                  "durationMinutes": 1000000,
                  "id": "id",
                  "isCompletedLate": true,
                  "isOverdue": true,
                  "learner": {
                    "id": "id",
                    "type": "driver"
                  },
                  "scorePercent": 1.1,
                  "startedAtTime": "2024-01-15T09:30:00.000Z",
                  "status": "notStarted",
                  "updatedAtTime": "2024-01-15T09:30:00.000Z",
                  "updatedById": "updatedById"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/training-assignments")
                    .WithParam("dueAtTime", "dueAtTime")
                    .UsingPatch()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.PatchTrainingAssignmentsAsync(
            new PatchTrainingAssignmentsRequest { DueAtTime = "dueAtTime" }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<TrainingAssignmentsPatchTrainingAssignmentsResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
