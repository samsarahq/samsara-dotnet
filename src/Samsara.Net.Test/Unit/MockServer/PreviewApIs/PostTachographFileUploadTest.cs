using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

[TestFixture]
public class PostTachographFileUploadTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "contentMd5": "rL0Y20zC+Fzt72VPzMSk2A==",
              "contentType": "application/octet-stream",
              "fileSizeBytes": 8192,
              "fileType": "driverCard"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "expiresAtTime": "2024-01-01T13:00:00.000Z",
                "requiredHeaders": [
                  {
                    "name": "Content-MD5",
                    "value": "rL0Y20zC+Fzt72VPzMSk2A=="
                  }
                ],
                "uploadUrl": "https://example-bucket.s3.amazonaws.com/tachograph-uploads/v1/...?X-Amz-Signature=..."
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/preview/fleet/tachograph/file-uploads")
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

        var response = await Client.PreviewApIs.PostTachographFileUploadAsync(
            new TachographFileUploadsPostTachographFileUploadRequestBody
            {
                ContentMd5 = "rL0Y20zC+Fzt72VPzMSk2A==",
                ContentType =
                    TachographFileUploadsPostTachographFileUploadRequestBodyContentType.ApplicationOctetStream,
                FileSizeBytes = 8192,
                FileType =
                    TachographFileUploadsPostTachographFileUploadRequestBodyFileType.DriverCard,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
