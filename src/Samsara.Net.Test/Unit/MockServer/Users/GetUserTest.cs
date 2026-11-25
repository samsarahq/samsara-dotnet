using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;
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
                    "expireAt": "2025-08-13T19:08:25Z",
                    "role": {
                      "id": "8a9371af-82d1-4158-bf91-4ecc8d3a114c",
                      "name": "Full Admin"
                    },
                    "tag": {
                      "id": "3914",
                      "name": "East Coast",
                      "parentTagId": "4815"
                    }
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
        JsonAssert.AreEqual(response, mockResponse);
    }
}
