using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.WorkOrders;

namespace Samsara.Net.Test.Unit.MockServer.WorkOrders;

[TestFixture]
public class PostInvoiceScanTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "file": {
                "base64Content": "JVBERi0xLjQKJeLjz9MKMyAwIG9iago8P...",
                "contentType": "application/pdf"
              }
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "workOrderId": "123456"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/invoice-scans")
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

        var response = await Client.WorkOrders.PostInvoiceScanAsync(
            new WorkOrdersPostInvoiceScanRequestBody
            {
                File = new InvoiceScanFileRequestBody
                {
                    Base64Content = "JVBERi0xLjQKJeLjz9MKMyAwIG9iago8P...",
                    ContentType = "application/pdf",
                },
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<WorkOrdersPostInvoiceScanResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
