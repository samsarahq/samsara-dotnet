using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Maintenance;

[TestFixture]
public class V1GetFleetMaintenanceListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "vehicles": [
                {
                  "id": 112
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/maintenance/list")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Maintenance.V1GetFleetMaintenanceListAsync();
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<InlineResponse2004>(mockResponse)).UsingDefaults()
        );
    }
}
