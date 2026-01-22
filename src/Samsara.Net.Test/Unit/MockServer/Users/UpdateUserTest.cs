using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Users;

namespace Samsara.Net.Test.Unit.MockServer.Users;

[TestFixture]
public class UpdateUserTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

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
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/users/id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Users.UpdateUserAsync(new UpdateUserRequest { Id = "id" });
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<UserResponse>(mockResponse)).UsingDefaults()
        );
    }
}
