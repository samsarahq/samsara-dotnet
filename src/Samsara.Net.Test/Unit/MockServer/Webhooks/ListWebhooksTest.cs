using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Webhooks;

namespace Samsara.Net.Test.Unit.MockServer.Webhooks;

[TestFixture]
public class ListWebhooksTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "customHeaders": [
                    {
                      "key": "format",
                      "value": "xcmol-532"
                    }
                  ],
                  "eventTypes": [
                    "AddressCreated",
                    "AddressCreated"
                  ],
                  "id": "23918",
                  "name": "Webhook-123",
                  "secretKey": "11121-31231-1231212",
                  "url": "https://www.webhook-123.com/webhook/listener",
                  "version": "2018-01-01"
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/webhooks").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Webhooks.ListWebhooksAsync(new ListWebhooksRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<WebhooksListWebhooksResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
