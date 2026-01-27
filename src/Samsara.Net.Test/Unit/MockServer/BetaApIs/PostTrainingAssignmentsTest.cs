using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class PostTrainingAssignmentsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "course": {
                    "id": "id",
                    "revisionId": "revisionId"
                  },
                  "createdAtTime": "2024-01-15T09:30:00.000Z",
                  "createdById": "createdById",
                  "dueAtTime": "2024-01-15T09:30:00.000Z",
                  "id": "id",
                  "isExistingAssignment": true,
                  "learner": {
                    "id": "id",
                    "type": "driver"
                  }
                },
                {
                  "course": {
                    "id": "id",
                    "revisionId": "revisionId"
                  },
                  "createdAtTime": "2024-01-15T09:30:00.000Z",
                  "createdById": "createdById",
                  "dueAtTime": "2024-01-15T09:30:00.000Z",
                  "id": "id",
                  "isExistingAssignment": true,
                  "learner": {
                    "id": "id",
                    "type": "driver"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/training-assignments")
                    .WithParam("courseId", "courseId")
                    .WithParam("dueAtTime", "dueAtTime")
                    .UsingPost()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.PostTrainingAssignmentsAsync(
            new PostTrainingAssignmentsRequest { CourseId = "courseId", DueAtTime = "dueAtTime" }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<TrainingAssignmentsPostTrainingAssignmentsResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
