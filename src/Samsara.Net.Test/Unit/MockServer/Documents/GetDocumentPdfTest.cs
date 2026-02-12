using NUnit.Framework;
using Samsara.Net.Documents;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Documents;

[TestFixture]
public class GetDocumentPdfTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "completedAtTime": "2020-01-02T15:04:06+07:00",
                "documentId": "6c8c0c01-206a-41a4-9d21-15b9978d04cb",
                "downloadDocumentPdfUrl": "https://samsara-driver-document-pdfs.s3.us-west-2.amazonaws.com/org/38487/42a4cffc-409d-4ddf-ba1c-5e3bbb961cba?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASI...&X-Amz-Date=20200423T162507Z&X-Amz-Expires=86400&X-Amz-Security-Token=IQoJ...-Amz-SignedHeaders=host&response-expires=2020-04-24T16%3A25%3A07Z&X-Amz-Signature=1c6fe87...",
                "id": "5c8c0c01-206a-41a4-9d21-15b9978d04cb",
                "jobStatus": "requested",
                "requestedAtTime": "2020-01-02T15:04:05+07:00"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/documents/pdfs/id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Documents.GetDocumentPdfAsync(
            new GetDocumentPdfRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
