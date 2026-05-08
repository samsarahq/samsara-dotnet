using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

[TestFixture]
public class PairGatewaysTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "pairs": [
                {
                  "deviceSerial": "GFRV-43N-VGX",
                  "gatewaySerial": "GFRV-43N-VGX"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "data": [
                {
                  "device": {
                    "id": "8393848111",
                    "name": "Truck 17",
                    "serial": "ABCD-123-EFG",
                    "type": "vehicle"
                  },
                  "displacedGateway": {
                    "id": "8393848111",
                    "model": "AG15",
                    "serial": "GFRV-43N-VGX"
                  },
                  "gateway": {
                    "id": "8393848111",
                    "model": "AG15",
                    "serial": "GFRV-43N-VGX"
                  },
                  "previousDevice": {
                    "id": "8393848111",
                    "name": "Truck 17",
                    "serial": "ABCD-123-EFG",
                    "type": "vehicle"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/preview/gateways/pair")
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

        var response = await Client.PreviewApIs.PairGatewaysAsync(
            new GatewaysPairGatewaysRequestBody
            {
                Pairs = new List<PairGatewayPairObjectRequestBody>()
                {
                    new PairGatewayPairObjectRequestBody
                    {
                        DeviceSerial = "GFRV-43N-VGX",
                        GatewaySerial = "GFRV-43N-VGX",
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
