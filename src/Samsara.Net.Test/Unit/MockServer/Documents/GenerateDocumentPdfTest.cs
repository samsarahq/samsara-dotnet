using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Documents;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Documents;

[TestFixture]
public class GenerateDocumentPdfTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "documentId": "6c8c0c01-206a-41a4-9d21-15b9978d04cb"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "documentId": "6c8c0c01-206a-41a4-9d21-15b9978d04cb",
                "id": "5c8c0c01-206a-41a4-9d21-15b9978d04cb"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/documents/pdfs")
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

        var response = await Client.Documents.GenerateDocumentPdfAsync(
            new DocumentPdfGenerationRequest { DocumentId = "6c8c0c01-206a-41a4-9d21-15b9978d04cb" }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<DocumentPdfGenerationResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
