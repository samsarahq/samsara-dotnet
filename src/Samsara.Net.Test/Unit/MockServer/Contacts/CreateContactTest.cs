using NUnit.Framework;
using Samsara.Net.Contacts;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Contacts;

[TestFixture]
public class CreateContactTest : BaseMockServerTest
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
                    .WithPath("/contacts")
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

        var response = await Client.Contacts.CreateContactAsync(new CreateContactRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
