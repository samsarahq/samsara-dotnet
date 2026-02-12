using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;
using Samsara.Net.Users;

namespace Samsara.Net.Test.Unit.MockServer.Users;

[TestFixture]
public class CreateUserTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "authType": "default",
              "email": "user@company.com",
              "name": "Bob Smith",
              "roles": [
                {
                  "roleId": "8a9371af-82d1-4158-bf91-4ecc8d3a114c"
                }
              ]
            }
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
                    "expireAt": "2025-08-13T19:08:25Z"
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/users")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Users.CreateUserAsync(
            new CreateUserRequest
            {
                AuthType = CreateUserRequestAuthType.Default,
                Email = "user@company.com",
                Name = "Bob Smith",
                Roles = new List<CreateUserRequestRoles>()
                {
                    new CreateUserRequestRoles { RoleId = "8a9371af-82d1-4158-bf91-4ecc8d3a114c" },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
