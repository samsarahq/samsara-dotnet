using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.Assets;
using Samsara.Net.Core;
using Samsara.Net.Test.Unit.MockServer;

namespace Samsara.Net.Test.Unit.MockServer.Assets;

[TestFixture]
public class V1GetAllAssetCurrentLocationsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "assets": [
                {
                  "assetSerialNumber": "8dka2810",
                  "cable": {
                    "assetType": "Thermo King"
                  },
                  "engineHours": 104,
                  "id": 1,
                  "location": [
                    {
                      "latitude": 37,
                      "location": "525 York, San Francisco, CA",
                      "longitude": -122.7,
                      "speedMilesPerHour": 35,
                      "timeMs": 12314151
                    }
                  ],
                  "name": "Trailer 123"
                }
              ],
              "pagination": {
                "endCursor": "MTU5MTEzNjA2OTU0MzQ3",
                "hasNextPage": true,
                "hasPrevPage": true,
                "startCursor": "MTU5MTEzNjA2OTU0MzQ3"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/fleet/assets/locations")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Assets.V1GetAllAssetCurrentLocationsAsync(
            new V1GetAllAssetCurrentLocationsRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<InlineResponse2002>(mockResponse)).UsingDefaults()
        );
    }
}
