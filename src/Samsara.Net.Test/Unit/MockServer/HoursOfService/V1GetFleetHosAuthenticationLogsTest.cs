using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.HoursOfService;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.HoursOfService;

[TestFixture]
public class V1GetFleetHosAuthenticationLogsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "authenticationLogs": [
                {
                  "actionType": "signin",
                  "address": "THIS FIELD MAY NOT BE POPULATED",
                  "addressName": "THIS FIELD MAY NOT BE POPULATED",
                  "city": "THIS FIELD MAY NOT BE POPULATED",
                  "happenedAtMs": 1462881998034,
                  "state": "THIS FIELD MAY NOT BE POPULATED"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/hos_authentication_logs")
                    .WithParam("driverId", "1000000")
                    .WithParam("startMs", "1000000")
                    .WithParam("endMs", "1000000")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.HoursOfService.V1GetFleetHosAuthenticationLogsAsync(
            new V1GetFleetHosAuthenticationLogsRequest
            {
                DriverId = 1000000,
                StartMs = 1000000,
                EndMs = 1000000,
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<V1HosAuthenticationLogsResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
