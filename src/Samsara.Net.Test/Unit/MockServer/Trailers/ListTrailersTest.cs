using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Trailers;

namespace Samsara.Net.Test.Unit.MockServer.Trailers;

[TestFixture]
public class ListTrailersTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "enabledForMobile": true,
                  "externalIds": {
                    "key": "value"
                  },
                  "id": "494123",
                  "installedGateway": {
                    "model": "AG15",
                    "serial": "GFRV-43N-VGX"
                  },
                  "licensePlate": "7TYP290",
                  "name": "Trailer-123",
                  "notes": "These are my trailer notes",
                  "tags": [
                    {
                      "id": "3914",
                      "name": "East Coast",
                      "parentTagId": "4815"
                    }
                  ],
                  "trailerSerialNumber": "8V8WD530FLN016251"
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/fleet/trailers").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Trailers.ListTrailersAsync(new ListTrailersRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<TrailersListTrailersResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
