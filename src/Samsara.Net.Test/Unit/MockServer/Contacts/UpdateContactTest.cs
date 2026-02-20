using NUnit.Framework;
using Samsara.Net.Contacts;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Contacts;

[TestFixture]
public class UpdateContactTest : BaseMockServerTest
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
                "email": "jane.jones@yahoo.com",
                "firstName": "Jane",
                "id": "22408",
                "lastName": "Jones",
                "phone": "111-222-3344"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/contacts/id")
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

        var response = await Client.Contacts.UpdateContactAsync("id", new UpdateContactRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
