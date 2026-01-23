using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Forms;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Forms;

[TestFixture]
public class GetFormSubmissionsPdfExportsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "completedAtTime": "2019-06-13T19:08:25.000Z",
                "errorMessage": "PDF export timed out.",
                "expiresAtTime": "2019-06-13T19:08:25.000Z",
                "id": "9814a1fa-f0c6-408b-bf85-51dc3bc71ac7",
                "jobStatus": "unknown",
                "pdfId": "300af62b-5aea-43a9-b4cf-a59667e817ed",
                "pdfUrl": "https://samsara-pdf-exports.s3.us-west-2.amazonaws.com/123456",
                "pdfUrlExpiresAtTime": "2019-06-13T19:08:25.000Z",
                "requestedAtTime": "2019-06-13T19:08:25.000Z"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/form-submissions/pdf-exports")
                    .WithParam("pdfId", "pdfId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Forms.GetFormSubmissionsPdfExportsAsync(
            new GetFormSubmissionsPdfExportsRequest { PdfId = "pdfId" }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<FormSubmissionsGetFormSubmissionsPdfExportsResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
