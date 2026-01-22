using NUnit.Framework;
using Samsara.Net.Contacts;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Contacts;

[TestFixture]
public class DeleteContactTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            ""
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/contacts/id").UsingDelete())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Contacts.DeleteContactAsync(
            new DeleteContactRequest { Id = "id" }
        );
        Assert.That(response, Is.EqualTo(JsonUtils.Deserialize<string>(mockResponse)));
    }
}
