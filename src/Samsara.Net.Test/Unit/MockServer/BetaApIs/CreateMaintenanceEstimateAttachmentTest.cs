using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class CreateMaintenanceEstimateAttachmentTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "estimateId": "a81e26e6-50cd-4ae2-85b9-132c493c0871"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "createdAtTime": "2026-10-07T15:00:00.000Z",
                "id": "a81e26e6-50cd-4ae2-85b9-132c493c0871",
                "name": "repair-quote.pdf",
                "processingStatus": "unknown",
                "updatedAtTime": "2026-10-07T15:00:00.000Z",
                "uploadPut": {
                  "expiresAtTime": "2024-01-01T13:00:00.000Z",
                  "url": "https://s3.amazonaws.com/bucket/key?signature=abc123"
                },
                "url": "https://example.com/file",
                "urlExpiresAt": "2026-10-07T15:00:00.000Z"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/maintenance/estimates/attachments")
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

        var response = await Client.BetaApIs.CreateMaintenanceEstimateAttachmentAsync(
            new MaintenanceEstimateAttachmentsCreateMaintenanceEstimateAttachmentRequestBody
            {
                EstimateId = "a81e26e6-50cd-4ae2-85b9-132c493c0871",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
