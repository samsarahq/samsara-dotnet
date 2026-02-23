using NUnit.Framework;
using Samsara.Net.Addresses;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Addresses;

[TestFixture]
public class DeleteTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/addresses/id").UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Addresses.DeleteAsync(new DeleteAddressesRequest { Id = "id" })
        );
    }
}
