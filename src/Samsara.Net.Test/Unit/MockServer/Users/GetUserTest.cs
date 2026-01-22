using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Users;

namespace Samsara.Net.Test.Unit.MockServer.Users;

[TestFixture]
public class GetUserTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "authType": "default",
                "email": "user@company.com",
                "id": "123",
                "name": "Bob Smith",
                "roles": [
                  {
                    "expireAt": "2025-08-13T19:08:25.000Z"
                  }
                ]
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/users/id").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Users.GetUserAsync(new GetUserRequest { Id = "id" });
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<UserResponse>(mockResponse)).UsingDefaults()
        );
    }
}
