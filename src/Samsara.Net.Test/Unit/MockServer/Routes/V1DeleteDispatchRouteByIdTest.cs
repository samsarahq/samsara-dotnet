using NUnit.Framework;
using Samsara.Net.Routes;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Routes;

[TestFixture]
public class V1DeleteDispatchRouteByIdTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/dispatch/routes/route_id_or_external_id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingDelete()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Routes.V1DeleteDispatchRouteByIdAsync(
                "route_id_or_external_id",
                new InlineObject()
            )
        );
    }
}
