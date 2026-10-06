using NUnit.Framework;
using Samsara.Net.Maintenance;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Maintenance;

[TestFixture]
public class DeleteWarrantyTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/warranties")
                    .WithParam("id", "id")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Maintenance.DeleteWarrantyAsync(new DeleteWarrantyRequest { Id = "id" })
        );
    }
}
