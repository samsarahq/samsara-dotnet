using NUnit.Framework;
using Samsara.Net.Attributes;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Attributes;

[TestFixture]
public class DeleteTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/attributes/id")
                    .WithParam("entityType", "driver")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Attributes.DeleteAsync(
                new DeleteAttributesRequest
                {
                    Id = "id",
                    EntityType = DeleteAttributesRequestEntityType.Driver,
                }
            )
        );
    }
}
