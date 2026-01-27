using NUnit.Framework;
using Samsara.Net.Alerts;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Alerts;

[TestFixture]
public class DeleteConfigurationsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/alerts/configurations")
                    .WithParam("id", "id")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Alerts.DeleteConfigurationsAsync(
                new DeleteConfigurationsRequest { Id = "id" }
            )
        );
    }
}
