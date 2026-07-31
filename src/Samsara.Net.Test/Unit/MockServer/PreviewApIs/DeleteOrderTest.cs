using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

[TestFixture]
public class DeleteOrderTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/preview/fleet/orders")
                    .WithParam("orderId", "orderId")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.PreviewApIs.DeleteOrderAsync(
                new DeleteOrderRequest { OrderId = "orderId" }
            )
        );
    }
}
