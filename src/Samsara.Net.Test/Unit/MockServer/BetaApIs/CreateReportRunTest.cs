using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class CreateReportRunTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "reportConfig": {}
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "createdAtTime": "2019-06-13T19:08:25.000Z",
                "id": "4f71fd67-54f0-41de-991c-ee1e031134d1",
                "status": "complete",
                "updatedAtTime": "2019-06-13T19:08:25.000Z"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/reports/runs")
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

        var response = await Client.BetaApIs.CreateReportRunAsync(
            new ReportsCreateReportRunRequestBody
            {
                ReportConfig = new CreateReportConfigObjectRequestBody(),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
