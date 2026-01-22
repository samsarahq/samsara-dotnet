using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Trailers;

namespace Samsara.Net.Test.Unit.MockServer.Trailers;

[TestFixture]
public class GetTrailerTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": {
                "attributes": [
                  {
                    "dateValues": [
                      "2024-01-15",
                      "2024-12-31"
                    ],
                    "id": "494123",
                    "name": "Compliance/ELD",
                    "numberValues": [
                      867,
                      5309
                    ],
                    "stringValues": [
                      "HQ",
                      "Leased"
                    ]
                  }
                ],
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
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/fleet/trailers/id").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Trailers.GetTrailerAsync(new GetTrailerRequest { Id = "id" });
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<TrailersGetTrailerResponseBody>(mockResponse))
                .UsingDefaults()
        );
    }
}
