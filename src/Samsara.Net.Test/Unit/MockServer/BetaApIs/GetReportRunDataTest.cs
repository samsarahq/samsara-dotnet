using NUnit.Framework;
using Samsara.Net.BetaApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetReportRunDataTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "columns": [
                  {
                    "dataType": "string",
                    "name": "Device Name"
                  }
                ],
                "rows": [
                  [
                    "Aspernatur saepe aut dolorum.",
                    "Odio quo sint dolor eum quam sunt.",
                    "Doloribus in deserunt."
                  ],
                  [
                    "Temporibus enim quia.",
                    "Praesentium in accusamus neque maiores."
                  ],
                  [
                    "Et veritatis inventore ut debitis distinctio sed.",
                    "Hic tempore amet nostrum alias.",
                    "Ut commodi velit placeat animi qui dolor."
                  ]
                ],
                "status": "complete"
              },
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/reports/runs/data")
                    .WithParam("id", "id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetReportRunDataAsync(
            new GetReportRunDataRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
