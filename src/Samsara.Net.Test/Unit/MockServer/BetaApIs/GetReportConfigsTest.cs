using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetReportConfigsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "columns": [
                    {
                      "dataType": "string",
                      "name": "Asset: Id"
                    }
                  ],
                  "datasetId": "Assets",
                  "filters": {
                    "primaryTimeRange": {
                      "endTime": "2019-06-13T21:08:25.000Z",
                      "startTime": "2019-06-13T19:08:25.000Z"
                    }
                  },
                  "id": "4f71fd67-54f0-41de-991c-ee1e031134d1",
                  "name": "Asset Report"
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/reports/configs").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetReportConfigsAsync(new GetReportConfigsRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ReportsGetReportConfigsResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
