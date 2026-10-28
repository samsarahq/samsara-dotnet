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
                    "Dignissimos iusto quae pariatur vel non.",
                    "Porro corporis ipsum.",
                    "Eos doloribus omnis dolor."
                  ],
                  [
                    "Natus consequatur ad a.",
                    "Sit tempora.",
                    "Reiciendis quo assumenda.",
                    "Fugit ab ut nobis dolorem cupiditate eos."
                  ],
                  [
                    "Voluptatibus placeat qui impedit et et ut.",
                    "Necessitatibus vel voluptas nobis at dignissimos.",
                    "Officia aut qui et.",
                    "Dolores nobis quia voluptas mollitia officiis."
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
