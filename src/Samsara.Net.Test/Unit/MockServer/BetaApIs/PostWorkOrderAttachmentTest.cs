using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class PostWorkOrderAttachmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "workOrderId": "123456"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "id": "0d5f0a5e-9b1a-4e3f-8a7b-2d5c6e9f0a1b",
                "uploadPut": {
                  "expiresAtTime": "2024-01-01T13:00:00.000Z",
                  "url": "https://s3.amazonaws.com/bucket/key?signature=abc123"
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/work-orders/attachments")
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

        var response = await Client.BetaApIs.PostWorkOrderAttachmentAsync(
            new WorkOrdersPostWorkOrderAttachmentRequestBody { WorkOrderId = "123456" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
