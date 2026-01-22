using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetDriverEfficiencyTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "driverSummaries": [
                  {}
                ],
                "summaryEndTime": "2020-03-16T16:00:00.000Z",
                "summaryStartTime": "2020-03-15T16:00:00.000Z"
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
                    .WithPath("/beta/fleet/drivers/efficiency")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetDriverEfficiencyAsync(
            new GetDriverEfficiencyRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<DriverEfficienciesResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
