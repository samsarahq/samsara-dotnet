using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Webhooks;

[TestFixture]
public class GetWebhookTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "customHeaders": [
                {
                  "key": "format",
                  "value": "xcmol-532"
                }
              ],
              "eventTypes": [
                "AddressCreated",
                "AddressCreated",
                "AddressCreated",
                "AddressCreated"
              ],
              "id": "23918",
              "name": "Webhook-123",
              "secretKey": "11121-31231-1231212",
              "url": "https://www.webhook-123.com/webhook/listener",
              "version": "2018-01-01"
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/webhooks/id").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Webhooks.GetWebhookAsync("id");
        JsonAssert.AreEqual(response, mockResponse);
    }
}
