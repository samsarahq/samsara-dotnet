using NUnit.Framework;
using Samsara.Net.Contacts;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Contacts;

[TestFixture]
public class ListContactsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "email": "jane.jones@yahoo.com",
                  "firstName": "Jane",
                  "id": "22408",
                  "lastName": "Jones",
                  "phone": "111-222-3344"
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/contacts").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Contacts.ListContactsAsync(new ListContactsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
