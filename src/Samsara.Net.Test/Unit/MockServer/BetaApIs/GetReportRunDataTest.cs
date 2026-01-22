using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

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
                    {
                      "key": "value"
                    },
                    {
                      "key": "value"
                    },
                    {
                      "key": "value"
                    },
                    {
                      "key": "value"
                    }
                  ],
                  [
                    {
                      "key": "value"
                    },
                    {
                      "key": "value"
                    },
                    {
                      "key": "value"
                    },
                    {
                      "key": "value"
                    }
                  ],
                  [
                    {
                      "key": "value"
                    },
                    {
                      "key": "value"
                    },
                    {
                      "key": "value"
                    }
                  ],
                  [
                    {
                      "key": "value"
                    },
                    {
                      "key": "value"
                    },
                    {
                      "key": "value"
                    }
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
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ReportsGetReportRunDataResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
