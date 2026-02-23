using NUnit.Framework;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;
using Samsara.Net.Webhooks;

namespace Samsara.Net.Test.Unit.MockServer.Webhooks;

[TestFixture]
public class PatchWebhookTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {}
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
                    .WithPath("/webhooks/id")
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

        var response = await Client.Webhooks.PatchWebhookAsync(
            new WebhooksPatchWebhookRequestBody { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
