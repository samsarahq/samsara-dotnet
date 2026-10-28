using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class DeleteMaintenanceEstimateAttachmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/estimates/attachments")
                    .WithParam("id", "id")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.BetaApIs.DeleteMaintenanceEstimateAttachmentAsync(
                new DeleteMaintenanceEstimateAttachmentRequest { Id = "id" }
            )
        );
    }
}
