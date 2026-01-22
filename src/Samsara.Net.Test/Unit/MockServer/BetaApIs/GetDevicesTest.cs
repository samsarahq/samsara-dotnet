using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.BetaApIs;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.BetaApIs;

[TestFixture]
public class GetDevicesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "asset": {
                    "id": "281474982859091",
                    "name": "MyAsset-1234"
                  },
                  "health": {
                    "primaryHealthReasonStartTime": "2019-06-13T19:08:25.000Z"
                  },
                  "lastConnectedTime": "2019-06-13T19:08:25.000Z",
                  "lastKnownLocation": {
                    "id": 12345,
                    "latitude": 12333122.3,
                    "longitude": 1233331.4
                  },
                  "model": "AG24",
                  "serial": "ABCD-123-EFG",
                  "tags": [
                    {
                      "id": "3914",
                      "name": "East Coast",
                      "parentTagId": "4815"
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
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/devices").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApIs.GetDevicesAsync(new GetDevicesRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<DevicesGetDevicesResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
