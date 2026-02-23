using NUnit.Framework;
using Samsara.Net.Fleet.CarrierProposedAssignments;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Fleet.CarrierProposedAssignments;

[TestFixture]
public class DeleteTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/carrier-proposed-assignments/id")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Fleet.CarrierProposedAssignments.DeleteAsync(
                new DeleteCarrierProposedAssignmentsRequest { Id = "id" }
            )
        );
    }
}
