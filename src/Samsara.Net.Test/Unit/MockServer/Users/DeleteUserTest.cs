using NUnit.Framework;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Users;

namespace Samsara.Net.Test.Unit.MockServer.Users;

[TestFixture]
public class DeleteUserTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            ""
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/users/id").UsingDelete())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Users.DeleteUserAsync(new DeleteUserRequest { Id = "id" });
        Assert.That(response, Is.EqualTo(JsonUtils.Deserialize<string>(mockResponse)));
    }
}
