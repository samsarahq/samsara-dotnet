using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.WorkOrders;

namespace Samsara.Net.Test.Unit.MockServer.WorkOrders;

[TestFixture]
public class DeleteWorkOrdersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/work-orders")
                    .WithParam("id", "id")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.WorkOrders.DeleteWorkOrdersAsync(new DeleteWorkOrdersRequest { Id = "id" })
        );
    }
}
