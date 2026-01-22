using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Webhooks;

namespace Samsara.Net.Test.Unit.MockServer.Webhooks;

[TestFixture]
public class PostWebhooksTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "name": "Webhook-123",
              "url": "https://www.Webhook-123.com/webhook/listener"
            }
            """;

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
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/webhooks")
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

        var response = await Client.Webhooks.PostWebhooksAsync(
            new WebhooksPostWebhooksRequestBody
            {
                Name = "Webhook-123",
                Url = "https://www.Webhook-123.com/webhook/listener",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<WebhooksPostWebhooksResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
