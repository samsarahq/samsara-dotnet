using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class DeleteShopsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/shops")
                    .WithParam("id", "id")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.BetaApIs.DeleteShopsAsync(new DeleteShopsRequest { Id = "id" })
        );
    }
}
