using NUnit.Framework;
using Samsara.Net.LiveSharingLinks;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.LiveSharingLinks;

[TestFixture]
public class DeleteLiveSharingLinkTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/live-shares")
                    .WithParam("id", "id")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.LiveSharingLinks.DeleteLiveSharingLinkAsync(
                new DeleteLiveSharingLinkRequest { Id = "id" }
            )
        );
    }
}
