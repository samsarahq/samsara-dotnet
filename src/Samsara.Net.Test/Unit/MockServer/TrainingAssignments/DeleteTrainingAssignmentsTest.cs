using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.TrainingAssignments;

namespace Samsara.Net.Test.Unit.MockServer.TrainingAssignments;

[TestFixture]
public class DeleteTrainingAssignmentsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/training-assignments")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.TrainingAssignments.DeleteTrainingAssignmentsAsync(
                new DeleteTrainingAssignmentsRequest()
            )
        );
    }
}
