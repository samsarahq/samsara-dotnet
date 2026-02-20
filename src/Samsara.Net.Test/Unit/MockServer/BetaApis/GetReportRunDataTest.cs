using NUnit.Framework;
using Samsara.Net.BetaApis;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApis;

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

        var response = await Client.BetaApis.GetReportRunDataAsync(
            new GetReportRunDataRequest { Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
