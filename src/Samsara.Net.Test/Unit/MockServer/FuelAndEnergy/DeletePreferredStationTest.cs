using NUnit.Framework;
using Samsara.Net.FuelAndEnergy;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.FuelAndEnergy;

[TestFixture]
public class DeletePreferredStationTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/preferred-stations")
                    .WithParam("id", "id")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.FuelAndEnergy.DeletePreferredStationAsync(
                new DeletePreferredStationRequest { Id = "id" }
            )
        );
    }
}
