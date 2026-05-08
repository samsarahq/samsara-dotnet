using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class DeleteFunctionStorageFileTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/functions-storage/files")
                    .WithParam("name", "name")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.BetaApIs.DeleteFunctionStorageFileAsync(
                new DeleteFunctionStorageFileRequest { Name = "name" }
            )
        );
    }
}
