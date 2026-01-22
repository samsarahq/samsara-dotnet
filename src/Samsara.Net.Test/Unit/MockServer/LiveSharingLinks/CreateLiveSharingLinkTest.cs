using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Core;
using Samsara.Net.LiveSharingLinks;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.LiveSharingLinks;

[TestFixture]
public class CreateLiveSharingLinkTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "name": "Example Live Sharing Link name",
              "type": "assetsLocation"
            }
            """;

        const string mockResponse = """
            {
              "data": {
                "assetsLocationLinkConfig": {
                  "assetId": "1234",
                  "location": {
                    "formattedAddress": "1990 Alameda Street, San Francisco, CA 94103",
                    "latitude": 37.456345,
                    "longitude": 34.5633749,
                    "name": "Suburbs"
                  },
                  "tags": [
                    {
                      "id": "3914",
                      "name": "East Coast",
                      "parentTagId": "4815"
                    }
                  ]
                },
                "assetsNearLocationLinkConfig": {
                  "addressId": "1234"
                },
                "assetsOnRouteLinkConfig": {
                  "recurringRouteId": "1234"
                },
                "description": "Sample description",
                "expiresAtTime": "2020-01-27T07:06:25.000Z",
                "id": "leesdwqjx42dkvp86so",
                "liveSharingUrl": "https://cloud.samsara.com/o/123456/fleet/viewer/address/7hf4lnu455wep22rtun",
                "name": "Example Live Sharing Link name",
                "type": "assetsLocation"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/live-shares")
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

        var response = await Client.LiveSharingLinks.CreateLiveSharingLinkAsync(
            new LiveSharingLinksCreateLiveSharingLinkRequestBody
            {
                Name = "Example Live Sharing Link name",
                Type = LiveSharingLinksCreateLiveSharingLinkRequestBodyType.AssetsLocation,
            }
        );
        Assert.That(
            response,
            Is.EqualTo(
                    JsonUtils.Deserialize<LiveSharingLinksCreateLiveSharingLinkResponseBody>(
                        mockResponse
                    )
                )
                .UsingDefaults()
        );
    }
}
