using NUnit.Framework;
using Samsara.Net.Gateways;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.Gateways;

[TestFixture]
public class PostGatewayTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "serial": "GFRV-43N-VGX"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "accessoryDevices": [
                  {
                    "model": "EM11",
                    "serial": "ABCD-123-EFG"
                  }
                ],
                "asset": {
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "8393848111"
                },
                "connectionStatus": {
                  "healthStatus": "Status Not Set",
                  "lastConnected": "2019-06-13T19:08:25Z"
                },
                "dataUsageLast30Days": {
                  "cellularDataUsageBytes": 9113941723943371000,
                  "hotspotUsageBytes": 1229880709321352700
                },
                "model": "AG15",
                "serial": "GFRV-43N-VGX"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/gateways")
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

        var response = await Client.Gateways.PostGatewayAsync(
            new GatewaysPostGatewayRequestBody { Serial = "GFRV-43N-VGX" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
