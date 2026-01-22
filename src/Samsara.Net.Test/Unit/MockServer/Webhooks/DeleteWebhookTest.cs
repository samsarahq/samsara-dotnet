using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Webhooks;

namespace Samsara.Net.Test.Unit.MockServer.Webhooks;

[TestFixture]
public class DeleteWebhookTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/webhooks/id").UsingDelete())
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Webhooks.DeleteWebhookAsync(new DeleteWebhookRequest { Id = "id" })
        );
    }
}
