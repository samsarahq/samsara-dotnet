using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Gateways;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Gateways;

[TestFixture]
public class GetGatewaysTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "accessoryDevices": [
                    {
                      "model": "EM11",
                      "serial": "ABCD-123-EFG"
                    }
                  ],
                  "asset": {
                    "id": "8393848111"
                  },
                  "connectionStatus": {
                    "lastConnected": "2019-06-13T19:08:25.000Z"
                  },
                  "dataUsageLast30Days": {
                    "cellularDataUsageBytes": 9113941723943371000,
                    "hotspotUsageBytes": 1229880709321352700
                  },
                  "model": "AG15",
                  "serial": "GFRV-43N-VGX"
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/gateways").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Gateways.GetGatewaysAsync(new GetGatewaysRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<GatewaysGetGatewaysResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
