using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.HoursOfService;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.HoursOfService;

[TestFixture]
public class GetHosViolationsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "violations": [
                    {
                      "day": {
                        "endTime": "2019-06-14T12:00:00.000Z",
                        "startTime": "2019-06-13T12:00:00.000Z"
                      },
                      "description": "Daily Off-Duty Time (Canada South-10 hours)",
                      "driver": {
                        "id": "45646",
                        "name": "Driver Bob"
                      },
                      "durationMs": 31970000,
                      "type": "NONE",
                      "violationStartTime": "2019-06-13T19:08:25.000Z"
                    }
                  ]
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
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/fleet/hos/violations")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.HoursOfService.GetHosViolationsAsync(
            new GetHosViolationsRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<HosViolationsGetHosViolationsResponseBody>(mockResponse)
                )
                .UsingDefaults()
        );
    }
}
